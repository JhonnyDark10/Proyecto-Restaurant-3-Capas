Imports CapaEntidad
Imports System.Data.SqlClient

Public Class AnularPedidoDatos


    Public Sub anularpedido(numfac As Integer, producto As Integer, cantidad As Integer, codigo As Integer)

        Try
            Call conectar()


            stringSql = "update orden_detalle set estado_d_o = 'N' WHERE estado_d_o ='A' and fk_id_factura = " & numfac & " and FK_COD_PLATOS = " & codigo

            comando = New SqlCommand(stringSql, conexionBD)
            comando.ExecuteNonQuery()


            stringSql = ""
            stringSql = "Update platos " _
            & "set stock = stock+" & cantidad & " " _
            & " where codigo_platos = " & codigo
            comando.CommandText = stringSql
            comando.ExecuteNonQuery()

            Call desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


End Class
