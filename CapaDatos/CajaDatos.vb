Imports CapaEntidad
Imports System.Data.SqlClient
Public Class CajaDatos

    Function cargar_combo_caja() As DataTable
        Try
            Dim dt As New DataTable
            Call conectar()
            Dim cadenasql As String
            cadenasql = "select * from caja where estado_t_c = 'A'"
            conectar()
            comando = New SqlCommand(cadenasql, conexionBD)

            resultado = comando.ExecuteReader()
            dt.Load(resultado)
            Return dt
            Call desconectar()
            resultado.Close()
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

End Class
