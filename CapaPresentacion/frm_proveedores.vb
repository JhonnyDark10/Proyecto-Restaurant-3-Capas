Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports CapaEntidad
Imports CapaNegocio

Public Class frm_proveedores

    Private Sub frm_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chk_estado.Checked = True
        txt_codigo.Text = int_id_proveedor
        txt_email_proveedores.Text = "example@hotmail.com"

        limpiar()

    End Sub

    Private Sub limpiar()
        txt_cedula_proveedor.Text = ""
        txt_nombre_proveedores.Text = ""
        txt_apellidos_proveedores.Text = ""
        txt_apellido2_proveedores.Text = ""
        txt_direccion_proveedores.Text = ""
        txt_email_proveedores.Text = "example@hotmail.com"
        txt_telefono_proveedores.Text = ""
    End Sub

    Private Sub txt_nombre_proveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_proveedores.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
    End Sub

    Private Sub txt_apellidos_proveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidos_proveedores.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_apellido2_proveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido2_proveedores.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_telefono_proveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono_proveedores.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_telefono_proveedores.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_proveedores.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_telefono_proveedores.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_proveedores.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_cedula_proveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula_proveedor.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_cedula_proveedor.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_proveedor.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_cedula_proveedor.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_proveedor.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub


    Private Sub btn_volver_cliente_Click(sender As Object, e As EventArgs) Handles btn_volver_cliente.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_cliente_Click(sender As Object, e As EventArgs) Handles btn_guardar_cliente.Click
        Try

            If fun_validar() = True Then
                fun_grabar()
                MessageBox.Show("El proceso se registró con éxito", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                ' MessageBox.Show("El proceso se registró con éxito", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub fun_grabar()

        Try
            Dim FACTURA As New ProveedorEntidad
            Dim obj As New ProveedorNegocio
            Dim estado As String
            FACTURA.CEDULA = txt_cedula_proveedor.Text
            FACTURA.NOMBRE = txt_nombre_proveedores.Text
            FACTURA.APELLIDO_paterno = txt_apellidos_proveedores.Text
            FACTURA.APELLIDO_materno = txt_apellido2_proveedores.Text
            FACTURA.direccion = txt_direccion_proveedores.Text
            FACTURA.email = txt_email_proveedores.Text
            FACTURA.telefono = txt_telefono_proveedores.Text

            If chk_estado.Checked = True Then
                estado = "A"
            Else
                estado = "I"
            End If
            FACTURA.estado_p = estado

            obj.guardarProveedor(FACTURA)


        Catch ex As Exception
        End Try
    End Sub

    Function fun_validar() As Boolean
        fun_validar = False
        Try
            If txt_cedula_proveedor.Text = "" Then
                MessageBox.Show("Ingrese la cedula del cliente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_cedula_proveedor.Focus()
                fun_validar = False
                Exit Function
            End If
            If txt_nombre_proveedores.Text = "" Then
                MessageBox.Show("Ingrese el nombre del cliente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_nombre_proveedores.Focus()
                fun_validar = False
                Exit Function
            End If
            If txt_apellidos_proveedores.Text = "" Then
                MessageBox.Show("Ingrese el apellido del cliente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_apellidos_proveedores.Focus()
                fun_validar = False
                Exit Function
            End If
            If txt_direccion_proveedores.Text = "" Then
                MessageBox.Show("Ingrese la direccion del cliente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_direccion_proveedores.Focus()
                fun_validar = False
                Exit Function
            End If
            If validar_Mail(txt_email_proveedores.Text) = False Then
                MessageBox.Show("Formato De Correo Incorrecto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_email_proveedores.Focus()
                fun_validar = False
                Exit Function
            End If

            fun_validar = True
        Catch ex As Exception
            fun_validar = False
        End Try
    End Function

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

End Class