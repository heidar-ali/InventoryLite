

Namespace BusinessLogic

    Public Class BarangCore
        Private ex As Exception

        Public Function GetBarang() As List(Of Barang)
            'deklarasi entiti framework yang digunakan, using keyword auto dispose memory
            Using entity As New InventoryArcomaBascoEntities2()
                'query entity barang yang diurutkan berdasarkan kode barang
                Dim query = From barang In entity.Barang Order By barang.Kode_Barang
                'query di ubah menjadi list barang dan menjadi nilai balik untuk fungsi getbarang
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetBarang(ByVal kodeBarang As String) As Barang
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From barang In entity.Barang Where barang.Kode_Barang = kodeBarang
                Dim result = (query.ToList().FirstOrDefault())
                If result Is Nothing Then
                    Throw New Exception("Data barang dengan kode " & kodeBarang & " tidak ditemukan")
                End If
                Return result
            End Using
        End Function

        Public Function GetBarang(ByVal asc As Boolean, ByVal sort As String) As IEnumerable(Of Barang)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From barang In entity.Barang Order By barang.Kode_Barang
                If Not asc Then
                    Return query.OrderByDescending(Function(a) sort).ToList()
                Else
                    Return query.OrderBy(Function(a) sort).ToList()
                End If
            End Using
        End Function

        Public Sub InsertBarang(ByVal barangModel As Barang)
            Using entity As New InventoryArcomaBascoEntities2()
                ValidasiBarang(barangModel)
                Dim mBarang = (From barang In entity.Barang Where barang.Kode_Barang = barangModel.Kode_Barang Select barang).ToList().FirstOrDefault()
                If mBarang Is Nothing Then
                    entity.AddToBarang(barangModel)
                    entity.SaveChanges()
                Else
                    Throw New Exception("Kode Barang " + barangModel.Kode_Barang + " sudah terdapat di database")
                End If
            End Using
        End Sub

        Public Sub UpdateBarang(ByVal barangModel As Barang)
            Using entity As New InventoryArcomaBascoEntities2()
                ValidasiBarang(barangModel)
                Dim mBarang = (From barang In entity.Barang Where barang.Kode_Barang = barangModel.Kode_Barang Select barang).ToList().FirstOrDefault()
                If mBarang Is Nothing Then
                    Throw New Exception("Update failed, Data barang dengan kode " + barangModel.Kode_Barang + " tidak terdapat di dalam database")
                Else
                    mBarang.Harga_Barang = barangModel.Harga_Barang
                    mBarang.Nama_Barang = barangModel.Nama_Barang
                    mBarang.Stock_Barang = barangModel.Stock_Barang
                    entity.SaveChanges()
                End If
            End Using
        End Sub

        Private Sub ValidasiBarang(ByVal barangModel As Barang)

            If String.IsNullOrEmpty(barangModel.Harga_Barang) Then
                Throw New Exception("Harga Barang Harus Diisi")
            End If
            If String.IsNullOrEmpty(barangModel.Kode_Barang) Then
                Throw New Exception("Kode Barang Harus Diisi")
            End If
            If String.IsNullOrEmpty(barangModel.Nama_Barang) Then
                Throw New Exception("Nama Barang Harus Diisi")
            End If
            If String.IsNullOrEmpty(barangModel.Stock_Barang) Then
                Throw New Exception("Stock Barang Harus Diisi")
            End If
        End Sub

        Public Sub DeleteBarang(ByVal text As String)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim mBarang = (From barang In entity.Barang Where barang.Kode_Barang = text Select barang).ToList().FirstOrDefault()
                If mBarang Is Nothing Then
                    Throw New Exception("Delete failed, Data barang dengan kode " + text + " tidak terdapat di dalam database")
                Else
                    entity.DeleteObject(mBarang)
                    entity.SaveChanges()
                End If
            End Using
        End Sub

        Public Function GetBarangForCombo()
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From table In entity.Barang Order By table.Kode_Barang Ascending
                Return query.Select(Function(a) New With {.BarangKodeName = a.Kode_Barang & " - " & a.Nama_Barang, a.Kode_Barang}).ToList()
            End Using
        End Function

        Private reportSource1 As List(Of Barang)
        Public Property ListBarangReport() As List(Of Barang)
            Get
                Return reportSource1
            End Get
            Set(ByVal value As List(Of Barang))
                reportSource1 = value
            End Set
        End Property

    End Class
End Namespace