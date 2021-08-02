Imports CapaDatos, CapaEntidad
Public Class RecuperaDetalleNegocio



    Dim asig As New RecuperarDetalleFacturaDatos
    Public Function recuperar_detalle(ByVal num As Integer) As List(Of DetalleFacturaEntidad)
        Try
            Return asig.recuperar_detalle(num)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function





End Class
