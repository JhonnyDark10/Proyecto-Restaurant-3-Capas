Public Class ProveedorEntidad

    Private _dni_proveedores As Integer
    Public Property dni_proveedores() As Integer
        Get
            Return _dni_proveedores
        End Get
        Set(ByVal value As Integer)
            _dni_proveedores = value
        End Set
    End Property

    Private _CEDULA As String
    Public Property CEDULA() As String
        Get
            Return _CEDULA
        End Get
        Set(ByVal value As String)
            _CEDULA = value
        End Set
    End Property

    Private _NOMBRE As String
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property

    Private _APELLIDO_paterno As String
    Public Property APELLIDO_paterno() As String
        Get
            Return _APELLIDO_paterno
        End Get
        Set(ByVal value As String)
            _APELLIDO_paterno = value
        End Set
    End Property

    Private _APELLIDO_materno As String
    Public Property APELLIDO_materno() As String
        Get
            Return _APELLIDO_materno
        End Get
        Set(ByVal value As String)
            _APELLIDO_materno = value
        End Set
    End Property


    Private _direccion As String
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _telefono As String
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Private _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _estado_p As String
    Public Property estado_p() As String
        Get
            Return _estado_p
        End Get
        Set(ByVal value As String)
            _estado_p = value
        End Set
    End Property
End Class
