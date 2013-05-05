Public Class PengeluaranBarangModel
    Private id1 As Integer
    Private noDokumen1 As String
    Private tanggal1 As DateTime
    Private kodeBarang1 As String
    Private kodeCustomer1 As String
    Private jumlah1 As Integer
    Private Crud1 As Integer
    Private mHargaBarang As Integer
    Public Property Crud() As Integer
        Get
            Return Crud1
        End Get
        Set(ByVal value As Integer)
            Crud1 = value
        End Set
    End Property
    Public Property Id() As Integer
        Get
            Return id1
        End Get
        Set(ByVal value As Integer)
            id1 = value
        End Set
    End Property

    Public Property NoDokumen() As String
        Get
            Return noDokumen1
        End Get
        Set(ByVal value As String)
            noDokumen1 = value
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

    Public Property KodeCustomer() As String
        Get
            Return kodeCustomer1
        End Get
        Set(ByVal value As String)
            kodeCustomer1 = value
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

    Public Property HargaBarang() As Integer
        Get
            Return mHargaBarang
        End Get
        Set(ByVal value As Integer)
            mHargaBarang = value
        End Set
    End Property
End Class
