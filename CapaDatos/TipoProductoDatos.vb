Imports CapaEntidad
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mime.MediaTypeNames

Public Class TipoProductoDatos

    Public Function retornaproducto(descripcion As String) As List(Of TipoProductoEntidad)
        Try

            Dim listaProductos As New List(Of TipoProductoEntidad)

            stringSql = "SELECT P.CODIGO_PLATOS, P.FK_ID_CATEGORIA_PLATOS, P.PRECIO, P.NOMBRE,P.ESTADO_P, P.STOCK,P.FOTO_P,CP.ID_CATEGORIA_PLATOS, CP.DESCRIPCION, CP.ESTADO_C_P" _
            & " FROM  PLATOS P INNER JOIN CATEGORIA_PLATOS CP ON P.FK_ID_CATEGORIA_PLATOS = CP.ID_CATEGORIA_PLATOS" _
            & " WHERE CP.ESTADO_C_P = 'A' AND P.ESTADO_P = 'A' and CP.DESCRIPCION = '" & descripcion & "'"

            Call conectar()


            comando = New SqlCommand(stringSql, conexionBD)
            comando.Parameters.AddWithValue("@pDescripcion", descripcion)
            resultado = comando.ExecuteReader()


            If resultado.HasRows Then
                While resultado.Read
                    Dim registro As New TipoProductoEntidad
                    registro.CODIGO_PLATOS = resultado("CODIGO_PLATOS")
                    registro.STOCK = resultado("STOCK")
                    registro.NOMBRE = resultado("NOMBRE")
                    registro.FOTO_P = resultado("FOTO_P")

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
