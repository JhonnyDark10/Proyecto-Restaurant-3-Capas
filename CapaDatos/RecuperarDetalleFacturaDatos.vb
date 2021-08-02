Imports CapaEntidad
Imports System.Data.SqlClient

Public Class RecuperarDetalleFacturaDatos


    Public Function recuperar_detalle(ByVal num As Integer) As List(Of DetalleFacturaEntidad)

        Try

            Dim listaProductos As New List(Of DetalleFacturaEntidad)
            stringSql = "SELECT  * from FACTURA_CLIENTE F INNER JOIN ORDEN_DETALLE O  " _
             & "ON F.ID_FACTURA  = O.FK_ID_FACTURA INNER JOIN PLATOS P ON P.CODIGO_PLATOS = O.FK_COD_PLATOS" _
             & " where  O.ESTADO_D_O  = 'A' and  O.FK_ID_FACTURA  =" & num


            Call conectar()

            comando = New SqlCommand(stringSql, conexionBD)
            resultado = comando.ExecuteReader()
            If resultado.HasRows Then
                While resultado.Read
                    Dim registro As New DetalleFacturaEntidad

                    registro.FK_ID_FACTURA = resultado("FK_ID_FACTURA")
                    registro.nombre = resultado("nombre")
                    registro.FK_COD_PLATOS = resultado("FK_COD_PLATOS")
                    registro.SUBTOTAL = resultado("PRECIO")
                    registro.CANTIDAD_P = resultado("CANTIDAD_P")
                    registro.TOTAL = resultado("TOTAL")
                    registro.ESTADO_D_O = "A"

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
