Public Class CabeceraFacturaEntidad

    Private _id_factura As Integer
    Public Property id_factura() As Integer
        Get
            Return _id_factura
        End Get
        Set(ByVal value As Integer)
            _id_factura = value
        End Set
    End Property

    Private _FK_CLIENTE As Integer
    Public Property FK_CLIENTE() As Integer
        Get
            Return _FK_CLIENTE
        End Get
        Set(ByVal value As Integer)
            _FK_CLIENTE = value
        End Set
    End Property

    Private _FK_TIPO_PAGO As Integer
    Public Property FK_TIPO_PAGO() As Integer
        Get
            Return _FK_TIPO_PAGO
        End Get
        Set(ByVal value As Integer)
            _FK_TIPO_PAGO = value
        End Set
    End Property

    Private _TIPO_ORDEN As String
    Public Property TIPO_ORDEN() As String
        Get
            Return _TIPO_ORDEN
        End Get
        Set(ByVal value As String)
            _TIPO_ORDEN = value
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

    Private _DESCUENTO As Double
    Public Property DESCUENTO() As Double
        Get
            Return _DESCUENTO
        End Get
        Set(ByVal value As Double)
            _DESCUENTO = value
        End Set
    End Property

    Private _IVA As Double
    Public Property IVA() As Double
        Get
            Return _IVA
        End Get
        Set(ByVal value As Double)
            _IVA = value
        End Set
    End Property

    Private _TOTAL_PAGO As Double
    Public Property TOTAL_PAGO() As Double
        Get
            Return _TOTAL_PAGO
        End Get
        Set(ByVal value As Double)
            _TOTAL_PAGO = value
        End Set
    End Property

    Private _FECHA_FACTURA As Date
    Public Property FECHA_FACTURA() As Date
        Get
            Return _FECHA_FACTURA
        End Get
        Set(ByVal value As Date)
            _FECHA_FACTURA = value
        End Set
    End Property

    Private _HORA_PEDIDO As Date
    Public Property HORA_PEDIDO() As Date
        Get
            Return _HORA_PEDIDO
        End Get
        Set(ByVal value As Date)
            _HORA_PEDIDO = value
        End Set
    End Property


    Private _TIEMPO_ENTREGA As String
    Public Property TIEMPO_ENTREGA() As String
        Get
            Return _TIEMPO_ENTREGA
        End Get
        Set(ByVal value As String)
            _TIEMPO_ENTREGA = value
        End Set
    End Property


    Private _ID_EMPLEADO As Integer
    Public Property ID_EMPLEADO() As Integer
        Get
            Return _ID_EMPLEADO
        End Get
        Set(ByVal value As Integer)
            _ID_EMPLEADO = value
        End Set
    End Property

    Private _NOMBRE_PC As String
    Public Property NOMBRE_PC() As String
        Get
            Return _NOMBRE_PC
        End Get
        Set(ByVal value As String)
            _NOMBRE_PC = value
        End Set
    End Property

    Private _NOMRE_USU As String
    Public Property NOMRE_USU() As String
        Get
            Return _NOMRE_USU
        End Get
        Set(ByVal value As String)
            _NOMRE_USU = value
        End Set
    End Property

    Private _ESTADO_FACT As String
    Public Property ESTADO_FACT() As String
        Get
            Return _ESTADO_FACT
        End Get
        Set(ByVal value As String)
            _ESTADO_FACT = value
        End Set
    End Property



    Private _NUMERO_MESA As Integer
    Public Property NUMERO_MESA() As Integer
        Get
            Return _NUMERO_MESA
        End Get
        Set(ByVal value As Integer)
            _NUMERO_MESA = value
        End Set
    End Property



End Class
