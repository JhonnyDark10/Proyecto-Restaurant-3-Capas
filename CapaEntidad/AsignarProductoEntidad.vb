Public Class AsignarProductoEntidad


    Private _NOMBRE As String
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property

    Private _precio As Double
    Public Property precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property

    Private _STOCK As Integer
    Public Property STOCK() As Integer
        Get
            Return _STOCK
        End Get
        Set(ByVal value As Integer)
            _STOCK = value
        End Set
    End Property

End Class
