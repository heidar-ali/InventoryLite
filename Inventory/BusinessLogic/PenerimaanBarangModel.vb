Namespace BusinessLogic
    Public Class PenerimaanBarangModel
        Private jumlah1 As Integer
        Private kodeBarang1 As String
        Private tanggal1 As DateTime
        Private kodeSupplier1 As String
        Private noInvoice1 As String
        Private id1 As Integer
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

        Public Property Jumlah() As Integer
            Get
                Return jumlah1
            End Get
            Set(ByVal value As Integer)
                jumlah1 = value
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

        Public Property NoInvoice() As String
            Get
                Return noInvoice1
            End Get
            Set(ByVal value As String)
                noInvoice1 = value
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