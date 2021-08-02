Imports System.Data.SqlClient
Module ModuloGeneral
    Public conexionBD As New SqlConnection(My.Settings.conexion)
    Public stringSql As String
    Public comando As New SqlCommand()
    Public resultado As SqlDataReader

    Public asig_fac As Integer

    Public Sub conectar()
        If conexionBD.State = ConnectionState.Closed Then
            conexionBD.Open()
        End If
    End Sub

    Public Sub desconectar()
        If conexionBD.State = ConnectionState.Open Then
            conexionBD.Close()
        End If
    End Sub

End Module
