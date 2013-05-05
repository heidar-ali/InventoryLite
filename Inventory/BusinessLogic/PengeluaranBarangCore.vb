Namespace BusinessLogic
    Public Class PengeluaranBarangCore
        Public Function GetPengeluaranBarangs()
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From table In entity.PengeluaranBarang Order By table.No_Dokumen, table.Tanggal Descending
                For Each item In query
                    If item.BarangReference.IsLoaded = False Then
                        item.BarangReference.Load()
                    End If
                    If item.CustomerReference.IsLoaded = False Then
                        item.CustomerReference.Load()
                    End If
                Next
                Return query.Select(Function(a) New With {a.Barang.Kode_Barang, a.Barang.Nama_Barang, a.Barang.Harga_Barang, a.Jumlah, a.No_Dokumen, a.Tanggal, a.Customer.Kode_Customer, a.Customer.Nama_Customer}).ToList()
            End Using
        End Function

        Public Function GetPengeluaranBarang(ByVal id As String) As PengeluaranBarang
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = (From table In entity.PengeluaranBarang Where table.No_Dokumen = id)
                For Each item In query
                    item.BarangReference.Load()
                    item.CustomerReference.Load()
                Next
                Return query.ToList().FirstOrDefault
            End Using
        End Function

        Public Function GetPengeluaranBarangs(ByVal noDokumen As String) As IList(Of PengeluaranBarangModel)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = From table In entity.PengeluaranBarang Where table.No_Dokumen = noDokumen
                For Each item In query
                    If item.BarangReference.IsLoaded = False Then
                        item.BarangReference.Load()
                    End If
                    If item.CustomerReference.IsLoaded = False Then
                        item.CustomerReference.Load()
                    End If
                Next
                Return query.ToList().Select(Function(a) New PengeluaranBarangModel() With { _
                    .KodeBarang = a.Barang.Kode_Barang, _
                    .Crud = 0, _
                    .Id = a.Id, _
                    .Jumlah = a.Jumlah, _
                    .HargaBarang = a.Barang.Harga_Barang _
                }).ToList()
            End Using
        End Function

        Private reportSource1 As List(Of LaporanPengeluaranBarangModel)
        Public Property ListLaporanPengeluaranBarangModel() As List(Of LaporanPengeluaranBarangModel)
            Get
                Return reportSource1
            End Get
            Set(ByVal value As List(Of LaporanPengeluaranBarangModel))
                reportSource1 = value
            End Set
        End Property

        Public Function GetPengeluaranBarangHarian(ByVal reportDate As DateTime) As List(Of LaporanPengeluaranBarangModel)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim startDate = New DateTime(reportDate.Year, reportDate.Month, reportDate.Day, 0, 0, 0)
                Dim endDate = New DateTime(reportDate.Year, reportDate.Month, reportDate.Day, 23, 59, 0)
                Dim query = From table In entity.PengeluaranBarang Where table.Tanggal >= startDate And table.Tanggal <= endDate Order By table.Tanggal Descending
                For Each item In query
                    If item.BarangReference.IsLoaded = False Then
                        item.BarangReference.Load()
                    End If
                    If item.CustomerReference.IsLoaded = False Then
                        item.CustomerReference.Load()
                    End If
                Next
                Dim b = query.Select(Function(a) New With {a.Barang.Kode_Barang, a.Barang.Nama_Barang, a.Barang.Harga_Barang, a.Jumlah, a.No_Dokumen, a.Tanggal, a.Customer.Kode_Customer, a.Customer.Nama_Customer}).ToList()
                Dim result = New List(Of LaporanPengeluaranBarangModel)
                For Each c In b
                    Dim d = New LaporanPengeluaranBarangModel
                    d.JumlahBarang = c.Jumlah
                    d.KodeBarang = c.Kode_Barang
                    d.KodeCustomer = c.Kode_Customer
                    d.NamaBarang = c.Nama_Barang
                    d.NamaCustomer = c.Nama_Customer
                    d.NoKeluar = c.No_Dokumen
                    d.Tanggal = c.Tanggal
                    result.Add(d)
                Next
                Return result
            End Using
        End Function

        Public Function GetPengeluaranBarangBulanan(ByVal reportDate As DateTime) As List(Of LaporanPengeluaranBarangModel)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim startDate = New DateTime(reportDate.Year, reportDate.Month, reportDate.Day, 0, 0, 0)
                Dim endDate = startDate.AddMonths(1)
                Dim query = From table In entity.PengeluaranBarang Where table.Tanggal >= startDate And table.Tanggal < endDate Order By table.Tanggal Descending
                For Each item In query
                    If item.BarangReference.IsLoaded = False Then
                        item.BarangReference.Load()
                    End If
                    If item.CustomerReference.IsLoaded = False Then
                        item.CustomerReference.Load()
                    End If
                Next
                Dim b = query.Select(Function(a) New With {a.Barang.Kode_Barang, a.Barang.Nama_Barang, a.Barang.Harga_Barang, a.Jumlah, a.No_Dokumen, a.Tanggal, a.Customer.Kode_Customer, a.Customer.Nama_Customer}).ToList()
                Dim result = New List(Of LaporanPengeluaranBarangModel)
                For Each c In b
                    Dim d = New LaporanPengeluaranBarangModel
                    d.JumlahBarang = c.Jumlah
                    d.KodeBarang = c.Kode_Barang
                    d.KodeCustomer = c.Kode_Customer
                    d.NamaBarang = c.Nama_Barang
                    d.NamaCustomer = c.Nama_Customer
                    d.NoKeluar = c.No_Dokumen
                    d.Tanggal = c.Tanggal
                    result.Add(d)
                Next
                Return result
            End Using
        End Function

        Public Function GetPengeluaranBarangHarian(ByVal id As Integer) As PengeluaranBarang
            Using entity As New InventoryArcomaBascoEntities2()
                Dim query = (From table In entity.PengeluaranBarang Where table.No_Dokumen = id)
                For Each item In query
                    item.BarangReference.Load()
                    item.CustomerReference.Load()
                Next
                Return query.ToList().FirstOrDefault
            End Using
        End Function

        Public Sub InsertPengeluaranBarang(ByVal pbarang As PengeluaranBarang, ByVal kodeBarang As String, ByVal kodecustomer As String)
            Using entity As New InventoryArcomaBascoEntities2()
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    If pbarang.Jumlah <= 0 Then
                        Throw New Exception("Jumlah barang yang keluar tidak boleh lebih kecil atau sama dengan 0")
                    End If

                    Dim barang = (From table In entity.Barang Where table.Kode_Barang = kodeBarang).ToList().FirstOrDefault()
                    Dim customer = (From table In entity.Customer Where table.Kode_Customer = kodecustomer).ToList().FirstOrDefault()
                    Dim query = (From table In entity.PengeluaranBarang Order By table.No_Dokumen Descending Select table Take 1).FirstOrDefault()
                    If query Is Nothing Then
                        pbarang.No_Dokumen = 1
                    Else
                        pbarang.No_Dokumen = query.No_Dokumen + 1
                    End If
                    entity.AddToPengeluaranBarang(pbarang)
                    pbarang.Barang = barang
                    pbarang.Customer = customer
                    barang.Stock_Barang -= pbarang.Jumlah
                    entity.SaveChanges()
                    transaction.Commit()
                    If entity.Connection.State <> ConnectionState.Closed Then
                        entity.Connection.Close()
                    End If
                End Using
            End Using
        End Sub

        Public Sub InsertPengeluaranBarang(ByVal pengeluaranBarangModels As List(Of PengeluaranBarangModel))

            Using entity As New InventoryArcomaBascoEntities2()
                If pengeluaranBarangModels.Count = 0 Then
                    Throw New Exception("Pengeluaran barang detail 0")
                End If
                Dim noInvoice As String = pengeluaranBarangModels(0).NoDokumen
                If String.IsNullOrEmpty(noInvoice) Then
                    Throw New Exception("No Dokumen tidak boleh kosong")
                End If
                Dim query = (From table In entity.PengeluaranBarang Where table.No_Dokumen = noInvoice).ToList()
                If query.Count > 0 Then
                    Throw New Exception("Duplikasi No Invoice " & query.FirstOrDefault().No_Dokumen)
                End If
                For Each pengeluaranBarangModel In pengeluaranBarangModels
                    If pengeluaranBarangModel.Jumlah <= 0 Then
                        Throw New Exception("Jumlah barang yang diterima tidak boleh lebih kecil atau sama dengan 0")
                    End If
                Next
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    For Each vPengeluaranBarangModel In pengeluaranBarangModels
                        Dim qbarang = (From table In entity.Barang Where table.Kode_Barang = vPengeluaranBarangModel.KodeBarang).FirstOrDefault
                        Dim qsupplier = (From table In entity.Customer Where table.Kode_Customer = vPengeluaranBarangModel.KodeCustomer).FirstOrDefault
                        Dim jPenerimaanBarang = New PengeluaranBarang
                        jPenerimaanBarang.Barang = qbarang
                        jPenerimaanBarang.Jumlah = vPengeluaranBarangModel.Jumlah
                        jPenerimaanBarang.No_Dokumen = vPengeluaranBarangModel.NoDokumen
                        jPenerimaanBarang.Customer = qsupplier
                        jPenerimaanBarang.Tanggal = vPengeluaranBarangModel.Tanggal.Date
                        qbarang.Stock_Barang -= vPengeluaranBarangModel.Jumlah
                        entity.AddToPengeluaranBarang(jPenerimaanBarang)
                        entity.SaveChanges()
                    Next
                    transaction.Commit()
                    If entity.Connection.State <> ConnectionState.Closed Then
                        entity.Connection.Close()
                    End If
                End Using
            End Using
        End Sub

        Public Sub UpdatePengeluaranBarang(ByVal vListPengeluaranBarang As List(Of PengeluaranBarangModel))
            Using entity As New InventoryArcomaBascoEntities2()
                If vListPengeluaranBarang.Count = 0 Then
                    Throw New Exception("Pengeluaran barang detail 0")
                End If
                Dim noInvoice = vListPengeluaranBarang(0).NoDokumen
                If String.IsNullOrEmpty(noInvoice) Then
                    Throw New Exception("No Dokumen tidak boleh kosong")
                End If
                For Each penbarang In vListPengeluaranBarang
                    If penbarang.Jumlah <= 0 Then
                        Throw New Exception("Jumlah barang yang dikeluarkan tidak boleh lebih kecil atau sama dengan 0")
                    End If
                Next
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    For Each jPengeluaranBarang In vListPengeluaranBarang
                        If jPengeluaranBarang.Crud = 1 Then
                            Dim qbarang = (From table In entity.Barang Where table.Kode_Barang = jPengeluaranBarang.KodeBarang).FirstOrDefault
                            Dim qsupplier = (From table In entity.Customer Where table.Kode_Customer = jPengeluaranBarang.KodeCustomer).FirstOrDefault
                            Dim nPengeluaranBarang = New PengeluaranBarang
                            nPengeluaranBarang.Barang = qbarang
                            nPengeluaranBarang.Jumlah = jPengeluaranBarang.Jumlah
                            nPengeluaranBarang.No_Dokumen = jPengeluaranBarang.NoDokumen
                            nPengeluaranBarang.Customer = qsupplier
                            nPengeluaranBarang.Tanggal = jPengeluaranBarang.Tanggal.Date
                            qbarang.Stock_Barang -= jPengeluaranBarang.Jumlah
                            entity.AddToPengeluaranBarang(nPengeluaranBarang)
                            entity.SaveChanges()
                        ElseIf jPengeluaranBarang.Crud = 2 And jPengeluaranBarang.Id > 0 Then
                            Dim qPengeluaranBarang = (From table In entity.PengeluaranBarang.Include("Barang") Where table.Id = jPengeluaranBarang.Id).FirstOrDefault()
                            If qPengeluaranBarang Is Nothing Then
                                Throw New Exception("Data pengeluaran barang " & jPengeluaranBarang.KodeBarang & " tidak ditemukan")
                            End If
                            Dim qsupplier = (From table In entity.Customer Where table.Kode_Customer = jPengeluaranBarang.KodeCustomer).FirstOrDefault
                            'Dim balance = jPengeluaranBarang.Jumlah - qPengeluaranBarang.Jumlah
                            qPengeluaranBarang.Barang.Stock_Barang = qPengeluaranBarang.Barang.Stock_Barang + qPengeluaranBarang.Jumlah - jPengeluaranBarang.Jumlah
                            qPengeluaranBarang.No_Dokumen = jPengeluaranBarang.NoDokumen
                            qPengeluaranBarang.Tanggal = jPengeluaranBarang.Tanggal
                            qPengeluaranBarang.Customer = qsupplier
                            qPengeluaranBarang.Jumlah = jPengeluaranBarang.Jumlah
                            entity.SaveChanges()
                        ElseIf jPengeluaranBarang.Crud = 3 And jPengeluaranBarang.Id > 0 Then
                            Dim qPengeluaranBarang = (From table In entity.PengeluaranBarang.Include("Barang") Where table.Id = jPengeluaranBarang.Id).FirstOrDefault()
                            If qPengeluaranBarang Is Nothing Then
                                Throw New Exception("Data pengeluaran barang " & jPengeluaranBarang.KodeBarang & " tidak ditemukan")
                            End If
                            qPengeluaranBarang.Barang.Stock_Barang = qPengeluaranBarang.Barang.Stock_Barang + qPengeluaranBarang.Jumlah
                            entity.DeleteObject(qPengeluaranBarang)
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

        Public Sub DeletePengeluaranBarang(ByVal vListPengeluaranBarang As List(Of PengeluaranBarangModel))
            Using entity As New InventoryArcomaBascoEntities2()
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    For Each jPengeluaranBarang In vListPengeluaranBarang
                        Dim qPengeluaranBarang = (From table In entity.PengeluaranBarang.Include("Barang") Where table.Id = jPengeluaranBarang.Id).FirstOrDefault()
                        If qPengeluaranBarang Is Nothing Then
                            Throw New Exception("Data pengeluaran barang " & jPengeluaranBarang.KodeBarang & " tidak ditemukan")
                        End If
                        qPengeluaranBarang.Barang.Stock_Barang = qPengeluaranBarang.Barang.Stock_Barang + qPengeluaranBarang.Jumlah
                        entity.DeleteObject(qPengeluaranBarang)
                        entity.SaveChanges()
                    Next
                    transaction.Commit()
                    If entity.Connection.State <> ConnectionState.Closed Then
                        entity.Connection.Close()
                    End If
                End Using
            End Using
        End Sub

        Public Sub DeletePengeluaranBarang(ByVal noinvoive As String)
            Using entity As New InventoryArcomaBascoEntities2()
                If entity.Connection.State <> ConnectionState.Open Then
                    entity.Connection.Open()
                End If
                Using transaction = entity.Connection.BeginTransaction
                    Dim query = From table In entity.PengeluaranBarang.Include("Barang") Where table.No_Dokumen = noinvoive
                    For Each item In query
                        item.Barang.Stock_Barang += item.Jumlah
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

    End Class
End Namespace