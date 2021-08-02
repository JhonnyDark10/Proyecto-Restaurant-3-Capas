<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orden_registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orden_registro))
        Me.txt_caja = New System.Windows.Forms.TextBox()
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_usuario_empleado = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txt_total_p_f = New System.Windows.Forms.TextBox()
        Me.txt_iva_f = New System.Windows.Forms.TextBox()
        Me.txt_descuento_f = New System.Windows.Forms.TextBox()
        Me.txt_subtotal_f = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_s = New System.Windows.Forms.TextBox()
        Me.OpcionOrden = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_añadir_producto_o = New System.Windows.Forms.Button()
        Me.btn_buscar_producto = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_cantp = New System.Windows.Forms.TextBox()
        Me.txt_Descripción = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_anular = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_volver_cliente = New System.Windows.Forms.Button()
        Me.btn_nuevo_cliente = New System.Windows.Forms.Button()
        Me.btn_guardar_cliente = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_numero_c_f = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_habilita_botones = New System.Windows.Forms.Button()
        Me.msk_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_numero_pedido_o = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_bebidas_orden = New System.Windows.Forms.DataGridView()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_entrada_o = New System.Windows.Forms.Button()
        Me.btn_segundo_o = New System.Windows.Forms.Button()
        Me.btn_bebidas_o = New System.Windows.Forms.Button()
        Me.btn_postres_o = New System.Windows.Forms.Button()
        Me.btn_primero_o = New System.Windows.Forms.Button()
        Me.gbo_datos_cliente = New System.Windows.Forms.GroupBox()
        Me.gbo_cliente_f = New System.Windows.Forms.GroupBox()
        Me.txt_codigo_cliente = New System.Windows.Forms.TextBox()
        Me.chk_consumidorfinal = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_tipo_cliente_fact = New System.Windows.Forms.TextBox()
        Me.lbl_apellido_c_f = New System.Windows.Forms.Label()
        Me.lbl_nombre_c_f = New System.Windows.Forms.Label()
        Me.lbl_cedula_c_f = New System.Windows.Forms.Label()
        Me.lbl_telefono_c_f = New System.Windows.Forms.Label()
        Me.lbl_direccion_c_f = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_cedula_busca_f = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btn_nuevo_cliente_f = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_tiempo_e = New System.Windows.Forms.TextBox()
        Me.txt_hora_pedido_o = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_tipo_orden_o = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_numero_mesa_o = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dg_orden_d = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_u = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_producto_v = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Opcion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.OpcionOrden.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_bebidas_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbo_datos_cliente.SuspendLayout()
        Me.gbo_cliente_f.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_orden_d, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_caja
        '
        Me.txt_caja.Location = New System.Drawing.Point(620, 68)
        Me.txt_caja.Name = "txt_caja"
        Me.txt_caja.Size = New System.Drawing.Size(100, 20)
        Me.txt_caja.TabIndex = 124
        Me.txt_caja.Visible = False
        '
        'txt_1
        '
        Me.txt_1.Location = New System.Drawing.Point(620, 43)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(100, 20)
        Me.txt_1.TabIndex = 123
        Me.txt_1.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(-5, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1181, 25)
        Me.Label3.TabIndex = 122
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(980, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 19)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "CAJERO"
        '
        'txt_usuario_empleado
        '
        Me.txt_usuario_empleado.Location = New System.Drawing.Point(1067, 28)
        Me.txt_usuario_empleado.Name = "txt_usuario_empleado"
        Me.txt_usuario_empleado.ReadOnly = True
        Me.txt_usuario_empleado.Size = New System.Drawing.Size(93, 20)
        Me.txt_usuario_empleado.TabIndex = 120
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txt_total_p_f)
        Me.GroupBox8.Controls.Add(Me.txt_iva_f)
        Me.GroupBox8.Controls.Add(Me.txt_descuento_f)
        Me.GroupBox8.Controls.Add(Me.txt_subtotal_f)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Location = New System.Drawing.Point(606, 400)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(214, 185)
        Me.GroupBox8.TabIndex = 119
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Desgloce Pago"
        '
        'txt_total_p_f
        '
        Me.txt_total_p_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_p_f.Location = New System.Drawing.Point(105, 134)
        Me.txt_total_p_f.Name = "txt_total_p_f"
        Me.txt_total_p_f.ReadOnly = True
        Me.txt_total_p_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_total_p_f.TabIndex = 95
        '
        'txt_iva_f
        '
        Me.txt_iva_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iva_f.Location = New System.Drawing.Point(105, 97)
        Me.txt_iva_f.Name = "txt_iva_f"
        Me.txt_iva_f.ReadOnly = True
        Me.txt_iva_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_iva_f.TabIndex = 94
        '
        'txt_descuento_f
        '
        Me.txt_descuento_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descuento_f.Location = New System.Drawing.Point(105, 59)
        Me.txt_descuento_f.Name = "txt_descuento_f"
        Me.txt_descuento_f.ReadOnly = True
        Me.txt_descuento_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_descuento_f.TabIndex = 92
        '
        'txt_subtotal_f
        '
        Me.txt_subtotal_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal_f.Location = New System.Drawing.Point(105, 23)
        Me.txt_subtotal_f.Name = "txt_subtotal_f"
        Me.txt_subtotal_f.ReadOnly = True
        Me.txt_subtotal_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_subtotal_f.TabIndex = 91
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 19)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Subtotal"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(8, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 19)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Descuento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(15, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 19)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "IVA 14%"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 19)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "Total a Pagar"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_s)
        Me.GroupBox6.Controls.Add(Me.OpcionOrden)
        Me.GroupBox6.Controls.Add(Me.btn_buscar_producto)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txt_codigo)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txt_cantp)
        Me.GroupBox6.Controls.Add(Me.txt_Descripción)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.txt_precio)
        Me.GroupBox6.Location = New System.Drawing.Point(606, 89)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(214, 308)
        Me.GroupBox6.TabIndex = 118
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Productos"
        '
        'txt_s
        '
        Me.txt_s.Location = New System.Drawing.Point(108, 140)
        Me.txt_s.Name = "txt_s"
        Me.txt_s.Size = New System.Drawing.Size(54, 20)
        Me.txt_s.TabIndex = 75
        Me.txt_s.Visible = False
        '
        'OpcionOrden
        '
        Me.OpcionOrden.Controls.Add(Me.btn_eliminar)
        Me.OpcionOrden.Controls.Add(Me.btn_añadir_producto_o)
        Me.OpcionOrden.Location = New System.Drawing.Point(24, 181)
        Me.OpcionOrden.Name = "OpcionOrden"
        Me.OpcionOrden.Size = New System.Drawing.Size(174, 118)
        Me.OpcionOrden.TabIndex = 74
        Me.OpcionOrden.TabStop = False
        Me.OpcionOrden.Text = "Opcion Orden"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(27, 72)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(127, 36)
        Me.btn_eliminar.TabIndex = 73
        Me.btn_eliminar.Text = "      ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_añadir_producto_o
        '
        Me.btn_añadir_producto_o.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_añadir_producto_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_añadir_producto_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir_producto_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_añadir_producto_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_producto_o.Image = CType(resources.GetObject("btn_añadir_producto_o.Image"), System.Drawing.Image)
        Me.btn_añadir_producto_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_añadir_producto_o.Location = New System.Drawing.Point(26, 24)
        Me.btn_añadir_producto_o.Name = "btn_añadir_producto_o"
        Me.btn_añadir_producto_o.Size = New System.Drawing.Size(128, 36)
        Me.btn_añadir_producto_o.TabIndex = 58
        Me.btn_añadir_producto_o.Text = "       AÑADIR"
        Me.btn_añadir_producto_o.UseVisualStyleBackColor = False
        '
        'btn_buscar_producto
        '
        Me.btn_buscar_producto.Image = CType(resources.GetObject("btn_buscar_producto.Image"), System.Drawing.Image)
        Me.btn_buscar_producto.Location = New System.Drawing.Point(168, 19)
        Me.btn_buscar_producto.Name = "btn_buscar_producto"
        Me.btn_buscar_producto.Size = New System.Drawing.Size(40, 30)
        Me.btn_buscar_producto.TabIndex = 72
        Me.btn_buscar_producto.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(11, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 15)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Codigo "
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(108, 27)
        Me.txt_codigo.MaxLength = 10
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(54, 20)
        Me.txt_codigo.TabIndex = 59
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(36, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 15)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Cantidad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 15)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Descripción:"
        '
        'txt_cantp
        '
        Me.txt_cantp.Location = New System.Drawing.Point(108, 109)
        Me.txt_cantp.MaxLength = 5
        Me.txt_cantp.Name = "txt_cantp"
        Me.txt_cantp.Size = New System.Drawing.Size(54, 20)
        Me.txt_cantp.TabIndex = 10
        '
        'txt_Descripción
        '
        Me.txt_Descripción.Location = New System.Drawing.Point(108, 53)
        Me.txt_Descripción.Name = "txt_Descripción"
        Me.txt_Descripción.ReadOnly = True
        Me.txt_Descripción.Size = New System.Drawing.Size(100, 20)
        Me.txt_Descripción.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(59, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Precio"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(108, 81)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.ReadOnly = True
        Me.txt_precio.Size = New System.Drawing.Size(54, 20)
        Me.txt_precio.TabIndex = 27
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_anular)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.btn_volver_cliente)
        Me.GroupBox5.Controls.Add(Me.btn_nuevo_cliente)
        Me.GroupBox5.Controls.Add(Me.btn_guardar_cliente)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 210)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(120, 375)
        Me.GroupBox5.TabIndex = 117
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Botones"
        '
        'btn_anular
        '
        Me.btn_anular.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_anular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_anular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_anular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anular.ForeColor = System.Drawing.Color.Black
        Me.btn_anular.Image = CType(resources.GetObject("btn_anular.Image"), System.Drawing.Image)
        Me.btn_anular.Location = New System.Drawing.Point(16, 86)
        Me.btn_anular.Name = "btn_anular"
        Me.btn_anular.Size = New System.Drawing.Size(88, 64)
        Me.btn_anular.TabIndex = 23
        Me.btn_anular.Text = "Anular Pedido"
        Me.btn_anular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_anular.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(16, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 64)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Cancelar"
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
        Me.btn_volver_cliente.Location = New System.Drawing.Point(18, 302)
        Me.btn_volver_cliente.Name = "btn_volver_cliente"
        Me.btn_volver_cliente.Size = New System.Drawing.Size(88, 64)
        Me.btn_volver_cliente.TabIndex = 21
        Me.btn_volver_cliente.Text = "Volver"
        Me.btn_volver_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_volver_cliente.UseVisualStyleBackColor = False
        '
        'btn_nuevo_cliente
        '
        Me.btn_nuevo_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_nuevo_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_cliente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_nuevo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_cliente.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo_cliente.Image = CType(resources.GetObject("btn_nuevo_cliente.Image"), System.Drawing.Image)
        Me.btn_nuevo_cliente.Location = New System.Drawing.Point(18, 229)
        Me.btn_nuevo_cliente.Name = "btn_nuevo_cliente"
        Me.btn_nuevo_cliente.Size = New System.Drawing.Size(88, 64)
        Me.btn_nuevo_cliente.TabIndex = 19
        Me.btn_nuevo_cliente.Text = "Limpiar"
        Me.btn_nuevo_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo_cliente.UseVisualStyleBackColor = False
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
        Me.btn_guardar_cliente.Location = New System.Drawing.Point(16, 15)
        Me.btn_guardar_cliente.Name = "btn_guardar_cliente"
        Me.btn_guardar_cliente.Size = New System.Drawing.Size(88, 64)
        Me.btn_guardar_cliente.TabIndex = 20
        Me.btn_guardar_cliente.Text = "Pedir"
        Me.btn_guardar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar_cliente.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_numero_c_f)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.btn_habilita_botones)
        Me.GroupBox4.Controls.Add(Me.msk_fecha)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txt_numero_pedido_o)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(119, 176)
        Me.GroupBox4.TabIndex = 116
        Me.GroupBox4.TabStop = False
        '
        'txt_numero_c_f
        '
        Me.txt_numero_c_f.Location = New System.Drawing.Point(2, 43)
        Me.txt_numero_c_f.Name = "txt_numero_c_f"
        Me.txt_numero_c_f.Size = New System.Drawing.Size(67, 20)
        Me.txt_numero_c_f.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(100, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "*"
        '
        'btn_habilita_botones
        '
        Me.btn_habilita_botones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_habilita_botones.Image = CType(resources.GetObject("btn_habilita_botones.Image"), System.Drawing.Image)
        Me.btn_habilita_botones.Location = New System.Drawing.Point(74, 44)
        Me.btn_habilita_botones.Name = "btn_habilita_botones"
        Me.btn_habilita_botones.Size = New System.Drawing.Size(20, 20)
        Me.btn_habilita_botones.TabIndex = 74
        Me.btn_habilita_botones.UseVisualStyleBackColor = True
        '
        'msk_fecha
        '
        Me.msk_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.msk_fecha.Location = New System.Drawing.Point(1, 106)
        Me.msk_fecha.Name = "msk_fecha"
        Me.msk_fecha.Size = New System.Drawing.Size(93, 20)
        Me.msk_fecha.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(100, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Nº Factura"
        '
        'txt_numero_pedido_o
        '
        Me.txt_numero_pedido_o.Location = New System.Drawing.Point(27, 143)
        Me.txt_numero_pedido_o.Name = "txt_numero_pedido_o"
        Me.txt_numero_pedido_o.Size = New System.Drawing.Size(67, 20)
        Me.txt_numero_pedido_o.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Fecha Pedido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg_bebidas_orden)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(826, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 537)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escoger Tipo"
        '
        'dg_bebidas_orden
        '
        Me.dg_bebidas_orden.AllowUserToAddRows = False
        Me.dg_bebidas_orden.AllowUserToDeleteRows = False
        Me.dg_bebidas_orden.AllowUserToResizeColumns = False
        Me.dg_bebidas_orden.AllowUserToResizeRows = False
        Me.dg_bebidas_orden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_bebidas_orden.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_bebidas_orden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_bebidas_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_bebidas_orden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Foto, Me.Nombre, Me.Stock, Me.Codigo})
        Me.dg_bebidas_orden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_bebidas_orden.Location = New System.Drawing.Point(14, 140)
        Me.dg_bebidas_orden.Name = "dg_bebidas_orden"
        Me.dg_bebidas_orden.ShowCellErrors = False
        Me.dg_bebidas_orden.ShowEditingIcon = False
        Me.dg_bebidas_orden.ShowRowErrors = False
        Me.dg_bebidas_orden.Size = New System.Drawing.Size(313, 390)
        Me.dg_bebidas_orden.TabIndex = 59
        '
        'Foto
        '
        Me.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Foto.FillWeight = 112.0!
        Me.Foto.HeaderText = "Foto"
        Me.Foto.MinimumWidth = 10
        Me.Foto.Name = "Foto"
        Me.Foto.Width = 127
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 63.23469!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Stock
        '
        Me.Stock.FillWeight = 63.23469!
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_entrada_o)
        Me.GroupBox2.Controls.Add(Me.btn_segundo_o)
        Me.GroupBox2.Controls.Add(Me.btn_bebidas_o)
        Me.GroupBox2.Controls.Add(Me.btn_postres_o)
        Me.GroupBox2.Controls.Add(Me.btn_primero_o)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 111)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'btn_entrada_o
        '
        Me.btn_entrada_o.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_entrada_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_entrada_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrada_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_entrada_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrada_o.ForeColor = System.Drawing.Color.Black
        Me.btn_entrada_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_entrada_o.Location = New System.Drawing.Point(115, 77)
        Me.btn_entrada_o.Name = "btn_entrada_o"
        Me.btn_entrada_o.Size = New System.Drawing.Size(99, 27)
        Me.btn_entrada_o.TabIndex = 58
        Me.btn_entrada_o.Text = "ENTRADA"
        Me.btn_entrada_o.UseVisualStyleBackColor = False
        '
        'btn_segundo_o
        '
        Me.btn_segundo_o.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_segundo_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_segundo_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_segundo_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_segundo_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_segundo_o.ForeColor = System.Drawing.Color.Black
        Me.btn_segundo_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_segundo_o.Location = New System.Drawing.Point(189, 44)
        Me.btn_segundo_o.Name = "btn_segundo_o"
        Me.btn_segundo_o.Size = New System.Drawing.Size(99, 27)
        Me.btn_segundo_o.TabIndex = 57
        Me.btn_segundo_o.Text = "SEGUNDO"
        Me.btn_segundo_o.UseVisualStyleBackColor = False
        '
        'btn_bebidas_o
        '
        Me.btn_bebidas_o.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_bebidas_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_bebidas_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_bebidas_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_bebidas_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bebidas_o.ForeColor = System.Drawing.Color.Black
        Me.btn_bebidas_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bebidas_o.Location = New System.Drawing.Point(31, 15)
        Me.btn_bebidas_o.Name = "btn_bebidas_o"
        Me.btn_bebidas_o.Size = New System.Drawing.Size(108, 26)
        Me.btn_bebidas_o.TabIndex = 57
        Me.btn_bebidas_o.Text = "BEBIDAS"
        Me.btn_bebidas_o.UseVisualStyleBackColor = False
        '
        'btn_postres_o
        '
        Me.btn_postres_o.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_postres_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_postres_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_postres_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_postres_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_postres_o.ForeColor = System.Drawing.Color.Black
        Me.btn_postres_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_postres_o.Location = New System.Drawing.Point(189, 13)
        Me.btn_postres_o.Name = "btn_postres_o"
        Me.btn_postres_o.Size = New System.Drawing.Size(99, 26)
        Me.btn_postres_o.TabIndex = 57
        Me.btn_postres_o.Text = "POSTRES"
        Me.btn_postres_o.UseVisualStyleBackColor = False
        '
        'btn_primero_o
        '
        Me.btn_primero_o.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_primero_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_primero_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_primero_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_primero_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_primero_o.ForeColor = System.Drawing.Color.Black
        Me.btn_primero_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_primero_o.Location = New System.Drawing.Point(31, 47)
        Me.btn_primero_o.Name = "btn_primero_o"
        Me.btn_primero_o.Size = New System.Drawing.Size(108, 26)
        Me.btn_primero_o.TabIndex = 57
        Me.btn_primero_o.Text = "PRIMERO"
        Me.btn_primero_o.UseVisualStyleBackColor = False
        '
        'gbo_datos_cliente
        '
        Me.gbo_datos_cliente.Controls.Add(Me.gbo_cliente_f)
        Me.gbo_datos_cliente.Controls.Add(Me.GroupBox3)
        Me.gbo_datos_cliente.Controls.Add(Me.dg_orden_d)
        Me.gbo_datos_cliente.Location = New System.Drawing.Point(136, 28)
        Me.gbo_datos_cliente.Name = "gbo_datos_cliente"
        Me.gbo_datos_cliente.Size = New System.Drawing.Size(459, 557)
        Me.gbo_datos_cliente.TabIndex = 114
        Me.gbo_datos_cliente.TabStop = False
        Me.gbo_datos_cliente.Text = "Lista Orden"
        '
        'gbo_cliente_f
        '
        Me.gbo_cliente_f.Controls.Add(Me.txt_codigo_cliente)
        Me.gbo_cliente_f.Controls.Add(Me.chk_consumidorfinal)
        Me.gbo_cliente_f.Controls.Add(Me.Button2)
        Me.gbo_cliente_f.Controls.Add(Me.txt_tipo_cliente_fact)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_apellido_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_nombre_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_cedula_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_telefono_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_direccion_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.Label22)
        Me.gbo_cliente_f.Controls.Add(Me.Label23)
        Me.gbo_cliente_f.Controls.Add(Me.Label24)
        Me.gbo_cliente_f.Controls.Add(Me.Label25)
        Me.gbo_cliente_f.Controls.Add(Me.Label26)
        Me.gbo_cliente_f.Controls.Add(Me.txt_cedula_busca_f)
        Me.gbo_cliente_f.Controls.Add(Me.Label27)
        Me.gbo_cliente_f.Controls.Add(Me.btn_nuevo_cliente_f)
        Me.gbo_cliente_f.Controls.Add(Me.Label28)
        Me.gbo_cliente_f.Location = New System.Drawing.Point(11, 15)
        Me.gbo_cliente_f.Name = "gbo_cliente_f"
        Me.gbo_cliente_f.Size = New System.Drawing.Size(430, 139)
        Me.gbo_cliente_f.TabIndex = 102
        Me.gbo_cliente_f.TabStop = False
        Me.gbo_cliente_f.Text = "Informacion Cliente"
        '
        'txt_codigo_cliente
        '
        Me.txt_codigo_cliente.Location = New System.Drawing.Point(132, 0)
        Me.txt_codigo_cliente.Name = "txt_codigo_cliente"
        Me.txt_codigo_cliente.Size = New System.Drawing.Size(49, 20)
        Me.txt_codigo_cliente.TabIndex = 112
        Me.txt_codigo_cliente.Visible = False
        '
        'chk_consumidorfinal
        '
        Me.chk_consumidorfinal.AutoSize = True
        Me.chk_consumidorfinal.Location = New System.Drawing.Point(343, 109)
        Me.chk_consumidorfinal.Name = "chk_consumidorfinal"
        Me.chk_consumidorfinal.Size = New System.Drawing.Size(81, 17)
        Me.chk_consumidorfinal.TabIndex = 91
        Me.chk_consumidorfinal.Text = "Consumidor"
        Me.chk_consumidorfinal.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(263, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 30)
        Me.Button2.TabIndex = 90
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_tipo_cliente_fact
        '
        Me.txt_tipo_cliente_fact.Location = New System.Drawing.Point(317, 23)
        Me.txt_tipo_cliente_fact.Name = "txt_tipo_cliente_fact"
        Me.txt_tipo_cliente_fact.ReadOnly = True
        Me.txt_tipo_cliente_fact.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo_cliente_fact.TabIndex = 89
        '
        'lbl_apellido_c_f
        '
        Me.lbl_apellido_c_f.AutoSize = True
        Me.lbl_apellido_c_f.Location = New System.Drawing.Point(100, 115)
        Me.lbl_apellido_c_f.Name = "lbl_apellido_c_f"
        Me.lbl_apellido_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_apellido_c_f.TabIndex = 88
        '
        'lbl_nombre_c_f
        '
        Me.lbl_nombre_c_f.AutoSize = True
        Me.lbl_nombre_c_f.Location = New System.Drawing.Point(100, 87)
        Me.lbl_nombre_c_f.Name = "lbl_nombre_c_f"
        Me.lbl_nombre_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_nombre_c_f.TabIndex = 87
        '
        'lbl_cedula_c_f
        '
        Me.lbl_cedula_c_f.AutoSize = True
        Me.lbl_cedula_c_f.Location = New System.Drawing.Point(100, 58)
        Me.lbl_cedula_c_f.Name = "lbl_cedula_c_f"
        Me.lbl_cedula_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_cedula_c_f.TabIndex = 86
        '
        'lbl_telefono_c_f
        '
        Me.lbl_telefono_c_f.AutoSize = True
        Me.lbl_telefono_c_f.Location = New System.Drawing.Point(329, 87)
        Me.lbl_telefono_c_f.Name = "lbl_telefono_c_f"
        Me.lbl_telefono_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_telefono_c_f.TabIndex = 85
        '
        'lbl_direccion_c_f
        '
        Me.lbl_direccion_c_f.AutoSize = True
        Me.lbl_direccion_c_f.Location = New System.Drawing.Point(329, 58)
        Me.lbl_direccion_c_f.Name = "lbl_direccion_c_f"
        Me.lbl_direccion_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_direccion_c_f.TabIndex = 84
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(10, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 78
        Me.Label22.Text = "Cedula"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(251, 111)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 15)
        Me.Label23.TabIndex = 83
        Me.Label23.Text = "Nuevo"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(10, 83)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 15)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Nombre"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(8, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(94, 15)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "Cedula Verificar"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(10, 111)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 15)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = "Apellido"
        '
        'txt_cedula_busca_f
        '
        Me.txt_cedula_busca_f.Location = New System.Drawing.Point(132, 23)
        Me.txt_cedula_busca_f.MaxLength = 10
        Me.txt_cedula_busca_f.Name = "txt_cedula_busca_f"
        Me.txt_cedula_busca_f.Size = New System.Drawing.Size(120, 20)
        Me.txt_cedula_busca_f.TabIndex = 67
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(249, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 15)
        Me.Label27.TabIndex = 68
        Me.Label27.Text = "Direccion"
        '
        'btn_nuevo_cliente_f
        '
        Me.btn_nuevo_cliente_f.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_nuevo_cliente_f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_nuevo_cliente_f.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo_cliente_f.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_cliente_f.ForeColor = System.Drawing.Color.Red
        Me.btn_nuevo_cliente_f.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_cliente_f.Location = New System.Drawing.Point(296, 104)
        Me.btn_nuevo_cliente_f.Name = "btn_nuevo_cliente_f"
        Me.btn_nuevo_cliente_f.Size = New System.Drawing.Size(36, 24)
        Me.btn_nuevo_cliente_f.TabIndex = 69
        Me.btn_nuevo_cliente_f.Text = "......"
        Me.btn_nuevo_cliente_f.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(250, 83)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 15)
        Me.Label28.TabIndex = 69
        Me.Label28.Text = "Telefono"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_tiempo_e)
        Me.GroupBox3.Controls.Add(Me.txt_hora_pedido_o)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_tipo_orden_o)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_numero_mesa_o)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 112)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        '
        'txt_tiempo_e
        '
        Me.txt_tiempo_e.Location = New System.Drawing.Point(145, 33)
        Me.txt_tiempo_e.Name = "txt_tiempo_e"
        Me.txt_tiempo_e.ReadOnly = True
        Me.txt_tiempo_e.Size = New System.Drawing.Size(67, 20)
        Me.txt_tiempo_e.TabIndex = 77
        '
        'txt_hora_pedido_o
        '
        Me.txt_hora_pedido_o.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txt_hora_pedido_o.Location = New System.Drawing.Point(146, 10)
        Me.txt_hora_pedido_o.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.txt_hora_pedido_o.Name = "txt_hora_pedido_o"
        Me.txt_hora_pedido_o.Size = New System.Drawing.Size(66, 20)
        Me.txt_hora_pedido_o.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(218, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "*"
        '
        'txt_tipo_orden_o
        '
        Me.txt_tipo_orden_o.Location = New System.Drawing.Point(146, 82)
        Me.txt_tipo_orden_o.Name = "txt_tipo_orden_o"
        Me.txt_tipo_orden_o.ReadOnly = True
        Me.txt_tipo_orden_o.Size = New System.Drawing.Size(106, 20)
        Me.txt_tipo_orden_o.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Numero Mesa"
        '
        'txt_numero_mesa_o
        '
        Me.txt_numero_mesa_o.Location = New System.Drawing.Point(145, 56)
        Me.txt_numero_mesa_o.Name = "txt_numero_mesa_o"
        Me.txt_numero_mesa_o.ReadOnly = True
        Me.txt_numero_mesa_o.Size = New System.Drawing.Size(36, 20)
        Me.txt_numero_mesa_o.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Tipo Orden"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Hora de pedido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 15)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Tiempo de Entrega"
        '
        'dg_orden_d
        '
        Me.dg_orden_d.AllowUserToAddRows = False
        Me.dg_orden_d.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_orden_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_orden_d.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Producto, Me.Precio_u, Me.Total_p, Me.p, Me.codigo_producto_v, Me.Opcion})
        Me.dg_orden_d.EnableHeadersVisualStyles = False
        Me.dg_orden_d.Location = New System.Drawing.Point(11, 270)
        Me.dg_orden_d.Name = "dg_orden_d"
        Me.dg_orden_d.RowHeadersVisible = False
        Me.dg_orden_d.Size = New System.Drawing.Size(442, 278)
        Me.dg_orden_d.TabIndex = 57
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 88
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Precio_u
        '
        Me.Precio_u.HeaderText = "Precio Unitario"
        Me.Precio_u.Name = "Precio_u"
        '
        'Total_p
        '
        Me.Total_p.HeaderText = "Total"
        Me.Total_p.Name = "Total_p"
        '
        'p
        '
        Me.p.HeaderText = "p"
        Me.p.Name = "p"
        Me.p.Visible = False
        '
        'codigo_producto_v
        '
        Me.codigo_producto_v.HeaderText = "codigo_producto_v"
        Me.codigo_producto_v.Name = "codigo_producto_v"
        Me.codigo_producto_v.Visible = False
        '
        'Opcion
        '
        Me.Opcion.HeaderText = "Anula Pedido"
        Me.Opcion.Name = "Opcion"
        Me.Opcion.Width = 50
        '
        'frm_orden_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1166, 603)
        Me.Controls.Add(Me.txt_caja)
        Me.Controls.Add(Me.txt_1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_usuario_empleado)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_datos_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_orden_registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.OpcionOrden.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_bebidas_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbo_datos_cliente.ResumeLayout(False)
        Me.gbo_cliente_f.ResumeLayout(False)
        Me.gbo_cliente_f.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg_orden_d, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_caja As System.Windows.Forms.TextBox
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario_empleado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_total_p_f As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva_f As System.Windows.Forms.TextBox
    Friend WithEvents txt_descuento_f As System.Windows.Forms.TextBox
    Friend WithEvents txt_subtotal_f As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_s As System.Windows.Forms.TextBox
    Friend WithEvents OpcionOrden As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_añadir_producto_o As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_producto As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_cantp As System.Windows.Forms.TextBox
    Friend WithEvents txt_Descripción As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_anular As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_volver_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_guardar_cliente As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero_c_f As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_habilita_botones As System.Windows.Forms.Button
    Friend WithEvents msk_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_pedido_o As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_entrada_o As System.Windows.Forms.Button
    Friend WithEvents btn_segundo_o As System.Windows.Forms.Button
    Friend WithEvents btn_bebidas_o As System.Windows.Forms.Button
    Friend WithEvents btn_postres_o As System.Windows.Forms.Button
    Friend WithEvents btn_primero_o As System.Windows.Forms.Button
    Friend WithEvents gbo_datos_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_cliente_f As System.Windows.Forms.GroupBox
    Friend WithEvents txt_codigo_cliente As System.Windows.Forms.TextBox
    Friend WithEvents chk_consumidorfinal As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_tipo_cliente_fact As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido_c_f As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_c_f As System.Windows.Forms.Label
    Friend WithEvents lbl_cedula_c_f As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono_c_f As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion_c_f As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_busca_f As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo_cliente_f As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_tiempo_e As System.Windows.Forms.TextBox
    Friend WithEvents txt_hora_pedido_o As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo_orden_o As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_mesa_o As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dg_orden_d As System.Windows.Forms.DataGridView
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_u As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_p As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo_producto_v As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Opcion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dg_bebidas_orden As System.Windows.Forms.DataGridView
    Friend WithEvents Foto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
