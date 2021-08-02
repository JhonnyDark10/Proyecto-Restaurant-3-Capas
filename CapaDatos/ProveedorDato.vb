Imports CapaEntidad
Imports System.Data.SqlClient

Public Class ProveedorDato


    Public Sub guardarProveedor(pFactura As ProveedorEntidad)
        Try

            Call conectar()
            stringSql = "INSERT INTO PROVEEDORES(CEDULA,NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, DIRECCION, TELEFONO, EMAIL, ESTADO_P) VALUES (" _
            & "'" & pFactura.CEDULA & "', " _
            & "'" & pFactura.NOMBRE & "', " _
            & "'" & pFactura.APELLIDO_paterno & "'," _
            & "'" & pFactura.APELLIDO_materno & "', " _
            & "'" & pFactura.direccion & "', " _
            & "'" & pFactura.telefono & "', " _
            & "'" & pFactura.email & "', " _
            & "'" & pFactura.estado_p & "')"

            comando = New SqlCommand(stringSql, conexionBD)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Class
