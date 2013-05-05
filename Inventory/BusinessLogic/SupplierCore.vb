Namespace BusinessLogic
    Public Class SupplierCore
        Public Function GetSuppliers() As List(Of Supplier)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From supplier In entity.Supplier Order By supplier.Kode_Supplier
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetSupplier(ByVal kodeSupplier As String) As Supplier
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From supplier In entity.Supplier Where supplier.Kode_Supplier = kodeSupplier
                Dim result = query.ToList().FirstOrDefault()
                If result Is Nothing Then
                    Throw New Exception("Data supplier dengan kode " & kodeSupplier & " tidak ditemukan")
                End If
                Return result
            End Using
        End Function

        Public Sub DeleteSupplier(ByVal text As String)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim msupplier = (From supplier In entity.Supplier Where supplier.Kode_Supplier = text Select supplier).ToList().FirstOrDefault()
                If msupplier Is Nothing Then
                    Throw New Exception("Delete failed, Data supplier dengan kode " + text + " tidak terdapat di dalam database")
                Else
                    entity.DeleteObject(msupplier)
                    entity.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub UpdateSupplier(ByVal supplier As Supplier)
            Using entity As New InventoryArcomaBascoEntities2()
                ValidasiSupplier(supplier)
                Dim msupplier = (From supplierTable In entity.Supplier Where supplierTable.Kode_Supplier = supplier.Kode_Supplier Select supplierTable).ToList().FirstOrDefault()
                If msupplier Is Nothing Then
                    Throw New Exception("Update failed, Data supplier dengan kode " + supplier.Kode_Supplier + " tidak terdapat di dalam database")
                Else
                    msupplier.Alamat = supplier.Alamat
                    msupplier.Email = supplier.Email
                    msupplier.Nama_Supplier = supplier.Nama_Supplier
                    msupplier.Telepon = supplier.Telepon
                    entity.SaveChanges()
                End If
            End Using
        End Sub

        Private Sub ValidasiSupplier(ByVal supplier As Supplier)
            If String.IsNullOrEmpty(supplier.Kode_Supplier) Then
                Throw New Exception("Kode Supplier Harus Diisi")
            End If
            If String.IsNullOrEmpty(supplier.Nama_Supplier) Then
                Throw New Exception("Nama Supplier Harus Diisi")
            End If
        End Sub

        Public Sub InsertSupplier(ByVal supplierModel As Supplier)
            Using entity As New InventoryArcomaBascoEntities2()
                ValidasiSupplier(supplierModel)
                Dim msupplier = (From supplierTable In entity.Supplier Where supplierTable.Kode_Supplier = supplierModel.Kode_Supplier Select supplierTable).ToList().FirstOrDefault()
                If msupplier Is Nothing Then
                    entity.AddToSupplier(supplierModel)
                    entity.SaveChanges()
                Else
                    Throw New Exception("Insert failed, Data supplier dengan kode " + supplierModel.Kode_Supplier + " sudah ada di dalam database")
                End If
            End Using
        End Sub

        Public Function GetSupplierForCombo()
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From table In entity.Supplier Order By table.Kode_Supplier Ascending
                Return query.Select(Function(a) New With {.SupplierKodeName = a.Kode_Supplier & " - " & a.Nama_Supplier, a.Kode_Supplier}).ToList()
            End Using
        End Function
    End Class
End Namespace