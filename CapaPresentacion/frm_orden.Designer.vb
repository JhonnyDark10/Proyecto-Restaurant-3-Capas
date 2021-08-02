<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orden))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_numero_caja = New System.Windows.Forms.ComboBox()
        Me.txt_e = New System.Windows.Forms.TextBox()
        Me.txt_estado_f = New System.Windows.Forms.TextBox()
        Me.gbo_egreso = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_egreso_e = New System.Windows.Forms.Button()
        Me.txt_desscripcion_e = New System.Windows.Forms.TextBox()
        Me.txt_monto_e = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo1 = New System.Windows.Forms.Button()
        Me.txt_monto_caja_ingreso = New System.Windows.Forms.TextBox()
        Me.txt_descripcion_ingreso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_ingreso_c = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.gbo_ordenllevar = New System.Windows.Forms.GroupBox()
        Me.btn_mesa19 = New System.Windows.Forms.Button()
        Me.btn_mesa20 = New System.Windows.Forms.Button()
        Me.btn_mesa17 = New System.Windows.Forms.Button()
        Me.btn_mesa18 = New System.Windows.Forms.Button()
        Me.gbo_ordenmesa = New System.Windows.Forms.GroupBox()
        Me.btn_mesa13 = New System.Windows.Forms.Button()
        Me.btn_mesa14 = New System.Windows.Forms.Button()
        Me.btn_mesa15 = New System.Windows.Forms.Button()
        Me.btn_mesa16 = New System.Windows.Forms.Button()
        Me.btn_mesa9 = New System.Windows.Forms.Button()
        Me.btn_mesa10 = New System.Windows.Forms.Button()
        Me.btn_mesa11 = New System.Windows.Forms.Button()
        Me.btn_mesa12 = New System.Windows.Forms.Button()
        Me.btn_mesa5 = New System.Windows.Forms.Button()
        Me.btn_mesa6 = New System.Windows.Forms.Button()
        Me.btn_mesa7 = New System.Windows.Forms.Button()
        Me.btn_mesa8 = New System.Windows.Forms.Button()
        Me.btn_mesa1 = New System.Windows.Forms.Button()
        Me.btn_mesa2 = New System.Windows.Forms.Button()
        Me.btn_mesa3 = New System.Windows.Forms.Button()
        Me.btn_mesa4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbo_egreso.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbo_ordenllevar.SuspendLayout()
        Me.gbo_ordenmesa.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(945, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Nº Caja"
        '
        'cbo_numero_caja
        '
        Me.cbo_numero_caja.FormattingEnabled = True
        Me.cbo_numero_caja.Location = New System.Drawing.Point(1009, 34)
        Me.cbo_numero_caja.Name = "cbo_numero_caja"
        Me.cbo_numero_caja.Size = New System.Drawing.Size(121, 21)
        Me.cbo_numero_caja.TabIndex = 77
        '
        'txt_e
        '
        Me.txt_e.Location = New System.Drawing.Point(617, 24)
        Me.txt_e.Name = "txt_e"
        Me.txt_e.Size = New System.Drawing.Size(100, 20)
        Me.txt_e.TabIndex = 76
        Me.txt_e.Visible = False
        '
        'txt_estado_f
        '
        Me.txt_estado_f.Location = New System.Drawing.Point(91, 12)
        Me.txt_estado_f.Name = "txt_estado_f"
        Me.txt_estado_f.Size = New System.Drawing.Size(100, 20)
        Me.txt_estado_f.TabIndex = 75
        Me.txt_estado_f.Visible = False
        '
        'gbo_egreso
        '
        Me.gbo_egreso.Controls.Add(Me.btn_nuevo2)
        Me.gbo_egreso.Controls.Add(Me.Label5)
        Me.gbo_egreso.Controls.Add(Me.Label6)
        Me.gbo_egreso.Controls.Add(Me.btn_egreso_e)
        Me.gbo_egreso.Controls.Add(Me.txt_desscripcion_e)
        Me.gbo_egreso.Controls.Add(Me.txt_monto_e)
        Me.gbo_egreso.Location = New System.Drawing.Point(936, 250)
        Me.gbo_egreso.Name = "gbo_egreso"
        Me.gbo_egreso.Size = New System.Drawing.Size(200, 145)
        Me.gbo_egreso.TabIndex = 74
        Me.gbo_egreso.TabStop = False
        Me.gbo_egreso.Text = "Egresos Caja"
        '
        'btn_nuevo2
        '
        Me.btn_nuevo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_nuevo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo2.Image = CType(resources.GetObject("btn_nuevo2.Image"), System.Drawing.Image)
        Me.btn_nuevo2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo2.Location = New System.Drawing.Point(21, 99)
        Me.btn_nuevo2.Name = "btn_nuevo2"
        Me.btn_nuevo2.Size = New System.Drawing.Size(37, 40)
        Me.btn_nuevo2.TabIndex = 67
        Me.btn_nuevo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Descripcion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Monto"
        '
        'btn_egreso_e
        '
        Me.btn_egreso_e.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_egreso_e.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_egreso_e.Image = CType(resources.GetObject("btn_egreso_e.Image"), System.Drawing.Image)
        Me.btn_egreso_e.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_egreso_e.Location = New System.Drawing.Point(82, 99)
        Me.btn_egreso_e.Name = "btn_egreso_e"
        Me.btn_egreso_e.Size = New System.Drawing.Size(84, 40)
        Me.btn_egreso_e.TabIndex = 7
        Me.btn_egreso_e.Text = "Egreso"
        Me.btn_egreso_e.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_egreso_e.UseVisualStyleBackColor = False
        '
        'txt_desscripcion_e
        '
        Me.txt_desscripcion_e.Location = New System.Drawing.Point(82, 52)
        Me.txt_desscripcion_e.Multiline = True
        Me.txt_desscripcion_e.Name = "txt_desscripcion_e"
        Me.txt_desscripcion_e.Size = New System.Drawing.Size(112, 41)
        Me.txt_desscripcion_e.TabIndex = 6
        '
        'txt_monto_e
        '
        Me.txt_monto_e.Location = New System.Drawing.Point(82, 26)
        Me.txt_monto_e.Name = "txt_monto_e"
        Me.txt_monto_e.Size = New System.Drawing.Size(66, 20)
        Me.txt_monto_e.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_nuevo1)
        Me.GroupBox2.Controls.Add(Me.txt_monto_caja_ingreso)
        Me.GroupBox2.Controls.Add(Me.txt_descripcion_ingreso)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_ingreso_c)
        Me.GroupBox2.Location = New System.Drawing.Point(936, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 183)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresos Caja"
        '
        'btn_nuevo1
        '
        Me.btn_nuevo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_nuevo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo1.Image = CType(resources.GetObject("btn_nuevo1.Image"), System.Drawing.Image)
        Me.btn_nuevo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo1.Location = New System.Drawing.Point(25, 117)
        Me.btn_nuevo1.Name = "btn_nuevo1"
        Me.btn_nuevo1.Size = New System.Drawing.Size(37, 40)
        Me.btn_nuevo1.TabIndex = 48
        Me.btn_nuevo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo1.UseVisualStyleBackColor = False
        '
        'txt_monto_caja_ingreso
        '
        Me.txt_monto_caja_ingreso.Location = New System.Drawing.Point(77, 41)
        Me.txt_monto_caja_ingreso.Name = "txt_monto_caja_ingreso"
        Me.txt_monto_caja_ingreso.Size = New System.Drawing.Size(66, 20)
        Me.txt_monto_caja_ingreso.TabIndex = 2
        '
        'txt_descripcion_ingreso
        '
        Me.txt_descripcion_ingreso.Location = New System.Drawing.Point(77, 70)
        Me.txt_descripcion_ingreso.Multiline = True
        Me.txt_descripcion_ingreso.Name = "txt_descripcion_ingreso"
        Me.txt_descripcion_ingreso.Size = New System.Drawing.Size(112, 41)
        Me.txt_descripcion_ingreso.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Monto"
        '
        'btn_ingreso_c
        '
        Me.btn_ingreso_c.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_ingreso_c.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ingreso_c.Image = CType(resources.GetObject("btn_ingreso_c.Image"), System.Drawing.Image)
        Me.btn_ingreso_c.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ingreso_c.Location = New System.Drawing.Point(77, 117)
        Me.btn_ingreso_c.Name = "btn_ingreso_c"
        Me.btn_ingreso_c.Size = New System.Drawing.Size(84, 40)
        Me.btn_ingreso_c.TabIndex = 4
        Me.btn_ingreso_c.Text = "Ingreso"
        Me.btn_ingreso_c.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ingreso_c.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Honeydew
        Me.GroupBox1.Controls.Add(Me.btn_volver)
        Me.GroupBox1.Location = New System.Drawing.Point(811, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 98)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'btn_volver
        '
        Me.btn_volver.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.ForeColor = System.Drawing.Color.Black
        Me.btn_volver.Image = CType(resources.GetObject("btn_volver.Image"), System.Drawing.Image)
        Me.btn_volver.Location = New System.Drawing.Point(18, 20)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(88, 64)
        Me.btn_volver.TabIndex = 8
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_volver.UseVisualStyleBackColor = False
        '
        'gbo_ordenllevar
        '
        Me.gbo_ordenllevar.BackColor = System.Drawing.Color.Honeydew
        Me.gbo_ordenllevar.Controls.Add(Me.btn_mesa19)
        Me.gbo_ordenllevar.Controls.Add(Me.btn_mesa20)
        Me.gbo_ordenllevar.Controls.Add(Me.btn_mesa17)
        Me.gbo_ordenllevar.Controls.Add(Me.btn_mesa18)
        Me.gbo_ordenllevar.Location = New System.Drawing.Point(14, 388)
        Me.gbo_ordenllevar.Name = "gbo_ordenllevar"
        Me.gbo_ordenllevar.Size = New System.Drawing.Size(782, 98)
        Me.gbo_ordenllevar.TabIndex = 71
        Me.gbo_ordenllevar.TabStop = False
        Me.gbo_ordenllevar.Text = "ORDEN LLEVAR"
        '
        'btn_mesa19
        '
        Me.btn_mesa19.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa19.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa19.Image = CType(resources.GetObject("btn_mesa19.Image"), System.Drawing.Image)
        Me.btn_mesa19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa19.Location = New System.Drawing.Point(485, 19)
        Me.btn_mesa19.Name = "btn_mesa19"
        Me.btn_mesa19.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa19.TabIndex = 48
        Me.btn_mesa19.Text = "      19"
        Me.btn_mesa19.UseVisualStyleBackColor = False
        '
        'btn_mesa20
        '
        Me.btn_mesa20.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa20.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa20.Image = CType(resources.GetObject("btn_mesa20.Image"), System.Drawing.Image)
        Me.btn_mesa20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa20.Location = New System.Drawing.Point(642, 19)
        Me.btn_mesa20.Name = "btn_mesa20"
        Me.btn_mesa20.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa20.TabIndex = 49
        Me.btn_mesa20.Text = "      20"
        Me.btn_mesa20.UseVisualStyleBackColor = False
        '
        'btn_mesa17
        '
        Me.btn_mesa17.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_mesa17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa17.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa17.ForeColor = System.Drawing.Color.Black
        Me.btn_mesa17.Image = CType(resources.GetObject("btn_mesa17.Image"), System.Drawing.Image)
        Me.btn_mesa17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa17.Location = New System.Drawing.Point(109, 19)
        Me.btn_mesa17.Name = "btn_mesa17"
        Me.btn_mesa17.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa17.TabIndex = 46
        Me.btn_mesa17.Text = "      17"
        Me.btn_mesa17.UseVisualStyleBackColor = False
        '
        'btn_mesa18
        '
        Me.btn_mesa18.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa18.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa18.Image = CType(resources.GetObject("btn_mesa18.Image"), System.Drawing.Image)
        Me.btn_mesa18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa18.Location = New System.Drawing.Point(303, 19)
        Me.btn_mesa18.Name = "btn_mesa18"
        Me.btn_mesa18.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa18.TabIndex = 47
        Me.btn_mesa18.Text = "      18"
        Me.btn_mesa18.UseVisualStyleBackColor = False
        '
        'gbo_ordenmesa
        '
        Me.gbo_ordenmesa.BackColor = System.Drawing.Color.Honeydew
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa13)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa14)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa15)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa16)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa9)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa10)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa11)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa12)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa5)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa6)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa7)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa8)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa1)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa2)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa3)
        Me.gbo_ordenmesa.Controls.Add(Me.btn_mesa4)
        Me.gbo_ordenmesa.Location = New System.Drawing.Point(14, 61)
        Me.gbo_ordenmesa.Name = "gbo_ordenmesa"
        Me.gbo_ordenmesa.Size = New System.Drawing.Size(911, 306)
        Me.gbo_ordenmesa.TabIndex = 70
        Me.gbo_ordenmesa.TabStop = False
        Me.gbo_ordenmesa.Text = "ORDEN MESA"
        '
        'btn_mesa13
        '
        Me.btn_mesa13.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_mesa13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa13.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa13.ForeColor = System.Drawing.Color.Black
        Me.btn_mesa13.Image = CType(resources.GetObject("btn_mesa13.Image"), System.Drawing.Image)
        Me.btn_mesa13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa13.Location = New System.Drawing.Point(109, 230)
        Me.btn_mesa13.Name = "btn_mesa13"
        Me.btn_mesa13.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa13.TabIndex = 44
        Me.btn_mesa13.Text = "      13"
        Me.btn_mesa13.UseVisualStyleBackColor = False
        '
        'btn_mesa14
        '
        Me.btn_mesa14.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa14.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa14.Image = CType(resources.GetObject("btn_mesa14.Image"), System.Drawing.Image)
        Me.btn_mesa14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa14.Location = New System.Drawing.Point(303, 230)
        Me.btn_mesa14.Name = "btn_mesa14"
        Me.btn_mesa14.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa14.TabIndex = 45
        Me.btn_mesa14.Text = "      14"
        Me.btn_mesa14.UseVisualStyleBackColor = False
        '
        'btn_mesa15
        '
        Me.btn_mesa15.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa15.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa15.Image = CType(resources.GetObject("btn_mesa15.Image"), System.Drawing.Image)
        Me.btn_mesa15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa15.Location = New System.Drawing.Point(485, 230)
        Me.btn_mesa15.Name = "btn_mesa15"
        Me.btn_mesa15.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa15.TabIndex = 46
        Me.btn_mesa15.Text = "      15"
        Me.btn_mesa15.UseVisualStyleBackColor = False
        '
        'btn_mesa16
        '
        Me.btn_mesa16.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa16.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa16.Image = CType(resources.GetObject("btn_mesa16.Image"), System.Drawing.Image)
        Me.btn_mesa16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa16.Location = New System.Drawing.Point(642, 230)
        Me.btn_mesa16.Name = "btn_mesa16"
        Me.btn_mesa16.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa16.TabIndex = 47
        Me.btn_mesa16.Text = "      16"
        Me.btn_mesa16.UseVisualStyleBackColor = False
        '
        'btn_mesa9
        '
        Me.btn_mesa9.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_mesa9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa9.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa9.ForeColor = System.Drawing.Color.Black
        Me.btn_mesa9.Image = CType(resources.GetObject("btn_mesa9.Image"), System.Drawing.Image)
        Me.btn_mesa9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa9.Location = New System.Drawing.Point(109, 161)
        Me.btn_mesa9.Name = "btn_mesa9"
        Me.btn_mesa9.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa9.TabIndex = 40
        Me.btn_mesa9.Text = "      9"
        Me.btn_mesa9.UseVisualStyleBackColor = False
        '
        'btn_mesa10
        '
        Me.btn_mesa10.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa10.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa10.Image = CType(resources.GetObject("btn_mesa10.Image"), System.Drawing.Image)
        Me.btn_mesa10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa10.Location = New System.Drawing.Point(303, 161)
        Me.btn_mesa10.Name = "btn_mesa10"
        Me.btn_mesa10.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa10.TabIndex = 41
        Me.btn_mesa10.Text = "      10"
        Me.btn_mesa10.UseVisualStyleBackColor = False
        '
        'btn_mesa11
        '
        Me.btn_mesa11.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa11.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa11.Image = CType(resources.GetObject("btn_mesa11.Image"), System.Drawing.Image)
        Me.btn_mesa11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa11.Location = New System.Drawing.Point(485, 161)
        Me.btn_mesa11.Name = "btn_mesa11"
        Me.btn_mesa11.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa11.TabIndex = 42
        Me.btn_mesa11.Text = "      11"
        Me.btn_mesa11.UseVisualStyleBackColor = False
        '
        'btn_mesa12
        '
        Me.btn_mesa12.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa12.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa12.Image = CType(resources.GetObject("btn_mesa12.Image"), System.Drawing.Image)
        Me.btn_mesa12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa12.Location = New System.Drawing.Point(642, 161)
        Me.btn_mesa12.Name = "btn_mesa12"
        Me.btn_mesa12.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa12.TabIndex = 43
        Me.btn_mesa12.Text = "      12"
        Me.btn_mesa12.UseVisualStyleBackColor = False
        '
        'btn_mesa5
        '
        Me.btn_mesa5.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_mesa5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa5.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa5.ForeColor = System.Drawing.Color.Black
        Me.btn_mesa5.Image = CType(resources.GetObject("btn_mesa5.Image"), System.Drawing.Image)
        Me.btn_mesa5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa5.Location = New System.Drawing.Point(109, 92)
        Me.btn_mesa5.Name = "btn_mesa5"
        Me.btn_mesa5.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa5.TabIndex = 36
        Me.btn_mesa5.Text = "      5"
        Me.btn_mesa5.UseVisualStyleBackColor = False
        '
        'btn_mesa6
        '
        Me.btn_mesa6.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa6.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa6.Image = CType(resources.GetObject("btn_mesa6.Image"), System.Drawing.Image)
        Me.btn_mesa6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa6.Location = New System.Drawing.Point(303, 92)
        Me.btn_mesa6.Name = "btn_mesa6"
        Me.btn_mesa6.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa6.TabIndex = 37
        Me.btn_mesa6.Text = "      6"
        Me.btn_mesa6.UseVisualStyleBackColor = False
        '
        'btn_mesa7
        '
        Me.btn_mesa7.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa7.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa7.Image = CType(resources.GetObject("btn_mesa7.Image"), System.Drawing.Image)
        Me.btn_mesa7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa7.Location = New System.Drawing.Point(485, 92)
        Me.btn_mesa7.Name = "btn_mesa7"
        Me.btn_mesa7.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa7.TabIndex = 38
        Me.btn_mesa7.Text = "      7"
        Me.btn_mesa7.UseVisualStyleBackColor = False
        '
        'btn_mesa8
        '
        Me.btn_mesa8.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa8.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa8.Image = CType(resources.GetObject("btn_mesa8.Image"), System.Drawing.Image)
        Me.btn_mesa8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa8.Location = New System.Drawing.Point(642, 92)
        Me.btn_mesa8.Name = "btn_mesa8"
        Me.btn_mesa8.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa8.TabIndex = 39
        Me.btn_mesa8.Text = "      8"
        Me.btn_mesa8.UseVisualStyleBackColor = False
        '
        'btn_mesa1
        '
        Me.btn_mesa1.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_mesa1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa1.ForeColor = System.Drawing.Color.Black
        Me.btn_mesa1.Image = CType(resources.GetObject("btn_mesa1.Image"), System.Drawing.Image)
        Me.btn_mesa1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa1.Location = New System.Drawing.Point(109, 23)
        Me.btn_mesa1.Name = "btn_mesa1"
        Me.btn_mesa1.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa1.TabIndex = 32
        Me.btn_mesa1.Text = "      1"
        Me.btn_mesa1.UseVisualStyleBackColor = False
        '
        'btn_mesa2
        '
        Me.btn_mesa2.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa2.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa2.Image = CType(resources.GetObject("btn_mesa2.Image"), System.Drawing.Image)
        Me.btn_mesa2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa2.Location = New System.Drawing.Point(303, 23)
        Me.btn_mesa2.Name = "btn_mesa2"
        Me.btn_mesa2.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa2.TabIndex = 33
        Me.btn_mesa2.Text = "      2"
        Me.btn_mesa2.UseVisualStyleBackColor = False
        '
        'btn_mesa3
        '
        Me.btn_mesa3.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa3.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa3.Image = CType(resources.GetObject("btn_mesa3.Image"), System.Drawing.Image)
        Me.btn_mesa3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa3.Location = New System.Drawing.Point(485, 23)
        Me.btn_mesa3.Name = "btn_mesa3"
        Me.btn_mesa3.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa3.TabIndex = 34
        Me.btn_mesa3.Text = "      3"
        Me.btn_mesa3.UseVisualStyleBackColor = False
        '
        'btn_mesa4
        '
        Me.btn_mesa4.BackColor = System.Drawing.Color.Lime
        Me.btn_mesa4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mesa4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mesa4.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mesa4.Image = CType(resources.GetObject("btn_mesa4.Image"), System.Drawing.Image)
        Me.btn_mesa4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_mesa4.Location = New System.Drawing.Point(642, 23)
        Me.btn_mesa4.Name = "btn_mesa4"
        Me.btn_mesa4.Size = New System.Drawing.Size(125, 63)
        Me.btn_mesa4.TabIndex = 35
        Me.btn_mesa4.Text = "      4"
        Me.btn_mesa4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(349, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 19)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "MESAS RESTAURANT"
        '
        'frm_orden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1148, 512)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_numero_caja)
        Me.Controls.Add(Me.txt_e)
        Me.Controls.Add(Me.txt_estado_f)
        Me.Controls.Add(Me.gbo_egreso)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_ordenllevar)
        Me.Controls.Add(Me.gbo_ordenmesa)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_orden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden"
        Me.gbo_egreso.ResumeLayout(False)
        Me.gbo_egreso.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbo_ordenllevar.ResumeLayout(False)
        Me.gbo_ordenmesa.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_numero_caja As System.Windows.Forms.ComboBox
    Friend WithEvents txt_e As System.Windows.Forms.TextBox
    Friend WithEvents txt_estado_f As System.Windows.Forms.TextBox
    Friend WithEvents gbo_egreso As System.Windows.Forms.GroupBox
    Friend WithEvents btn_nuevo2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_egreso_e As System.Windows.Forms.Button
    Friend WithEvents txt_desscripcion_e As System.Windows.Forms.TextBox
    Friend WithEvents txt_monto_e As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_nuevo1 As System.Windows.Forms.Button
    Friend WithEvents txt_monto_caja_ingreso As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion_ingreso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_ingreso_c As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents gbo_ordenllevar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mesa19 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa20 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa17 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa18 As System.Windows.Forms.Button
    Friend WithEvents gbo_ordenmesa As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mesa13 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa14 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa15 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa16 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa9 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa10 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa11 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa12 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa5 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa6 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa7 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa8 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa1 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa2 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa3 As System.Windows.Forms.Button
    Friend WithEvents btn_mesa4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
