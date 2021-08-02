Imports CapaEntidad
Imports System.Data.SqlClient

Public Class RecuperarFacturaDatos

    Public Function recuperar_factura(ByVal num As Integer) As List(Of CabeceraFacturaEntidad)

        Try

            Dim listaProductos As New List(Of CabeceraFacturaEntidad)
            stringSql = "select *from FACTURA_CLIENTE F INNER JOIN CLIENTES C ON F.FK_CLIENTE = C.DNI_CLIENTE  where  F.ESTADO_FACT = 'P' and  F.NUMERO_MESA =" & num
            Call conectar()

            comando = New SqlCommand(stringSql, conexionBD)
            resultado = comando.ExecuteReader()
            If resultado.HasRows Then
                While resultado.Read
                    Dim registro As New CabeceraFacturaEntidad
                    registro.id_factura = resultado("id_factura")
                    registro.FK_CLIENTE = resultado("FK_CLIENTE")
                    registro.FK_TIPO_PAGO = resultado("FK_TIPO_PAGO")
                    registro.TIPO_ORDEN = resultado("TIPO_ORDEN")
                    registro.SUBTOTAL = resultado("SUBTOTAL")
                    registro.DESCUENTO = resultado("DESCUENTO")
                    registro.IVA = resultado("IVA")
                    registro.TOTAL_PAGO = resultado("TOTAL_PAGO")
                    registro.FECHA_FACTURA = resultado("FECHA_FACTURA")
                    ' registro.HORA_PEDIDO = resultado("HORA_PEDIDO")
                    registro.TIEMPO_ENTREGA = resultado("TIEMPO_ENTREGA")
                    registro.ID_EMPLEADO = resultado("ID_EMPLEADO")
                    registro.NOMBRE_PC = resultado("NOMBRE_PC")
                    registro.NOMRE_USU = resultado("NOMRE_USU")
                    registro.ESTADO_FACT = resultado("ESTADO_FACT")
                    registro.NUMERO_MESA = resultado("NUMERO_MESA")


                    listaProductos.Add(registro)
                End While
            End If
            desconectar()
            resultado.Close()

            Return listaProductos
        
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Call desconectar()
        End Try
    End Function

End Class
