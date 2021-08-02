Imports System.Windows.Forms
Imports CapaNegocio

Public Class frm_pago

    Private Sub frm_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cambio.Text = Format(0, "##,##0.00")
        txt_efectivo.Text = Format(0, "##,##0.00")
        txt_tarjeta.Text = Format(0, "##,##0.00")
        txt_pago_caja.Text = Format(total_f, "##,##0.00")
    End Sub

    Private Sub txt_tarjeta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tarjeta.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_tarjeta.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_tarjeta.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_tarjeta.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_tarjeta.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_tarjeta_LostFocus(sender As Object, e As EventArgs) Handles txt_tarjeta.LostFocus
        txt_cambio.Text = Format((CDbl(txt_tarjeta.Text) - CDbl(txt_pago_caja.Text)), "##,##0.00")
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Val(txt_pago_caja.Text) < Val(txt_efectivo.Text) Or Val(txt_pago_caja.Text) < Val(txt_tarjeta.Text) Then

            fun_cancela_Factura()
            MessageBox.Show("Factura Cancelada ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Else
            MessageBox.Show("Monto Inferior Al Total de la Cuenta ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_efectivo.Focus()
        End If

    End Sub

    Sub fun_cancela_Factura()

        Dim asig As New PagoFacturaNegocio
        asig.pago_factura(cancela_factura)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_efectivo.Text > 0 Then
            txt_cambio.Text = Format((CDbl(txt_efectivo.Text) - CDbl(txt_pago_caja.Text)), "##,##0.00")
            int_tipo_pago = 1
        End If

    End Sub

    Private Sub btn_tarjeta_Click(sender As Object, e As EventArgs) Handles btn_tarjeta.Click
        If txt_tarjeta.Text > 0 Then
            txt_cambio.Text = Format((CDbl(txt_tarjeta.Text) - CDbl(txt_pago_caja.Text)), "##,##0.00")
            int_tipo_pago = 2
        End If
    End Sub

    Private Sub txt_efectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_efectivo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_efectivo.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_efectivo.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_efectivo.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_efectivo.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_efectivo_TextChanged(sender As Object, e As EventArgs) Handles txt_efectivo.TextChanged

    End Sub

    Private Sub txt_tarjeta_TextChanged(sender As Object, e As EventArgs) Handles txt_tarjeta.TextChanged

    End Sub

End Class