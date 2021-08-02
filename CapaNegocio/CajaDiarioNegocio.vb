Imports CapaEntidad, CapaDatos

Public Class CajaDiarioNegocio

    Public Sub ingresocaja(tipo As String, descripcion As String, numero As Integer, monto As Double)

        Dim caja As New CajaDiarioDatos
        caja.ingresocaja(tipo, descripcion, numero, monto)
    End Sub

End Class
