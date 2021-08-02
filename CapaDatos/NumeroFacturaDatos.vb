Imports System.Data.SqlClient
Imports CapaDatos, CapaEntidad
Public Class NumeroFacturaDatos


    Public Function cargar_numero_factura() As List(Of NumeroFacturaentidad)
        Try
            cargar_numero_factura = Nothing
            Dim lista As New List(Of NumeroFacturaEntidad)
            Call conectar()
            stringSql = "SELECT max(id_factura) as id_factura FROM FACTURA_CLIENTE "
            comando = New SqlCommand(stringSql, conexionBD)

            resultado = comando.ExecuteReader()

            While resultado.Read
                Dim registro As New NumeroFacturaEntidad
                registro.id_factura = resultado("id_factura")
                asig_fac = resultado("id_factura")
                lista.Add(registro)
            End While
            Call desconectar()
            Return lista

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function





End Class
