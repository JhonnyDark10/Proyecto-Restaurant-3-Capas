Imports CapaDatos, CapaEntidad
Public Class AnularPedidoNegocio


    Public Sub anularpedido(numfac As Integer, producto As Integer, cantidad As Integer, codigo As Integer)

        Dim anula As New AnularPedidoDatos
        anula.anularpedido(numfac, producto, cantidad, codigo)
    End Sub


End Class

