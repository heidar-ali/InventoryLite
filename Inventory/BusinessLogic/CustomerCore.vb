Namespace BusinessLogic
    Public Class CustomerCore
        Public Function GetCustomers() As List(Of Customer)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From customer In entity.Customer Order By customer.Kode_Customer
                Return query.ToList()
            End Using
        End Function

        Public Sub DeleteCustomer(ByVal text As String)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim msupplier = (From customer In entity.Customer Where customer.Kode_Customer = text Select customer).ToList().FirstOrDefault()
                If msupplier Is Nothing Then
                    Throw New Exception("Delete failed, Data customer dengan kode " + text + " tidak terdapat di dalam database")
                Else
                    entity.DeleteObject(msupplier)
                    entity.SaveChanges()
                End If
            End Using
        End Sub

        Public Sub UpdateCustomer(ByVal customer As Customer)
            Using entity As New InventoryArcomaBascoEntities2()
                ValidasiSupplier(customer)
                Dim mcustomer = (From customerTable In entity.Customer Where customerTable.Kode_Customer = customer.Kode_Customer Select customerTable).ToList().FirstOrDefault()
                If mcustomer Is Nothing Then
                    Throw New Exception("Update failed, Data customer dengan kode " + customer.Kode_Customer + " tidak terdapat di dalam database")
                Else
                    mcustomer.Alamat = customer.Alamat
                    mcustomer.Email = customer.Email
                    mcustomer.Nama_Customer = customer.Nama_Customer
                    mcustomer.Telephone = customer.Telephone
                    entity.SaveChanges()
                End If
            End Using
        End Sub

        Private Shared Sub ValidasiSupplier(ByVal mcustomer As Customer)
            If String.IsNullOrEmpty(mcustomer.Kode_Customer) Then
                Throw New Exception("Kode Customer Harus Diisi")
            End If
            If String.IsNullOrEmpty(mcustomer.Nama_Customer) Then
                Throw New Exception("Nama Customer Harus Diisi")
            End If
        End Sub

        Public Sub InsertCustomer(ByVal customer As Customer)
            Using entity As New InventoryArcomaBascoEntities2()
                ValidasiSupplier(customer)
                Dim msupplier = (From table In entity.Customer Where table.Kode_Customer = customer.Kode_Customer Select table).ToList().FirstOrDefault()
                If msupplier Is Nothing Then
                    entity.AddToCustomer(customer)
                    entity.SaveChanges()
                Else
                    Throw New Exception("Update failed, Data customer dengan kode " + customer.Kode_Customer + " tidak terdapat di dalam database")
                End If
            End Using
        End Sub

        Public Function GetCustomerForCombo()
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From table In entity.Customer Order By table.Kode_Customer Ascending
                Return query.Select(Function(a) New With {.CustomerKodeName = a.Kode_Customer & " - " & a.Nama_Customer, a.Kode_Customer}).ToList()
            End Using
        End Function
    End Class
End Namespace