<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.tsp_Botones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tss_fecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tss_usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuPpal = New System.Windows.Forms.MenuStrip()
        Me.REGISTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INGRESOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsp_Botones.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuPpal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsp_Botones
        '
        Me.tsp_Botones.AutoSize = False
        Me.tsp_Botones.BackColor = System.Drawing.Color.White
        Me.tsp_Botones.Dock = System.Windows.Forms.DockStyle.Left
        Me.tsp_Botones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator2})
        Me.tsp_Botones.Location = New System.Drawing.Point(0, 36)
        Me.tsp_Botones.Name = "tsp_Botones"
        Me.tsp_Botones.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.tsp_Botones.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsp_Botones.Size = New System.Drawing.Size(94, 431)
        Me.tsp_Botones.TabIndex = 7
        Me.tsp_Botones.Text = "tsp_Botones"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(91, 4)
        Me.ToolStripButton2.Text = "Cerrar Secion"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(91, 6)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss_fecha, Me.tss_usuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1031, 24)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tss_fecha
        '
        Me.tss_fecha.Name = "tss_fecha"
        Me.tss_fecha.Size = New System.Drawing.Size(49, 19)
        Me.tss_fecha.Text = "Fecha"
        '
        'tss_usuario
        '
        Me.tss_usuario.Name = "tss_usuario"
        Me.tss_usuario.Size = New System.Drawing.Size(61, 19)
        Me.tss_usuario.Text = "Usuario"
        '
        'MenuPpal
        '
        Me.MenuPpal.AutoSize = False
        Me.MenuPpal.BackColor = System.Drawing.Color.White
        Me.MenuPpal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuPpal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPpal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTROToolStripMenuItem, Me.INGRESOToolStripMenuItem})
        Me.MenuPpal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPpal.Name = "MenuPpal"
        Me.MenuPpal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuPpal.Size = New System.Drawing.Size(1031, 36)
        Me.MenuPpal.TabIndex = 5
        Me.MenuPpal.Text = "MenuStrip1"
        '
        'REGISTROToolStripMenuItem
        '
        Me.REGISTROToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenToolStripMenuItem})
        Me.REGISTROToolStripMenuItem.Name = "REGISTROToolStripMenuItem"
        Me.REGISTROToolStripMenuItem.Size = New System.Drawing.Size(104, 32)
        Me.REGISTROToolStripMenuItem.Text = "REGISTRO"
        '
        'OrdenToolStripMenuItem
        '
        Me.OrdenToolStripMenuItem.Name = "OrdenToolStripMenuItem"
        Me.OrdenToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.OrdenToolStripMenuItem.Text = "Orden"
        '
        'INGRESOToolStripMenuItem
        '
        Me.INGRESOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem})
        Me.INGRESOToolStripMenuItem.Name = "INGRESOToolStripMenuItem"
        Me.INGRESOToolStripMenuItem.Size = New System.Drawing.Size(94, 32)
        Me.INGRESOToolStripMenuItem.Text = "INGRESO"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 491)
        Me.Controls.Add(Me.tsp_Botones)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuPpal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frm_principal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tsp_Botones.ResumeLayout(False)
        Me.tsp_Botones.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuPpal.ResumeLayout(False)
        Me.MenuPpal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsp_Botones As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tss_fecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tss_usuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuPpal As System.Windows.Forms.MenuStrip
    Friend WithEvents REGISTROToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INGRESOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
