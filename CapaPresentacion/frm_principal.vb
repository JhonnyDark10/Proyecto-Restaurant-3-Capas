Public Class frm_principal

    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema de Restaurant "
        tss_usuario.Text = "Usuario: " & "Jhonny Flores"
        tss_fecha.Text = "Fecha: " & Format(Now, "dd/MM/yyyy")
    End Sub

    Private Sub OrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenToolStripMenuItem.Click
        Dim frm As New frm_orden
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim frm As New frm_proveedores
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class