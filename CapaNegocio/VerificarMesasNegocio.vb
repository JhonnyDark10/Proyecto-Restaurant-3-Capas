Imports CapaDatos, CapaEntidad
Public Class VerificarMesasNegocio

    Dim mesas As New VerificaMesasDatos
    Public Function buscar() As List(Of CabeceraFacturaEntidad)
        Try
            Return mesas.buscar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function
End Class
