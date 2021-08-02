Imports CapaDatos, CapaEntidad
Public Class PagoFacturaNegocio


    Public Sub pago_factura(codigo As Integer)

        Dim asig As New PagoFacturaDatos
        asig.pago_factura(codigo)

    End Sub


End Class
