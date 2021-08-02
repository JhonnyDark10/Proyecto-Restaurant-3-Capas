Imports CapaDatos, CapaEntidad
Public Class VerificarMesasCanceladasNegocio

    Dim mesas As New VerificaMesasCanceladasDatos
    Public Function buscarCanceladas(cancela_factura As Integer) As List(Of CabeceraFacturaEntidad)
        Try
            Return mesas.buscarCanceladas(cancela_factura)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function
End Class
