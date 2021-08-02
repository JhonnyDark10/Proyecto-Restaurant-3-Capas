Imports CapaEntidad, CapaDatos

Public Class TipoProductoNegocio


    Public Function retornaproducto(descripcion As String) As List(Of TipoProductoEntidad)

        Dim asig As New TipoProductoDatos
        Return asig.retornaproducto(descripcion)

    End Function




End Class
