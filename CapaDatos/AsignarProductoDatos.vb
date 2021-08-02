Imports CapaEntidad
Imports System.Data.SqlClient

Public Class AsignarProductoDatos

    Public Function asignarproducto(codigo As Integer) As List(Of AsignarProductoEntidad)
        Try

            Dim listaProductos As New List(Of AsignarProductoEntidad)

            stringSql = "select *from platos WHERE CODIGO_PLATOS =" & codigo
            Call conectar()

            comando = New SqlCommand(stringSql, conexionBD)
            resultado = comando.ExecuteReader()


            If resultado.HasRows Then
                While resultado.Read
                    Dim registro As New AsignarProductoEntidad
                    registro.STOCK = resultado("STOCK")
                    registro.NOMBRE = resultado("NOMBRE")
                    registro.precio = resultado("precio")

                    listaProductos.Add(registro)
                End While
            End If
            desconectar()
            resultado.Close()

            Return listaProductos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



End Class
