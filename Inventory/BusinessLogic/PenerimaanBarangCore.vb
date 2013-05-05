Namespace BusinessLogic
    Public Class PenerimaanBarangCore
        Public Function GetPenerimaanBarang()
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From table In entity.PenerimaanBarang Order By table.No_Invoice, table.Tanggal Descending
                For Each item In query
                    If item.BarangReference.IsLoaded = False Then
                        item.BarangReference.Load()
                    End If
                    If item.SupplierReference.IsLoaded = False Then
                        item.SupplierReference.Load()
                    End If
                Next
                Return query.Select(Function(a) New With {a.Barang.Kode_Barang, a.Barang.Nama_Barang, a.Barang.Harga_Barang, a.Jumlah, a.No_Invoice, a.Tanggal, a.Supplier.Kode_Supplier, a.Supplier.Nama_Supplier}).ToList()
            End Using
        End Function

        Public Function GetPenerimaanBarang(ByVal noinvoive As String) As IList(Of PenerimaanBarangModel)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From table In entity.PenerimaanBarang Where table.No_Invoice = noinvoive Order By table.Id
                For Each item In query
                    If item.BarangReference.IsLoaded = False Then
                        item.BarangReference.Load()
                    End If
                    If item.SupplierReference.IsLoaded = False Then
                        item.SupplierReference.Load()
                    End If
                Next
                Return query.ToList().Select(Function(a) New PenerimaanBarangModel() With { _
                    .KodeBarang = a.Barang.Kode_Barang, _
                    .Crud = 0, _
                    .Id = a.Id, _
                    .Jumlah = a.Jumlah, _
                    .HargaBarang = a.Barang.Harga_Barang _
                }).ToList()
            End Using
        End Function

        Private reportSource1 As List(Of LaporanPenerimaanBarangModel)

        Public Function GetPenerimaanBarangHarian(ByVal reportDate As DateTime) As List(Of LaporanPenerimaanBarangModel)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim startDate = New DateTime(reportDate.Year, reportDate.Month, reportDate.Day, 0, 0, 0)
                Dim endDate = New DateTime(reportDate.Year, reportDate.Month, reportDate.Day, 23, 59, 0)
                Dim query = From table In entity.PenerimaanBarang Where table.Tanggal >= startDate And table.Tanggal <= endDate Order By table.Tanggal Descending
                For Each item In query
                    If item.BarangReference.IsLoaded = False Then
                        item.BarangReference.Load()
                    End If
                    If item.SupplierReference.IsLoaded = False Then
                        item.SupplierReference.Load()
                    End If
                Next
                Dim b = query.Select(Function(a) New With {a.Barang.Kode_Barang, a.Barang.Nama_Barang, a.Barang.Harga_Barang, a.Jumlah, a.No_Invoice, a.Tanggal, a.Supplier.Kode_Supplier, a.Supplier.Nama_Supplier}).ToList()
                ReportSource = New List(Of LaporanPenerimaanBarangModel)
                For Each item In b
                    Dim d = New LaporanPenerimaanBarangModel()
                    d.Jumlah = item.Jumlah
                    d.KodeBarang = item.Kode_Barang
                    d.KodeSupplier = item.Kode_Supplier
                    d.NamaBarang = item.Nama_Barang
                    d.NamaSupplier = item.Nama_Supplier
                    d.NoTerima = item.No_Invoice
                    d.Tanggal = item.Tanggal
                    ReportSource.Add(d)
                Next
                Return ReportSource
            End Using
        End Function

        Public Function GetPenerimaanBarangBulanan(ByVal reportDate As DateTime) As List(Of LaporanPenerimaanBarangModel)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim startDate = New DateTime(reportDate.Year, reportDate.Month, 1, 0, 0, 0)
                Dim endDate = startDate.AddMonths(1)
                Dim query = From table In entity.PenerimaanBarang Where table.Tanggal >= startDate And table.Tanggal < endDate Order By table.Tanggal Descending
                For Each item In query
                    If item.BarangReference.IsLoaded = False Then
                        item.BarangReference.Load()
                    End If
                    If item.SupplierReference.IsLoaded = False Then
                        item.SupplierReference.Load()
                    End If
                Next
                Dim b = query.Select(Function(a) New With {a.Barang.Kode_Barang, a.Barang.Nama_Barang, a.Barang.Harga_Barang, a.Jumlah, a.No_Invoice, a.Tanggal, a.Supplier.Kode_Supplier, a.Supplier.Nama_Supplier}).ToList()
                ReportSource = New List(Of LaporanPenerimaanBarangModel)
                For Each item In b
                    Dim d = New LaporanPenerimaanBarangModel()
                    d.Jumlah = item.Jumlah
                    d.KodeBarang = item.Kode_Barang
                    d.KodeSupplier = item.Kode_Supplier
                    d.NamaBarang = item.Nama_Barang
                    d.NamaSupplier = item.Nama_Supplier
                    d.NoTerima = item.No_Invoice
                    d.Tanggal = item.Tanggal
                    ReportSource.Add(d)
                Next
                Return ReportSource
            End Using
        End Function

        Public Function GetPenerimaanBarangHarian(ByVal id As String) As PenerimaanBarang
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = (From table In entity.PenerimaanBarang Where table.No_Invoice = id)
                For Each item In query
                    item.BarangReference.Load()
                    item.SupplierReference.Load()
                Next
                Return query.ToList().FirstOrDefault
            End Using
        End Function

        Public Sub UpdatePenerimaanBarang(ByVal vListPenerimaanBarang As List(Of PenerimaanBarangModel))
            Using entity As New InventoryArcomaBascoEntities2()
                If vListPenerimaanBarang.Count = 0 Then
                    Throw New Exception("Penerimaan barang detail 0")
                End If
                Dim noInvoice = vListPenerimaanBarang(0).NoInvoice
                If String.IsNullOrEmpty(noInvoice) Then
                    Throw New Exception("No Invoice tidak boleh kosong")
                End If
                For Each penbarang In vListPenerimaanBarang
                    If penbarang.Jumlah <= 0 Then
                        Throw New Exception("Jumlah barang yang diterima tidak boleh lebih kecil atau sama dengan 0")
                    End If
                Next
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    For Each jPenerimaanBarangModel In vListPenerimaanBarang
                        ' Crud = 1 , state input dari row datatgridview 
                        If jPenerimaanBarangModel.Crud = 1 Then
                            ' ambil entity barang dari database, berdasarkan kode barang yg dinput di Form UI
                            Dim qbarang = (From table In entity.Barang Where table.Kode_Barang = jPenerimaanBarangModel.KodeBarang).FirstOrDefault
                            'ambil entity supplier dari databse, berdasarkan kode supplier yg di inpur di Form UI
                            Dim qsupplier = (From table In entity.Supplier Where table.Kode_Supplier = jPenerimaanBarangModel.KodeSupplier).FirstOrDefault
                            ' deklarasi entity yang akan dimasukan ke databse
                            Dim jPenerimaanBarang = New PenerimaanBarang
                            ' entity di set/ di isi attribute/property data yg berasal dari UI
                            jPenerimaanBarang.Barang = qbarang
                            jPenerimaanBarang.Jumlah = jPenerimaanBarangModel.Jumlah
                            jPenerimaanBarang.No_Invoice = jPenerimaanBarangModel.NoInvoice
                            jPenerimaanBarang.Supplier = qsupplier
                            jPenerimaanBarang.Tanggal = jPenerimaanBarangModel.Tanggal.Date
                            ' ....
                            ' Update data stock barang di database table Barang
                            ' logic stock yang ada di jumlahkan dgn jumlah barang masuk
                            qbarang.Stock_Barang += jPenerimaanBarangModel.Jumlah
                            'object dimasukan ke entity 
                            entity.AddToPenerimaanBarang(jPenerimaanBarang)
                            ' entity di save ke database
                            entity.SaveChanges()
                            ' Crud = 2 , state edit/update dari row datatgridview 
                        ElseIf jPenerimaanBarangModel.Crud = 2 And jPenerimaanBarangModel.Id > 0 Then
                            ' ambil entity penerimaan barang dari database, berdasarkan id yang udh dipilih di ui
                            Dim qpenerimaanBarang = (From table In entity.PenerimaanBarang.Include("Barang") Where table.Id = jPenerimaanBarangModel.Id).FirstOrDefault()
                            If qpenerimaanBarang Is Nothing Then
                                Throw New Exception("Data penerimaan barang " & jPenerimaanBarangModel.KodeBarang & " tidak ditemukan")
                            End If
                            ' ambil entity supplier berdasarkar kode supplier dari database, sesuai yang kita input di ui
                            Dim qsupplier = (From table In entity.Supplier Where table.Kode_Supplier = jPenerimaanBarangModel.KodeSupplier).FirstOrDefault
                            'entity di set sesuai yang di input
                            qpenerimaanBarang.No_Invoice = jPenerimaanBarangModel.NoInvoice
                            qpenerimaanBarang.Tanggal = jPenerimaanBarangModel.Tanggal
                            qpenerimaanBarang.Supplier = qsupplier
                            qpenerimaanBarang.Jumlah = jPenerimaanBarangModel.Jumlah
                            'logika nya penerimaan yang di input dikurang penerimaan yang ada di database
                            ' Jumlah penerimaan barang di UI dikurangi Jumlah penerimaan yang ada di database
                            Dim balance = jPenerimaanBarangModel.Jumlah - qpenerimaanBarang.Jumlah
                            ' balance/saldo mengurangi jumlah stock barang
                            qpenerimaanBarang.Barang.Stock_Barang += balance
                            entity.SaveChanges()
                            'Crud = 3 , state delete dari row datatgridview 
                        ElseIf jPenerimaanBarangModel.Crud = 3 And jPenerimaanBarangModel.Id > 0 Then
                            'ambil entity penerimaan barang dari database, berdasarkan id yang udh dipilih di ui
                            Dim qpenerimaanBarang = (From table In entity.PenerimaanBarang.Include("Barang") Where table.Id = jPenerimaanBarangModel.Id).FirstOrDefault()
                            'kalau penerimaan barang tidak ditemukan maka akan di akan muncul exception atau error
                            If qpenerimaanBarang Is Nothing Then
                                Throw New Exception("Data penerimaan barang " & jPenerimaanBarangModel.KodeBarang & " tidak ditemukan")
                            End If
                            'logika nya barang yang sudah di input akan mengurangi stok barang
                            qpenerimaanBarang.Barang.Stock_Barang -= jPenerimaanBarangModel.Jumlah
                            entity.DeleteObject(qpenerimaanBarang)
                            entity.SaveChanges()
                        End If
                    Next
                    transaction.Commit()
                    If entity.Connection.State <> ConnectionState.Closed Then
                        entity.Connection.Close()
                    End If
                End Using
            End Using
        End Sub

        Public Sub DeletePenerimaanBarang(ByVal vListPenerimaanBarang As List(Of PenerimaanBarangModel))
            Using entity As New InventoryArcomaBascoEntities2()
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    For Each jPenerimaanBarangModel In vListPenerimaanBarang

                        Dim qpenerimaanBarang = (From table In entity.PenerimaanBarang.Include("Barang") Where table.Id = jPenerimaanBarangModel.Id).FirstOrDefault()
                        If qpenerimaanBarang Is Nothing Then
                            Throw New Exception("Data penerimaan barang " & jPenerimaanBarangModel.KodeBarang & " tidak ditemukan")
                        End If
                        qpenerimaanBarang.Barang.Stock_Barang -= jPenerimaanBarangModel.Jumlah
                        entity.DeleteObject(qpenerimaanBarang)
                        entity.SaveChanges()
                    Next
                    transaction.Commit()
                    If entity.Connection.State <> ConnectionState.Closed Then
                        entity.Connection.Close()
                    End If
                End Using
            End Using
        End Sub

        Public Sub DeletePenerimaanBarang(ByVal noterima As String)
            Using entity As New InventoryArcomaBascoEntities2()
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    Dim query = From table In entity.PenerimaanBarang.Include("Barang") Where table.No_Invoice = noterima
                    For Each item In query
                        item.Barang.Stock_Barang -= item.Jumlah
                        entity.DeleteObject(item)
                        entity.SaveChanges()
                    Next
                    transaction.Commit()
                    If entity.Connection.State <> ConnectionState.Closed Then
                        entity.Connection.Close()
                    End If
                End Using
            End Using
        End Sub

        Public Property ReportSource() As List(Of LaporanPenerimaanBarangModel)
            Get
                Return reportSource1
            End Get
            Set(ByVal value As List(Of LaporanPenerimaanBarangModel))
                reportSource1 = value
            End Set
        End Property

        Public Sub InsertPenerimaanBarang(ByVal vListPenerimaanBarang As List(Of PenerimaanBarangModel))
            Using entity As New InventoryArcomaBascoEntities2()
                If vListPenerimaanBarang.Count = 0 Then
                    Throw New Exception("Penerimaan barang detail 0")
                End If
                Dim noInvoice = vListPenerimaanBarang(0).NoInvoice
                If String.IsNullOrEmpty(noInvoice) Then
                    Throw New Exception("No Invoice tidak boleh kosong")
                End If
                Dim query = (From table In entity.PenerimaanBarang Where table.No_Invoice = noInvoice).ToList()
                If query.Count > 0 Then
                    Throw New Exception("Duplikasi No Invoice " & query.FirstOrDefault().No_Invoice)
                End If
                For Each penbarang In vListPenerimaanBarang
                    If penbarang.Jumlah <= 0 Then
                        Throw New Exception("Jumlah barang yang diterima tidak boleh lebih kecil atau sama dengan 0")
                    End If
                Next
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    For Each jPenerimaanBarangModel In vListPenerimaanBarang
                        Dim qbarang = (From table In entity.Barang Where table.Kode_Barang = jPenerimaanBarangModel.KodeBarang).FirstOrDefault
                        Dim qsupplier = (From table In entity.Supplier Where table.Kode_Supplier = jPenerimaanBarangModel.KodeSupplier).FirstOrDefault
                        Dim jPenerimaanBarang = New PenerimaanBarang
                        jPenerimaanBarang.Barang = qbarang
                        jPenerimaanBarang.Jumlah = jPenerimaanBarangModel.Jumlah
                        jPenerimaanBarang.No_Invoice = jPenerimaanBarangModel.NoInvoice
                        jPenerimaanBarang.Supplier = qsupplier
                        jPenerimaanBarang.Tanggal = jPenerimaanBarangModel.Tanggal.Date
                        qbarang.Stock_Barang += jPenerimaanBarangModel.Jumlah
                        entity.AddToPenerimaanBarang(jPenerimaanBarang)
                        entity.SaveChanges()
                    Next
                    transaction.Commit()
                    If entity.Connection.State <> ConnectionState.Closed Then
                        entity.Connection.Close()
                    End If
                End Using
            End Using
        End Sub
    End Class
End Namespace