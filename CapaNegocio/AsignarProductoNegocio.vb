Imports CapaEntidad, CapaDatos
Public Class AsignarProductoNegocio


    Public Function asignarproducto(codigo As Integer) As List(Of AsignarProductoEntidad)
        Dim asig As New AsignarProductoDatos
        Return asig.asignarproducto(codigo)

    End Function
End Class
