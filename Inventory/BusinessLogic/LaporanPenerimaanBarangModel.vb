Namespace BusinessLogic
    Public Class LaporanPenerimaanBarangModel
        Private noTerima1 As String

        Public Property NoTerima() As String
            Get
                Return noTerima1
            End Get
            Set(ByVal value As String)
                noTerima1 = value
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

        Public Property KodeSupplier() As String
            Get
                Return kodeSupplier1
            End Get
            Set(ByVal value As String)
                kodeSupplier1 = value
            End Set
        End Property

        Public Property NamaSupplier() As String
            Get
                Return namaSupplier1
            End Get
            Set(ByVal value As String)
                namaSupplier1 = value
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

        Public Property Jumlah() As Integer
            Get
                Return jumlah1
            End Get
            Set(ByVal value As Integer)
                jumlah1 = value
            End Set
        End Property

        Private tanggal1 As DateTime

        Private kodeSupplier1 As String

        Private namaSupplier1 As String

        Private kodeBarang1 As String

        Private namaBarang1 As String

        Private jumlah1 As Integer


    End Class
End Namespace