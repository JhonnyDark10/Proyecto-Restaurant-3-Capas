Imports CapaDatos, CapaEntidad
Public Class ActualizarCabeceraFacturaNegocio
    Public Sub facturaactualizada(pFactura As CabeceraFacturaEntidad, pListaDetalle As List(Of DetalleFacturaEntidad))
        Try
            Dim factura As New ActualizarCabeceraFacturaDatos
            factura.facturaactualizada(pFactura, pListaDetalle)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


End Class
