Imports System.Data.SqlClient

Public Class VerificaFacturaDatos


    Function verificar_numfactura(ByVal num As Integer) As Boolean
        Try
            Call conectar()
            verificar_numfactura = False

            stringSql = "select * from FACTURA_CLIENTE where id_factura = " & num

            comando = New SqlCommand(stringSql, conexionBD)
            resultado = comando.ExecuteReader()

            If resultado.HasRows Then
                While resultado.Read
                    Return verificar_numfactura = True
                End While
            End If

            Return verificar_numfactura = False
        Catch ex As Exception
            verificar_numfactura = False
        Finally
            Call desconectar()
        End Try
    End Function


End Class
