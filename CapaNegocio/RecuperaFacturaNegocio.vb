Imports CapaDatos, CapaEntidad
Public Class RecuperaFacturaNegocio


    Dim asig As New RecuperarFacturaDatos
    Public Function recuperar_factura(ByVal num As Integer) As List(Of CabeceraFacturaEntidad)
        Try
            Return asig.recuperar_factura(num)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function



End Class
