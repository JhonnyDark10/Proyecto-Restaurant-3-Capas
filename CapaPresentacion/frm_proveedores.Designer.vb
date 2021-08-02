<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_proveedores))
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Botones = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_volver_cliente = New System.Windows.Forms.Button()
        Me.btn_guardar_cliente = New System.Windows.Forms.Button()
        Me.gbo_proveedores = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cedula_proveedor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_telefono_proveedores = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_apellido2_proveedores = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre_proveedores = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email_proveedores = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_direccion_proveedores = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellidos_proveedores = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Botones.SuspendLayout()
        Me.gbo_proveedores.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_estado.Location = New System.Drawing.Point(364, 34)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(65, 17)
        Me.chk_estado.TabIndex = 51
        Me.chk_estado.Text = "Estado"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 41)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 13)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Código:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(69, 34)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(70, 20)
        Me.txt_codigo.TabIndex = 49
        '
        'Botones
        '
        Me.Botones.Controls.Add(Me.Button1)
        Me.Botones.Controls.Add(Me.btn_volver_cliente)
        Me.Botones.Controls.Add(Me.btn_guardar_cliente)
        Me.Botones.Location = New System.Drawing.Point(11, 394)
        Me.Botones.Name = "Botones"
        Me.Botones.Size = New System.Drawing.Size(418, 92)
        Me.Botones.TabIndex = 48
        Me.Botones.TabStop = False
        Me.Botones.Text = "Botones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(110, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 64)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Limpiar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_volver_cliente
        '
        Me.btn_volver_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_volver_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_cliente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_cliente.ForeColor = System.Drawing.Color.Black
        Me.btn_volver_cliente.Image = CType(resources.GetObject("btn_volver_cliente.Image"), System.Drawing.Image)
        Me.btn_volver_cliente.Location = New System.Drawing.Point(313, 19)
        Me.btn_volver_cliente.Name = "btn_volver_cliente"
        Me.btn_volver_cliente.Size = New System.Drawing.Size(88, 64)
        Me.btn_volver_cliente.TabIndex = 9
        Me.btn_volver_cliente.Text = "Volver"
        Me.btn_volver_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_volver_cliente.UseVisualStyleBackColor = False
        '
        'btn_guardar_cliente
        '
        Me.btn_guardar_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_guardar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_guardar_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_cliente.ForeColor = System.Drawing.Color.Black
        Me.btn_guardar_cliente.Image = CType(resources.GetObject("btn_guardar_cliente.Image"), System.Drawing.Image)
        Me.btn_guardar_cliente.Location = New System.Drawing.Point(210, 19)
        Me.btn_guardar_cliente.Name = "btn_guardar_cliente"
        Me.btn_guardar_cliente.Size = New System.Drawing.Size(88, 64)
        Me.btn_guardar_cliente.TabIndex = 8
        Me.btn_guardar_cliente.Text = "Grabar"
        Me.btn_guardar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar_cliente.UseVisualStyleBackColor = False
        '
        'gbo_proveedores
        '
        Me.gbo_proveedores.Controls.Add(Me.Label15)
        Me.gbo_proveedores.Controls.Add(Me.Label13)
        Me.gbo_proveedores.Controls.Add(Me.txt_cedula_proveedor)
        Me.gbo_proveedores.Controls.Add(Me.Label14)
        Me.gbo_proveedores.Controls.Add(Me.txt_telefono_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label12)
        Me.gbo_proveedores.Controls.Add(Me.txt_apellido2_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label7)
        Me.gbo_proveedores.Controls.Add(Me.Label9)
        Me.gbo_proveedores.Controls.Add(Me.Label8)
        Me.gbo_proveedores.Controls.Add(Me.Label6)
        Me.gbo_proveedores.Controls.Add(Me.txt_nombre_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label1)
        Me.gbo_proveedores.Controls.Add(Me.Label2)
        Me.gbo_proveedores.Controls.Add(Me.txt_email_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label4)
        Me.gbo_proveedores.Controls.Add(Me.txt_direccion_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label5)
        Me.gbo_proveedores.Controls.Add(Me.txt_apellidos_proveedores)
        Me.gbo_proveedores.Location = New System.Drawing.Point(12, 69)
        Me.gbo_proveedores.Name = "gbo_proveedores"
        Me.gbo_proveedores.Size = New System.Drawing.Size(417, 322)
        Me.gbo_proveedores.TabIndex = 47
        Me.gbo_proveedores.TabStop = False
        Me.gbo_proveedores.Text = "Datos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(366, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(366, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "*"
        '
        'txt_cedula_proveedor
        '
        Me.txt_cedula_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cedula_proveedor.Location = New System.Drawing.Point(141, 31)
        Me.txt_cedula_proveedor.MaxLength = 10
        Me.txt_cedula_proveedor.Name = "txt_cedula_proveedor"
        Me.txt_cedula_proveedor.Size = New System.Drawing.Size(219, 20)
        Me.txt_cedula_proveedor.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(33, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 19)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Cedula"
        '
        'txt_telefono_proveedores
        '
        Me.txt_telefono_proveedores.Location = New System.Drawing.Point(141, 282)
        Me.txt_telefono_proveedores.MaxLength = 10
        Me.txt_telefono_proveedores.Name = "txt_telefono_proveedores"
        Me.txt_telefono_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_telefono_proveedores.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(43, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Telefono"
        '
        'txt_apellido2_proveedores
        '
        Me.txt_apellido2_proveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido2_proveedores.Location = New System.Drawing.Point(141, 157)
        Me.txt_apellido2_proveedores.MaxLength = 20
        Me.txt_apellido2_proveedores.Name = "txt_apellido2_proveedores"
        Me.txt_apellido2_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_apellido2_proveedores.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Apellido Materno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(366, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(366, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(366, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "*"
        '
        'txt_nombre_proveedores
        '
        Me.txt_nombre_proveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_proveedores.Location = New System.Drawing.Point(141, 73)
        Me.txt_nombre_proveedores.MaxLength = 20
        Me.txt_nombre_proveedores.Name = "txt_nombre_proveedores"
        Me.txt_nombre_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_nombre_proveedores.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellido Paterno"
        '
        'txt_email_proveedores
        '
        Me.txt_email_proveedores.Location = New System.Drawing.Point(141, 245)
        Me.txt_email_proveedores.MaxLength = 20
        Me.txt_email_proveedores.Name = "txt_email_proveedores"
        Me.txt_email_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_email_proveedores.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Direccion"
        '
        'txt_direccion_proveedores
        '
        Me.txt_direccion_proveedores.Location = New System.Drawing.Point(141, 202)
        Me.txt_direccion_proveedores.MaxLength = 20
        Me.txt_direccion_proveedores.Name = "txt_direccion_proveedores"
        Me.txt_direccion_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_direccion_proveedores.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email"
        '
        'txt_apellidos_proveedores
        '
        Me.txt_apellidos_proveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos_proveedores.Location = New System.Drawing.Point(141, 113)
        Me.txt_apellidos_proveedores.MaxLength = 20
        Me.txt_apellidos_proveedores.Name = "txt_apellidos_proveedores"
        Me.txt_apellidos_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_apellidos_proveedores.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(148, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 28)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "REGISTRO"
        '
        'frm_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(445, 493)
        Me.Controls.Add(Me.chk_estado)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Botones)
        Me.Controls.Add(Me.gbo_proveedores)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.Botones.ResumeLayout(False)
        Me.gbo_proveedores.ResumeLayout(False)
        Me.gbo_proveedores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_estado As System.Windows.Forms.CheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_volver_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_guardar_cliente As System.Windows.Forms.Button
    Friend WithEvents gbo_proveedores As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido2_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_email_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_apellidos_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
