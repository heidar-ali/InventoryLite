Namespace BusinessLogic
    Public Class LaporanPengeluaranBarangModel
        Private Kode_Barang As String
        Private Nama_Barang As String
        Private jumlah_Barang As Integer
        Private No_Keluar As Integer
        Private tanggal1 As DateTime
        Private Kode_Customer As String
        Private Nama_Customer As String

        Public Property KodeBarang() As String
            Get
                Return Kode_Barang
            End Get
            Set(ByVal value As String)
                Kode_Barang = value
            End Set
        End Property

        Public Property NamaBarang() As String
            Get
                Return Nama_Barang
            End Get
            Set(ByVal value As String)
                Nama_Barang = value
            End Set
        End Property

        Public Property JumlahBarang() As Integer
            Get
                Return jumlah_Barang
            End Get
            Set(ByVal value As Integer)
                jumlah_Barang = value
            End Set
        End Property

        Public Property NoKeluar() As Integer
            Get
                Return No_Keluar
            End Get
            Set(ByVal value As Integer)
                No_Keluar = value
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

        Public Property KodeCustomer() As String
            Get
                Return Kode_Customer
            End Get
            Set(ByVal value As String)
                Kode_Customer = value
            End Set
        End Property

        Public Property NamaCustomer() As String
            Get
                Return Nama_Customer
            End Get
            Set(ByVal value As String)
                Nama_Customer = value
            End Set
        End Property
    End Class
End Namespace