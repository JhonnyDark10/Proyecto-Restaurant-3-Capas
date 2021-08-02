Imports System.Data.SqlClient

Public Class PagoFacturaDatos

    Public Sub pago_factura(codigo As Integer)

        Try
            Call conectar()
            stringSql = "update factura_cliente set" _
            & " ESTADO_FACT = 'C'" _
            & " where estado_fact = 'P' AND ID_FACTURA = " & codigo

            comando = New SqlCommand(stringSql, conexionBD)
            comando.ExecuteNonQuery()



            stringSql = ""
            stringSql = "UPDATE ORDEN_DETALLE SET " _
            & "ESTADO_D_O = 'C'" _
            & " WHERE ESTADO_D_O = 'A' AND FK_ID_FACTURA = " & codigo
            comando.CommandText = stringSql
            comando.ExecuteNonQuery()


            Call desconectar()

        Catch ex As Exception

        End Try

    End Sub


End Class
