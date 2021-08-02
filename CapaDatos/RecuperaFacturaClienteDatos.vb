Imports CapaEntidad
Imports System.Data.SqlClient
Public Class RecuperaFacturaClienteDatos


    Public Function recuperar_cliente(ByVal num As Integer) As List(Of ClienteEntidad)

        Try

            Dim listaProductos As New List(Of ClienteEntidad)
            stringSql = "select   C.DNI_CLIENTE, C.FK_ID_TIPO_CLIENTE, C.CEDULA, C.NOMBRE,C. APELLIDO_PATERNO,C.APELLIDO_MATERNO, " _
           & "C.DIRECCION, C.EMAIL, C.FECHA_NACIMIENTO, C.TELEFONO, C.ESTADO_C,TC.DESCRIPCION " _
           & " FROM     CLIENTES C INNER JOIN CATEGORIA_CLIENTE TC ON C.FK_ID_TIPO_CLIENTE = TC.ID_TIPO_CLIENTE" _
           & " where C.ESTADO_C='A' and C.dni_cliente  ='" & num & "'"


            Call conectar()

            comando = New SqlCommand(stringSql, conexionBD)
            resultado = comando.ExecuteReader()
            If resultado.HasRows Then
                While resultado.Read
                    Dim registro As New ClienteEntidad
                    registro.dni_CLIENTE = resultado("dni_CLIENTE")
                    registro.descripcion = resultado("descripcion")
                    registro.CEDULA = resultado("CEDULA")
                    registro.NOMBRE = resultado("NOMBRE")
                    registro.APELLIDO_paterno = resultado("APELLIDO_paterno")
                    registro.APELLIDO_materno = resultado("APELLIDO_materno")
                    registro.direccion = resultado("direccion")
                    registro.telefono = resultado("telefono")
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
