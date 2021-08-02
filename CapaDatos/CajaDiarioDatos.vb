Imports CapaEntidad
Imports System.Data.SqlClient

Public Class CajaDiarioDatos


    Public Sub ingresocaja(tipo As String, descripcion As String, numero As Integer, monto As Double)

        Dim transaction As SqlTransaction
        Try
            Call conectar()
            transaction = conexionBD.BeginTransaction("Transaccion1")

            stringSql = "Insert into cierre_caja(movimiento,descripcion,numero_caja,fecha,total,estado_c_c) values (" _
               & "'" & tipo & "'," _
               & "'" & descripcion & "'," _
               & numero & "," _
               & "'" & DateTime.Now.ToString("dd/MM/yyyy") & "'," _
               & monto & "," _
               & "'A" & "')"


            comando = New SqlCommand(stringSql, conexionBD)
            comando.Transaction = transaction
            'comando.CommandType = CommandType.StoredProcedure


            comando.ExecuteNonQuery()

            transaction.Commit()
            Call desconectar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

End Class
