Imports CapaEntidad
Imports System.Data.SqlClient


Public Class CabeceraFacturadatos

    Dim v_id_factura As Integer
    Public Sub factura(pFactura As CabeceraFacturaEntidad, pListaDetalle As List(Of DetalleFacturaEntidad))

        Dim transaccion As SqlTransaction
        Try

            Call conectar()
            transaccion = conexionBD.BeginTransaction("facturaTran")
            'transaccion = conexionBD.BeginTransaction("facturaTran")

            stringSql = " insert into FACTURA_CLIENTE( FK_CLIENTE, FK_TIPO_PAGO, TIPO_ORDEN, SUBTOTAL," _
            & "DESCUENTO, IVA, TOTAL_PAGO, FECHA_FACTURA, HORA_PEDIDO, TIEMPO_ENTREGA," _
            & "ID_EMPLEADO, NOMBRE_PC, NOMRE_USU,ESTADO_FACT,NUMERO_MESA) " _
            & " VALUES ( @FK_CLIENTE,@FK_TIPO_PAGO,@TIPO_ORDEN,@SUBTOTAL,@DESCUENTO,@IVA,@TOTAL_PAGO,@FECHA_FACTURA,@HORA_PEDIDO,@TIEMPO_ENTREGA,@ID_EMPLEADO, @NOMBRE_PC, @NOMRE_USU,'P',@NUMERO_MESA)"

            comando = New SqlCommand(stringSql, conexionBD)
            comando.Transaction = transaccion
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@FK_CLIENTE", pFactura.FK_CLIENTE)
            comando.Parameters.AddWithValue("@FK_TIPO_PAGO", pFactura.FK_TIPO_PAGO)
            comando.Parameters.AddWithValue("@TIPO_ORDEN", pFactura.TIPO_ORDEN)
            comando.Parameters.AddWithValue("@SUBTOTAL", Trim(Str(CDbl(pFactura.SUBTOTAL))))
            comando.Parameters.AddWithValue("@DESCUENTO", Trim(Str(CDbl(pFactura.DESCUENTO))))
            comando.Parameters.AddWithValue("@IVA", Trim(Str(CDbl(pFactura.IVA))))
            comando.Parameters.AddWithValue("@TOTAL_PAGO", Trim(Str(CDbl(pFactura.TOTAL_PAGO))))
            comando.Parameters.AddWithValue("@FECHA_FACTURA", pFactura.FECHA_FACTURA)
            comando.Parameters.AddWithValue("@HORA_PEDIDO", pFactura.HORA_PEDIDO)
            comando.Parameters.AddWithValue("@TIEMPO_ENTREGA", pFactura.TIEMPO_ENTREGA)
            comando.Parameters.AddWithValue("@ID_EMPLEADO", pFactura.ID_EMPLEADO)
            comando.Parameters.AddWithValue("@NOMBRE_PC", pFactura.NOMBRE_PC)
            comando.Parameters.AddWithValue("@NOMRE_USU", pFactura.NOMRE_USU)
            comando.Parameters.AddWithValue("@NUMERO_MESA", pFactura.NUMERO_MESA)

            comando.ExecuteScalar()

            Try

                Dim registroDetalle As New DetalleFacturaEntidad

                For Each registroDetalle In pListaDetalle

                    'stringSql = ""
                    stringSql = "insert into ORDEN_DETALLE(FK_ID_FACTURA, FK_COD_PLATOS, SUBTOTAL, CANTIDAD_P, TOTAL, ESTADO_D_O) " _
                    & " VALUES (@FK_ID_FACTURA,@FK_COD_PLATOS,@SUBTOTAL,@CANTIDAD_P,@TOTAL,'A')"

                    'comando = New SqlCommand(stringSql, conexionBD)
                    comando.CommandText = stringSql
                    comando.Parameters.Clear()
                    comando.Parameters.AddWithValue("@FK_ID_FACTURA", asig_fac + 1)
                    comando.Parameters.AddWithValue("@FK_COD_PLATOS", registroDetalle.FK_COD_PLATOS)
                    comando.Parameters.AddWithValue("@SUBTOTAL", registroDetalle.SUBTOTAL)
                    comando.Parameters.AddWithValue("@CANTIDAD_P", registroDetalle.CANTIDAD_P)
                    comando.Parameters.AddWithValue("@TOTAL", registroDetalle.TOTAL)
                    comando.ExecuteNonQuery()

                    'stringSql = ""
                    'stringSql = "Update platos set stock = stock-" & registroDetalle.CANTIDAD_P & " " _
                    '& " where codigo_platos = " & registroDetalle.FK_COD_PLATOS
                    'comando.ExecuteNonQuery()
                    stringSql = ""
                    stringSql = "Update platos " _
                    & "set stock = stock-" & registroDetalle.CANTIDAD_P & " " _
                    & " where codigo_platos = " & registroDetalle.FK_COD_PLATOS
                    comando.CommandText = stringSql
                    comando.ExecuteNonQuery()

                Next

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            transaccion.Commit()
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Try
                transaccion.Rollback()

            Catch ex1 As Exception
                MsgBox(ex1.Message, MsgBoxStyle.Information)
            End Try
        End Try
    End Sub


End Class
