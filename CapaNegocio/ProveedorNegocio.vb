Imports CapaDatos, CapaEntidad
Public Class ProveedorNegocio

    Public Sub guardarProveedor(pFactura As ProveedorEntidad)
        Try
            Dim factura As New ProveedorDato
            factura.guardarProveedor(pFactura)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class
