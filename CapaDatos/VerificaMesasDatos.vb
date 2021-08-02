Imports CapaEntidad
Imports System.Data.SqlClient

Public Class VerificaMesasDatos
    Public Function buscar() As List(Of CabeceraFacturaEntidad)
        Try
            Dim listaProductos As New List(Of CabeceraFacturaEntidad)
            stringSql = "select * from factura_cliente where estado_fact = 'p'"
            Call conectar()

            comando = New SqlCommand(stringSql, conexionBD)
            resultado = comando.ExecuteReader()

            If resultado.HasRows Then
                While resultado.Read
                    Dim registro As New CabeceraFacturaEntidad
                    registro.NUMERO_MESA = resultado("NUMERO_MESA")

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
