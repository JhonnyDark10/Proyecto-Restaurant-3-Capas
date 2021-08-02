Imports CapaDatos, CapaEntidad
Public Class RecuperarFacturaClienteNegocio



    Dim asig As New RecuperaFacturaClienteDatos
    Public Function recuperar_cliente(ByVal num As Integer) As List(Of ClienteEntidad)
        Try
            Return asig.recuperar_cliente(num)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function





End Class
