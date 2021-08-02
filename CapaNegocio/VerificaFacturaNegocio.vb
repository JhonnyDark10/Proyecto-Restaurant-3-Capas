Imports CapaDatos
Public Class VerificaFacturaNegocio

    Function verificar_numfactura(ByVal num As Integer) As Boolean
        Try

            verificar_numfactura = False


            Dim asig As New VerificaFacturaDatos
            If asig.verificar_numfactura(num) = True Then
                Return verificar_numfactura = True
            End If


            Return verificar_numfactura = False
        Catch ex As Exception
            verificar_numfactura = False
        End Try
    End Function



End Class
