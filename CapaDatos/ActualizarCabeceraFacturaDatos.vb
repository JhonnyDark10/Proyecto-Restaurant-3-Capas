Imports CapaEntidad
Imports System.Data.SqlClient

Public Class ActualizarCabeceraFacturaDatos
    Public Sub facturaactualizada(pFactura As CabeceraFacturaEntidad, pListaDetalle As List(Of DetalleFacturaEntidad))

        ' Dim transaccion As SqlTransaction
        Try

            Call conectar()
            ' transaccion = conexionBD.BeginTransaction("facturaTran")
            'transaccion = conexionBD.BeginTransaction("facturaTran")

            stringSql = "update factura_cliente set" _
           & " FK_CLIENTE = " & pFactura.FK_CLIENTE & " ," _
           & " subtotal = " & Trim(Str(CDbl(pFactura.SUBTOTAL))) & " ," _
           & " DESCUENTO = " & Trim(Str(CDbl(pFactura.DESCUENTO))) & " ," _
           & " IVA = " & Trim(Str(CDbl(pFactura.IVA))) & " ," _
           & " TOTAL_PAGO = " & Trim(Str(CDbl(pFactura.TOTAL_PAGO))) & " ," _
           & " ID_EMPLEADO = " & pFactura.ID_EMPLEADO & " ," _
           & " NOMBRE_PC = '" & pFactura.NOMBRE_PC & "'," _
           & " NOMRE_USU = '" & pFactura.NOMRE_USU & "' " _
           & " where estado_fact = 'P' AND ID_FACTURA = " & pFactura.id_factura
            'comando.Transaction = transaccion
            comando = New SqlCommand(stringSql, conexionBD)
            comando.ExecuteScalar()

            Try

                Dim registroDetalle As New DetalleFacturaEntidad

                For Each registroDetalle In pListaDetalle

                    If (registroDetalle.accion_p) = 1 Then
                        stringSql = "insert into ORDEN_DETALLE(FK_ID_FACTURA, FK_COD_PLATOS, SUBTOTAL, CANTIDAD_P, TOTAL, ESTADO_D_O) " _
                                           & " VALUES (@FK_ID_FACTURA,@FK_COD_PLATOS,@SUBTOTAL,@CANTIDAD_P,@TOTAL,'A')"

                        'comando = New SqlCommand(stringSql, conexionBD)
                        comando.CommandText = stringSql
                        comando.Parameters.Clear()
                        comando.Parameters.AddWithValue("@FK_ID_FACTURA", registroDetalle.FK_ID_FACTURA)
                        comando.Parameters.AddWithValue("@FK_COD_PLATOS", registroDetalle.FK_COD_PLATOS)
                        comando.Parameters.AddWithValue("@SUBTOTAL", registroDetalle.SUBTOTAL)
                        comando.Parameters.AddWithValue("@CANTIDAD_P", registroDetalle.CANTIDAD_P)
                        comando.Parameters.AddWithValue("@TOTAL", registroDetalle.TOTAL)
                        comando.ExecuteNonQuery()
                        '**********************************************
                        stringSql = ""
                        stringSql = "Update platos " _
                        & "set stock = stock-" & registroDetalle.CANTIDAD_P & " " _
                        & " where codigo_platos = " & registroDetalle.FK_COD_PLATOS
                        comando.CommandText = stringSql
                        comando.ExecuteNonQuery()

                        'Else
                        '    stringSql = ""
                        '    stringSql = "UPDATE ORDEN_DETALLE SET " _
                        '    & "CANTIDAD_P = " & registroDetalle.CANTIDAD_P & "," _
                        '    & "TOTAL = " & registroDetalle.TOTAL _
                        '    & " WHERE ESTADO_D_O = 'A' AND FK_ID_FACTURA = " & registroDetalle.FK_ID_FACTURA
                        '    comando.CommandText = stringSql
                        '    comando.ExecuteNonQuery()
                        '    '**********************************************
                    End If
                Next

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

            'transaccion.Commit()
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Try
                '  transaccion.Rollback()

            Catch ex1 As Exception
                MsgBox(ex1.Message, MsgBoxStyle.Information)
            End Try
        End Try
    End Sub

End Class
