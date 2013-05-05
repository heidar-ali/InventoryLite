Namespace BusinessLogic
    Public Class LaporanCore
        Public Function GetLaporanHarian(ByVal tanggal As DateTime) As List(Of LaporanHarianModel)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim sbulan = tanggal.ToString("MMMM yyyy")
                Dim report As New List(Of LaporanHarianModel)
                Dim tquery = (From table In entity.PenerimaanBarang.Include("Barang") Where table.Tanggal = tanggal Order By table.Tanggal _
                                 Group table By tableGroup = New With {.KodeBarang = table.Barang.Kode_Barang, .Tanggal = table.Tanggal} _
                                  Into jumlah = Sum(table.Jumlah) _
                                  Select New With {.KKJ = tableGroup.KodeBarang, .Key = tableGroup.Tanggal, .RJumlah = jumlah}).ToList()
                Dim jquery = (From table In entity.PengeluaranBarang.Include("Barang") Where table.Tanggal = tanggal Order By table.Tanggal _
                                 Group table By tableGroup = New With {.KodeBarang = table.Barang.Kode_Barang, .Tanggal = table.Tanggal} _
                                  Into jumlah = Sum(table.Jumlah) _
                                  Select New With {.KKJ = tableGroup.KodeBarang, .Key = tableGroup.Tanggal, .RJumlah = jumlah}).ToList()
                Dim listbarang = (From table In entity.Barang).ToList()
                For Each item In tquery
                    Dim model As New LaporanHarianModel
                    Dim mbarang = listbarang.Find(Function(y) y.Kode_Barang = item.KKJ)
                    model.Tanggal = item.Key
                    model.KodeBarang = item.KKJ
                    model.BarangMasuk = item.RJumlah
                    model.NamaBarang = mbarang.Nama_Barang
                    model.Stock = mbarang.Stock_Barang
                    model.Bulan = sbulan
                    model.HargaBarang = mbarang.Harga_Barang
                    report.Add(model)
                Next

                For Each item In jquery
                    Dim mbarang = listbarang.Find(Function(y) y.Kode_Barang = item.KKJ)
                    Dim models = report.Where(Function(x) x.Tanggal = item.Key And x.KodeBarang = item.KKJ).Select(Function(z) z).ToList()
                    For Each harianModel In models
                        If harianModel Is Nothing Then
                            Dim laporanHarianModel As New LaporanHarianModel

                            laporanHarianModel.Tanggal = item.Key
                            laporanHarianModel.KodeBarang = item.KKJ
                            laporanHarianModel.NamaBarang = mbarang.Nama_Barang
                            laporanHarianModel.Stock = mbarang.Stock_Barang
                            laporanHarianModel.BarangKeluar = item.RJumlah
                            laporanHarianModel.Bulan = sbulan
                            laporanHarianModel.HargaBarang = mbarang.Harga_Barang
                            report.Add(laporanHarianModel)
                        Else
                            harianModel.BarangKeluar += item.RJumlah
                        End If
                    Next

                Next
                LaporanHarian = report.OrderBy(Function(z) z.Tanggal).ToList()
                Debug.Print(report.Count.ToString)
                Return LaporanHarian
            End Using
        End Function

        Public Function GetLaporanBulan(ByVal tanggal As DateTime) As List(Of LaporanHarianModel)
            Using entity As New InventoryArcomaBascoEntities2()
                Dim bulan = tanggal.Month
                Dim sbulan = tanggal.ToString("MMMM yyyy")
                Dim report As New List(Of LaporanHarianModel)
                Dim tquery = (From table In entity.PenerimaanBarang.Include("Barang") Where table.Tanggal.Month = bulan Order By table.Tanggal _
                                 Group table By tableGroup = New With {.KodeBarang = table.Barang.Kode_Barang} _
                                  Into jumlah = Sum(table.Jumlah) _
                                  Select New With {.KKJ = tableGroup.KodeBarang, .RJumlah = jumlah}).ToList()
                Dim jquery = (From table In entity.PengeluaranBarang.Include("Barang") Where table.Tanggal.Month = bulan Order By table.Tanggal _
                                 Group table By tableGroup = New With {.KodeBarang = table.Barang.Kode_Barang} _
                                  Into jumlah = Sum(table.Jumlah) _
                                  Select New With {.KKJ = tableGroup.KodeBarang, .RJumlah = jumlah}).ToList()
                Dim listbarang = (From table In entity.Barang).ToList()
                For Each item In tquery
                    Dim mbarang = listbarang.Find(Function(y) y.Kode_Barang = item.KKJ)
                    Dim model As New LaporanHarianModel
                    model.KodeBarang = item.KKJ
                    model.Stock = mbarang.Stock_Barang
                    model.BarangMasuk = item.RJumlah
                    model.NamaBarang = mbarang.Nama_Barang
                    model.Bulan = sbulan
                    model.HargaBarang = mbarang.Harga_Barang
                    report.Add(model)
                Next
                For Each item In jquery
                    Dim mbarang = listbarang.Find(Function(y) y.Kode_Barang = item.KKJ)
                    Dim model = report.Where(Function(x) x.KodeBarang = item.KKJ).Select(Function(z) z).FirstOrDefault()
                    If model Is Nothing Then
                        Dim laporanHarianModel As New LaporanHarianModel
                        laporanHarianModel.KodeBarang = item.KKJ
                        laporanHarianModel.BarangKeluar = item.RJumlah
                        laporanHarianModel.NamaBarang = mbarang.Nama_Barang
                        laporanHarianModel.Bulan = sbulan
                        laporanHarianModel.Stock = mbarang.Stock_Barang
                        laporanHarianModel.HargaBarang = mbarang.Harga_Barang
                        report.Add(laporanHarianModel)
                    Else
                        model.BarangKeluar += item.RJumlah
                    End If
                Next
                LaporanHarian = report.OrderBy(Function(z) z.KodeBarang).ToList()
                Debug.Print(report.Count.ToString)
                Return report
            End Using
        End Function

        Private laporanHarian1 As List(Of LaporanHarianModel)

        Public Property LaporanHarian() As List(Of LaporanHarianModel)
            Get
                Return laporanHarian1
            End Get
            Set(ByVal value As List(Of LaporanHarianModel))
                laporanHarian1 = value
            End Set
        End Property
    End Class
End Namespace