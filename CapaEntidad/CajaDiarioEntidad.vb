Public Class CajaDiarioEntidad


    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _MOVIMIENTO As String
    Public Property MOVIMIENTO() As String
        Get
            Return _MOVIMIENTO
        End Get
        Set(ByVal value As String)
            _MOVIMIENTO = value
        End Set
    End Property

    Private _DESCRIPCION As String
    Public Property DESCRIPCION() As String
        Get
            Return _DESCRIPCION
        End Get
        Set(ByVal value As String)
            _DESCRIPCION = value
        End Set
    End Property

    Private _FECHA As Date
    Public Property FECHA() As Date
        Get
            Return _FECHA
        End Get
        Set(ByVal value As Date)
            _FECHA = value
        End Set
    End Property

    Private _TOTAL As Double
    Public Property TOTAL() As Double
        Get
            Return _TOTAL
        End Get
        Set(ByVal value As Double)
            _TOTAL = value
        End Set
    End Property

    Private _estado_c_c As String
    Public Property estado_c_c() As String
        Get
            Return _estado_c_c
        End Get
        Set(ByVal value As String)
            _estado_c_c = value
        End Set
    End Property


    Private _numero_caja As Integer
    Public Property numero_caja() As Integer
        Get
            Return _numero_caja
        End Get
        Set(ByVal value As Integer)
            _numero_caja = value
        End Set
    End Property


End Class
