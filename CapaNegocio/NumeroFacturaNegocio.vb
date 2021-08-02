Imports CapaDatos, CapaEntidad
Public Class NumeroFacturaNegocio

    Function cargar_numero_factura() As List(Of NumeroFacturaEntidad)
        Try

            Dim lista As New List(Of NumeroFacturaEntidad)
            Dim obj As New NumeroFacturaDatos
            lista = obj.cargar_numero_factura
            Return lista

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
