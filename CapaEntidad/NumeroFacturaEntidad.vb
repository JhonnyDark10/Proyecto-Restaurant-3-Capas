Public Class NumeroFacturaEntidad

    Private _id_factura As Integer
    Public Property id_factura() As Integer
        Get
            Return _id_factura
        End Get
        Set(ByVal value As Integer)
            _id_factura = value
        End Set
    End Property

End Class
