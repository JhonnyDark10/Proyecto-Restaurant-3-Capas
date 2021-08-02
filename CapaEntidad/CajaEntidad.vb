Public Class CajaEntidad

    Private _id_caja As Integer
    Public Property id_caja() As Integer
        Get
            Return _id_caja
        End Get
        Set(ByVal value As Integer)
            _id_caja = value
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

    Private _estado_t_c As String
    Public Property estado_t_c() As String
        Get
            Return _estado_t_c
        End Get
        Set(ByVal value As String)
            _estado_t_c = value
        End Set
    End Property

End Class
