Imports CapaNegocio
Public Class frm_buscar_clientes
    Private cliente As New ClienteNegocio
    Private Sub frm_buscar_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_buscar_TextChanged(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            dgv.DataSource = cliente.buscarCliente("%" & txt_buscar.Text & "%")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Try
            '
            'Si el row en el que hicimos doble click es el encabezado del DataGridView, nos retornamos.
            If e.RowIndex = -1 Then
                Return
            End If
            g_str_cedula = dgv.Rows(e.RowIndex).Cells(2).Value
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
       
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class