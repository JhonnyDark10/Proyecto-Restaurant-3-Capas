Public Class DetalleFacturaEntidad

    Private _FK_ID_FACTURA As Integer
    Public Property FK_ID_FACTURA() As Integer
        Get
            Return _FK_ID_FACTURA
        End Get
        Set(ByVal value As Integer)
            _FK_ID_FACTURA = value
        End Set
    End Property

    Private _FK_COD_PLATOS As Integer
    Public Property FK_COD_PLATOS() As Integer
        Get
            Return _FK_COD_PLATOS
        End Get
        Set(ByVal value As Integer)
            _FK_COD_PLATOS = value
        End Set
    End Property

    Private _SUBTOTAL As Double
    Public Property SUBTOTAL() As Double
        Get
            Return _SUBTOTAL
        End Get
        Set(ByVal value As Double)
            _SUBTOTAL = value
        End Set
    End Property

    Private _CANTIDAD_P As Integer
    Public Property CANTIDAD_P() As Integer
        Get
            Return _CANTIDAD_P
        End Get
        Set(ByVal value As Integer)
            _CANTIDAD_P = value
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

 
    Private _ESTADO_D_O As String
    Public Property ESTADO_D_O() As String
        Get
            Return _ESTADO_D_O
        End Get
        Set(ByVal value As String)
            _ESTADO_D_O = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _accion_p As Integer
    Public Property accion_p() As Integer
        Get
            Return _accion_p
        End Get
        Set(ByVal value As Integer)
            _accion_p = value
        End Set
    End Property

End Class
