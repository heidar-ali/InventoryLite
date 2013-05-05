Namespace BusinessLogic
    Public Class LaporanHarianModel
        Private tanggal1 As DateTime
        Private kodeBarang1 As String
        Private namaBarang1 As String
        Private barangMasuk1 As Integer
        Private barangKeluar1 As Integer
        Private stock1 As Integer
        Private bulan1 As String
        Private mHargaBarang As Integer
        Public Property Bulan() As String
            Get
                Return bulan1
            End Get
            Set(ByVal value As String)
                bulan1 = value
            End Set
        End Property

        Public Property Tanggal() As Date
            Get
                Return tanggal1
            End Get
            Set(ByVal value As Date)
                tanggal1 = value
            End Set
        End Property

        Public Property KodeBarang() As String
            Get
                Return kodeBarang1
            End Get
            Set(ByVal value As String)
                kodeBarang1 = value
            End Set
        End Property

        Public Property NamaBarang() As String
            Get
                Return namaBarang1
            End Get
            Set(ByVal value As String)
                namaBarang1 = value
            End Set
        End Property

        Public Property BarangMasuk() As Integer
            Get
                Return barangMasuk1
            End Get
            Set(ByVal value As Integer)
                barangMasuk1 = value
            End Set
        End Property

        Public Property BarangKeluar() As Integer
            Get
                Return barangKeluar1
            End Get
            Set(ByVal value As Integer)
                barangKeluar1 = value
            End Set
        End Property

        Public Property Stock() As Integer
            Get
                Return stock1
            End Get
            Set(ByVal value As Integer)
                stock1 = value
            End Set
        End Property

        Public Property HargaBarang() As Integer
            Get
                Return mHargaBarang
            End Get
            Set(ByVal value As Integer)
                mHargaBarang = value
            End Set
        End Property
    End Class
End Namespace