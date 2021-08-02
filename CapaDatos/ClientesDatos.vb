Imports CapaEntidad
Imports System.Data.SqlClient

Public Class ClientesDatos

    Public Function buscarCliente(ByVal pDescripcion As String) As List(Of ClienteEntidad)
        Try
            Dim listaProductos As New List(Of ClienteEntidad)
            Call conectar()

            stringSql = "SELECT * from clientes INNER JOIN categoria_cliente ON FK_ID_tipo_cliente = ID_tipo_cliente where CEDULA like @pDescripcion or NOMBRE like @pDescripcion or APELLIDO_paterno like @pDescripcion and estado_c ='A'"


            comando = New SqlCommand(stringSql, conexionBD)
            comando.Parameters.AddWithValue("@pDescripcion", pDescripcion)
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
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            buscarCliente = Nothing
        End Try
    End Function



    Public Function recuperarCliente(ByVal codigo As String) As List(Of ClienteEntidad)
        Try
            recuperarCliente = Nothing
            Dim lista As New List(Of ClienteEntidad)
            Call conectar()
            stringSql = "SELECT * from clientes INNER JOIN categoria_cliente ON FK_ID_tipo_cliente = ID_tipo_cliente where cedula ='" & codigo & "'"
            comando = New SqlCommand(stringSql, conexionBD)
            resultado = comando.ExecuteReader()

            If resultado.HasRows Then
                While resultado.Read
                    Dim registro As New ClienteEntidad
                    registro.dni_CLIENTE = IIf(resultado("dni_CLIENTE") Is DBNull.Value, 0, resultado("dni_CLIENTE"))
                    registro.descripcion = IIf(resultado("descripcion") Is DBNull.Value, "", resultado("descripcion"))
                    registro.CEDULA = IIf(resultado("CEDULA") Is DBNull.Value, "", resultado("CEDULA"))
                    registro.NOMBRE = IIf(resultado("NOMBRE") Is DBNull.Value, "", resultado("NOMBRE"))
                    registro.APELLIDO_paterno = IIf(resultado("APELLIDO_paterno") Is DBNull.Value, "", resultado("APELLIDO_paterno"))
                    registro.APELLIDO_materno = IIf(resultado("APELLIDO_materno") Is DBNull.Value, "", resultado("APELLIDO_materno"))
                    registro.direccion = IIf(resultado("direccion") Is DBNull.Value, "", resultado("direccion"))
                    registro.telefono = IIf(resultado("telefono") Is DBNull.Value, "", resultado("telefono"))

                    lista.Add(registro)
                End While
            End If
            desconectar()
            Return lista
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function




End Class
