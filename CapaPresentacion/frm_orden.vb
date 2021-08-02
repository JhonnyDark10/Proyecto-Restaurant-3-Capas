Imports System.Drawing
Imports CapaNegocio
Imports CapaEntidad
Imports System.Windows.Forms

Public Class frm_orden

    Private Sub btn_mesa1_Click(sender As Object, e As EventArgs) Handles btn_mesa1.Click
        If btn_mesa1.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 1
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 1
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub


    Private Sub btn_mesa2_Click(sender As Object, e As EventArgs) Handles btn_mesa2.Click
        If btn_mesa2.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 2
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 2
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa3_Click(sender As Object, e As EventArgs) Handles btn_mesa3.Click
        If btn_mesa3.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 3
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 3
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa4_Click(sender As Object, e As EventArgs) Handles btn_mesa4.Click
        If btn_mesa4.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 4
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 4
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa5_Click(sender As Object, e As EventArgs) Handles btn_mesa5.Click
        If btn_mesa5.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 5
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 5
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa6_Click(sender As Object, e As EventArgs) Handles btn_mesa6.Click
        If btn_mesa6.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 6
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 6
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa7_Click(sender As Object, e As EventArgs) Handles btn_mesa7.Click
        If btn_mesa7.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 7
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 7
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa8_Click(sender As Object, e As EventArgs) Handles btn_mesa8.Click
        If btn_mesa8.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 8
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 8
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa9_Click(sender As Object, e As EventArgs) Handles btn_mesa9.Click
        If btn_mesa9.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 9
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 9
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa10_Click(sender As Object, e As EventArgs) Handles btn_mesa10.Click
        If btn_mesa10.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 10
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 10
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa11_Click(sender As Object, e As EventArgs) Handles btn_mesa11.Click
        If btn_mesa11.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 11
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 11
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If

    End Sub

    Private Sub btn_mesa12_Click(sender As Object, e As EventArgs) Handles btn_mesa12.Click
        If btn_mesa12.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 12
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 12
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If

    End Sub

    Private Sub btn_mesa13_Click(sender As Object, e As EventArgs) Handles btn_mesa13.Click
        If btn_mesa13.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 13
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 13
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If

    End Sub

    Private Sub btn_mesa14_Click(sender As Object, e As EventArgs) Handles btn_mesa14.Click
        If btn_mesa14.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 14
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 14
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa15_Click(sender As Object, e As EventArgs) Handles btn_mesa15.Click
        If btn_mesa15.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 15
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 15
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa16_Click(sender As Object, e As EventArgs) Handles btn_mesa16.Click
        If btn_mesa16.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 16
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 16
            frm_orden_registro.txt_tipo_orden_o.Text = "Mesa"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa17_Click(sender As Object, e As EventArgs) Handles btn_mesa17.Click
        If btn_mesa17.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 17
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 17
            frm_orden_registro.txt_tipo_orden_o.Text = "llevar"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa18_Click(sender As Object, e As EventArgs) Handles btn_mesa18.Click
        If btn_mesa18.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 18
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 18
            frm_orden_registro.txt_tipo_orden_o.Text = "llevar"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa19_Click(sender As Object, e As EventArgs) Handles btn_mesa19.Click
        If btn_mesa19.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 19
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 19
            frm_orden_registro.txt_tipo_orden_o.Text = "llevar"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub

    Private Sub btn_mesa20_Click(sender As Object, e As EventArgs) Handles btn_mesa20.Click
        If btn_mesa20.BackColor = Color.Red Then
            int_asignar_pedido = 1
            int_recuperaNM = 20
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas_pagadas()
        Else
            int_asignar_pedido = 0
            frm_orden_registro.txt_numero_mesa_o.Text = 20
            frm_orden_registro.txt_tipo_orden_o.Text = "llevar"
            frm_orden_registro.ShowDialog()
            verificar_Estado_mesas()
        End If
    End Sub


    Private Sub frm_orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If g_int_inicio_c = 1 Then
            gbo_ordenmesa.Enabled = False
            gbo_ordenllevar.Enabled = False
            gbo_egreso.Enabled = False
        Else
            gbo_ordenmesa.Enabled = True
            gbo_ordenllevar.Enabled = True
            gbo_egreso.Enabled = True
        End If
        cargar_combo_caja()
        verificar_Estado_mesas()

    End Sub

    Sub cargar_combo_caja()

        Try
            Dim caja As New CajaNegocio
            cbo_numero_caja.DataSource = caja.cargar_combo_caja()
            cbo_numero_caja.DisplayMember = "descripcion"
            cbo_numero_caja.ValueMember = "id_caja"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub btn_nuevo1_Click(sender As Object, e As EventArgs) Handles btn_nuevo1.Click
        txt_descripcion_ingreso.Enabled = True
        txt_monto_caja_ingreso.Enabled = True
        btn_ingreso_c.Enabled = True
    End Sub

    Private Sub btn_ingreso_c_Click(sender As Object, e As EventArgs) Handles btn_ingreso_c.Click
        g_int_inicio_c = 2
        If txt_descripcion_ingreso.Text = " " Or txt_monto_caja_ingreso.Text = "" Then
            MessageBox.Show("Ingrese Monto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_monto_caja_ingreso.Focus()

        Else

            Dim i_caja As New CajaDiarioNegocio
            i_caja.ingresocaja("INGRESOS", txt_descripcion_ingreso.Text, cbo_numero_caja.SelectedValue, txt_monto_caja_ingreso.Text)

            gbo_ordenmesa.Enabled = True
            gbo_ordenllevar.Enabled = True
            gbo_egreso.Enabled = True
            int_caja_g = cbo_numero_caja.SelectedValue
            txt_descripcion_ingreso.Text = ""
            txt_monto_caja_ingreso.Text = ""
            txt_descripcion_ingreso.Enabled = False
            txt_monto_caja_ingreso.Enabled = False
            btn_ingreso_c.Enabled = False

            MessageBox.Show("Mesas Disponible", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_nuevo2_Click(sender As Object, e As EventArgs) Handles btn_nuevo2.Click
        txt_desscripcion_e.Enabled = True
        txt_monto_e.Enabled = True
        btn_egreso_e.Enabled = True
    End Sub

    Private Sub btn_egreso_e_Click(sender As Object, e As EventArgs) Handles btn_egreso_e.Click
        If txt_desscripcion_e.Text = " " Or txt_monto_e.Text = "" Then
            MessageBox.Show("Ingrese Monto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_monto_e.Focus()
        Else
            Dim i_caja As New CajaDiarioNegocio
            i_caja.ingresocaja("PAGOS", txt_desscripcion_e.Text, cbo_numero_caja.SelectedValue, txt_monto_e.Text)

            txt_desscripcion_e.Text = ""
            txt_monto_e.Text = ""
            txt_desscripcion_e.Enabled = False
            txt_monto_e.Enabled = False
            btn_egreso_e.Enabled = False

            MessageBox.Show("Pago Registrado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txt_descripcion_ingreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_descripcion_ingreso.KeyPress
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

    Private Sub txt_desscripcion_e_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_desscripcion_e.KeyPress
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

    Private Sub txt_monto_caja_ingreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_monto_caja_ingreso.KeyPress
        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_monto_caja_ingreso.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_monto_caja_ingreso.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_monto_caja_ingreso.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_monto_caja_ingreso.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_monto_e_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_monto_e.KeyPress
        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_monto_e.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_monto_e.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_monto_e.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_monto_e.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub


    Public Sub verificar_Estado_mesas()
        Try
            Dim lista_cp As New List(Of CabeceraFacturaEntidad)
            lista_cp = Nothing
            Dim obj As New VerificarMesasNegocio
            lista_cp = obj.buscar
            Dim n As Integer
            n = lista_cp.Count
            If n = 0 Then
            Else
                For i = 0 To n - 1
                    txt_estado_f.Text = lista_cp.Item(i).NUMERO_MESA
                    If txt_estado_f.Text = 1 Then
                        btn_mesa1.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 2 Then
                        btn_mesa2.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 3 Then
                        btn_mesa3.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 4 Then
                        btn_mesa4.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 5 Then
                        btn_mesa5.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 6 Then
                        btn_mesa6.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 7 Then
                        btn_mesa7.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 8 Then
                        btn_mesa8.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 9 Then
                        btn_mesa9.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 10 Then
                        btn_mesa10.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 11 Then
                        btn_mesa11.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 12 Then
                        btn_mesa12.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 13 Then
                        btn_mesa13.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 14 Then
                        btn_mesa14.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 15 Then
                        btn_mesa15.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 16 Then
                        btn_mesa16.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 17 Then
                        btn_mesa17.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 18 Then
                        btn_mesa18.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 19 Then
                        btn_mesa19.BackColor = Color.Red
                    ElseIf txt_estado_f.Text = 20 Then
                        btn_mesa20.BackColor = Color.Red
                    End If
                Next
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub verificar_Estado_mesas_pagadas()
        Try
            Dim lista_cp As New List(Of CabeceraFacturaEntidad)
            lista_cp = Nothing
            Dim obj As New VerificarMesasCanceladasNegocio
            lista_cp = obj.buscarCanceladas(cancela_factura)
            Dim n As Integer
            n = lista_cp.Count
            If n = 0 Then
            Else
                For i = 0 To n - 1
                    txt_e.Text = lista_cp.Item(i).NUMERO_MESA
                    If txt_e.Text = 1 Then
                        btn_mesa1.BackColor = Color.Lime
                    ElseIf txt_e.Text = 2 Then
                        btn_mesa2.BackColor = Color.Lime
                    ElseIf txt_e.Text = 3 Then
                        btn_mesa3.BackColor = Color.Lime
                    ElseIf txt_e.Text = 4 Then
                        btn_mesa4.BackColor = Color.Lime
                    ElseIf txt_e.Text = 5 Then
                        btn_mesa5.BackColor = Color.Lime
                    ElseIf txt_e.Text = 6 Then
                        btn_mesa6.BackColor = Color.Lime
                    ElseIf txt_e.Text = 7 Then
                        btn_mesa7.BackColor = Color.Lime
                    ElseIf txt_e.Text = 8 Then
                        btn_mesa8.BackColor = Color.Lime
                    ElseIf txt_e.Text = 9 Then
                        btn_mesa9.BackColor = Color.Lime
                    ElseIf txt_e.Text = 10 Then
                        btn_mesa10.BackColor = Color.Lime
                    ElseIf txt_e.Text = 11 Then
                        btn_mesa11.BackColor = Color.Lime
                    ElseIf txt_e.Text = 12 Then
                        btn_mesa12.BackColor = Color.Lime
                    ElseIf txt_e.Text = 13 Then
                        btn_mesa13.BackColor = Color.Lime
                    ElseIf txt_e.Text = 14 Then
                        btn_mesa14.BackColor = Color.Lime
                    ElseIf txt_e.Text = 15 Then
                        btn_mesa15.BackColor = Color.Lime
                    ElseIf txt_e.Text = 16 Then
                        btn_mesa16.BackColor = Color.Lime
                    ElseIf txt_e.Text = 17 Then
                        btn_mesa17.BackColor = Color.Lime
                    ElseIf txt_e.Text = 18 Then
                        btn_mesa18.BackColor = Color.Lime
                    ElseIf txt_e.Text = 19 Then
                        btn_mesa19.BackColor = Color.Lime
                    ElseIf txt_e.Text = 20 Then
                        btn_mesa20.BackColor = Color.Lime
                    End If
                Next
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



  

End Class