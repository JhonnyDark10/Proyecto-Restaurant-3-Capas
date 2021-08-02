Imports CapaEntidad, CapaDatos
Public Class CabeceraFacturaNegocio
    Public Sub factura(pFactura As CabeceraFacturaEntidad, pListaDetalle As List(Of DetalleFacturaEntidad))
        Try
            Dim factura As New CabeceraFacturadatos
            factura.factura(pFactura, pListaDetalle)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Class
