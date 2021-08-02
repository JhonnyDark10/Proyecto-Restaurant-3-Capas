Imports CapaNegocio, CapaEntidad
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing



Public Class frm_orden_registro
    Dim listaDetalle As New List(Of DetalleFacturaEntidad)
    Dim cantidad_p_ As Integer = 0
    Dim int_ban_cliete As Integer
    Dim sub_totalp As Integer = 2
    Dim total_p_ As Integer = 3
    Dim accion_p As Integer = 4
    Dim codigo_p As Integer = 5

    Private Sub frm_orden_registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If int_asignar_pedido = 0 Then
            numerofactura()
            limpiar()
            chk_consumidorfinal.Checked = False
            dg_orden_d.Rows.Clear()
            txt_cedula_busca_f.Text = ""
            btn_nuevo_cliente_f.Enabled = False
            txt_usuario_empleado.Text = 101020
            'txt_usuario_empleado.Text = g_str_nombre_usuario
            txt_tiempo_e.Text = "15 minutos"
            txt_subtotal_f.Text = Format(0, "##,##0.00")
            txt_descuento_f.Text = Format(0, "##,##0.00")
            txt_iva_f.Text = Format(0, "##,##0.00")
            txt_total_p_f.Text = Format(0, "##,##0.00")
            int_accion_realizar = 0
            btn_anular.Enabled = False
            Button1.Enabled = False
            btn_nuevo_cliente_f.Enabled = True
            btn_eliminar.Enabled = True
        ElseIf int_asignar_pedido = 1 Then
            limpiar()
            chk_consumidorfinal.Checked = False
            numerofactura()
            dg_orden_d.Rows.Clear()
            txt_cedula_busca_f.Text = ""
            recuperar_facturas()
            int_accion_realizar = 1
            btn_anular.Enabled = True
            Button1.Enabled = True
            btn_nuevo_cliente_f.Enabled = True
            btn_eliminar.Enabled = False
        End If
    End Sub

    Public Sub recuperar_facturas()
        Dim lista_cp As New List(Of CabeceraFacturaEntidad)
        lista_cp = Nothing
        Dim obj As New RecuperaFacturaNegocio
        lista_cp = obj.recuperar_factura(int_recuperaNM)
        Dim n As Integer
        n = lista_cp.Count
        If n = 0 Then
        Else
            For i = 0 To n - 1
                txt_numero_pedido_o.Text = Format((lista_cp.Item(i).id_factura), "000000")
                txt_codigo_cliente.Text = (lista_cp.Item(i).FK_CLIENTE)
                txt_tipo_orden_o.Text = (lista_cp.Item(i).TIPO_ORDEN)
                txt_subtotal_f.Text = Format((lista_cp.Item(i).SUBTOTAL), "##,##0.00")
                txt_descuento_f.Text = Format((lista_cp.Item(i).DESCUENTO), "##,##0.00")
                txt_iva_f.Text = Format((lista_cp.Item(i).IVA), "##,##0.00")
                txt_total_p_f.Text = Format((lista_cp.Item(i).TOTAL_PAGO), "##,##0.00")
                msk_fecha.Text = (lista_cp.Item(i).FECHA_FACTURA)
                txt_tiempo_e.Text = (lista_cp.Item(i).TIEMPO_ENTREGA)
                txt_usuario_empleado.Text = (lista_cp.Item(i).ID_EMPLEADO)
                txt_numero_mesa_o.Text = (lista_cp.Item(i).NUMERO_MESA)
            Next
        End If
        recuperardetallefactura()
    End Sub

    Public Sub recuperardetallefactura()

        Try
            dg_orden_d.Rows.Clear()
            Dim asig As New RecuperaDetalleNegocio
            Dim lista As List(Of DetalleFacturaEntidad)
            lista = asig.recuperar_detalle(txt_numero_pedido_o.Text)
            Dim n As Integer
            n = lista.Count
            If n = 0 Then
                limpiar()
            Else
                For i = 0 To n - 1
                    dg_orden_d.Rows.Add(lista.Item(i).CANTIDAD_P, lista.Item(i).nombre, lista.Item(i).SUBTOTAL, 0, 2, lista.Item(i).FK_COD_PLATOS)
                    MultiplicarDatos()
                Next
            End If
            recuperarclientefactura()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub recuperarclientefactura()
        Dim lista_cp As New List(Of ClienteEntidad)
        lista_cp = Nothing
        Dim obj As New RecuperarFacturaClienteNegocio
        lista_cp = obj.recuperar_cliente(Val(txt_codigo_cliente.Text))
        Dim n As Integer
        n = lista_cp.Count
        If n = 0 Then
        Else
            For i = 0 To n - 1
                'txt_codigo_cliente.Text = lista_cp.Item(i).dni_CLIENTE
                txt_tipo_cliente_fact.Text = lista_cp.Item(i).descripcion
                lbl_cedula_c_f.Text = lista_cp.Item(i).CEDULA
                lbl_nombre_c_f.Text = lista_cp.Item(i).NOMBRE
                lbl_apellido_c_f.Text = lista_cp.Item(i).APELLIDO_paterno & lista_cp.Item(i).APELLIDO_materno
                lbl_direccion_c_f.Text = lista_cp.Item(i).direccion
                lbl_telefono_c_f.Text = lista_cp.Item(i).telefono
            Next
        End If
    End Sub

    Sub numerofactura()

        Dim lista_cp As New List(Of NumeroFacturaEntidad)
        lista_cp = Nothing
        Dim obj As New NumeroFacturaNegocio
        lista_cp = obj.cargar_numero_factura()
        Dim n As Integer
        n = lista_cp.Count
        If n = 0 Then
        Else
            For i = 0 To n - 1
                txt_numero_pedido_o.Text = Format(lista_cp.Item(i).id_factura + 1, "000000")
                txt_numero_c_f.Text = Format(int_caja_g, "000-") & Format(Val(txt_numero_pedido_o.Text), "000000")
            Next
        End If

    End Sub


    Sub limpiar()
        lbl_apellido_c_f.Text = ""
        lbl_cedula_c_f.Text = ""
        lbl_direccion_c_f.Text = ""
        lbl_nombre_c_f.Text = ""
        lbl_telefono_c_f.Text = ""
        txt_codigo_cliente.Text = ""
        txt_tipo_cliente_fact.Text = ""
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            g_str_cedula = ""
            frm_buscar_clientes.ShowDialog()
            If g_str_cedula <> "" Then
                txt_cedula_busca_f.Text = g_str_cedula
                txt_cedula_busca_f_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cedula_busca_f_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txt_cedula_busca_f.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 32 Then

                Dim lista_cp As New List(Of ClienteEntidad)
                lista_cp = Nothing
                Dim obj As New ClienteNegocio
                lista_cp = obj.recuperarCliente(txt_cedula_busca_f.Text)
                Dim n As Integer
                n = lista_cp.Count
                If n = 0 Then
                    limpiar()
                Else
                    For i = 0 To n - 1
                        txt_codigo_cliente.Text = lista_cp.Item(i).dni_CLIENTE
                        txt_tipo_cliente_fact.Text = lista_cp.Item(i).descripcion
                        lbl_cedula_c_f.Text = lista_cp.Item(i).CEDULA
                        lbl_nombre_c_f.Text = lista_cp.Item(i).NOMBRE
                        lbl_apellido_c_f.Text = lista_cp.Item(i).APELLIDO_paterno & lista_cp.Item(i).APELLIDO_materno
                        lbl_direccion_c_f.Text = lista_cp.Item(i).direccion
                        lbl_telefono_c_f.Text = lista_cp.Item(i).telefono
                    Next
                    subtotal()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_consumidorfinal_CheckedChanged(sender As Object, e As EventArgs) Handles chk_consumidorfinal.CheckedChanged
        Try
            If chk_consumidorfinal.Checked = True Then
                txt_cedula_busca_f.Text = "9999999999"
                txt_cedula_busca_f_KeyPress(Me, New KeyPressEventArgs(ChrW(Keys.Enter)))
            Else
                limpiar()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_bebidas_o_Click(sender As Object, e As EventArgs) Handles btn_bebidas_o.Click
        Try
            dg_bebidas_orden.Rows.Clear()
            Dim asig As New TipoProductoNegocio
            Dim lista As List(Of TipoProductoEntidad)
            lista = asig.retornaproducto("BEBIDAS")

            Dim n As Integer
            n = lista.Count
            If n = 0 Then
                limpiar()
            Else
                For i = 0 To n - 1
                    dg_bebidas_orden.Rows.Add(ByteArrayToImage(DirectCast(lista.Item(i).FOTO_P, Byte())), lista.Item(i).NOMBRE, lista.Item(i).STOCK, lista.Item(i).CODIGO_PLATOS)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)

    End Function



    Private Sub btn_primero_o_Click(sender As Object, e As EventArgs) Handles btn_primero_o.Click
        Try
            dg_bebidas_orden.Rows.Clear()
            Dim asig As New TipoProductoNegocio
            Dim lista As List(Of TipoProductoEntidad)
            lista = asig.retornaproducto("PRIMERO")

            Dim n As Integer
            n = lista.Count
            If n = 0 Then
                limpiar()
            Else
                For i = 0 To n - 1
                    dg_bebidas_orden.Rows.Add(ByteArrayToImage(DirectCast(lista.Item(i).FOTO_P, Byte())), lista.Item(i).NOMBRE, lista.Item(i).STOCK, lista.Item(i).CODIGO_PLATOS)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_entrada_o_Click(sender As Object, e As EventArgs) Handles btn_entrada_o.Click
        Try
            dg_bebidas_orden.Rows.Clear()
            Dim asig As New TipoProductoNegocio
            Dim lista As List(Of TipoProductoEntidad)
            lista = asig.retornaproducto("ENTRADA")

            Dim n As Integer
            n = lista.Count
            If n = 0 Then
                limpiar()
            Else
                For i = 0 To n - 1
                    dg_bebidas_orden.Rows.Add(ByteArrayToImage(DirectCast(lista.Item(i).FOTO_P, Byte())), lista.Item(i).NOMBRE, lista.Item(i).STOCK, lista.Item(i).CODIGO_PLATOS)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_segundo_o_Click(sender As Object, e As EventArgs) Handles btn_segundo_o.Click
        Try
            dg_bebidas_orden.Rows.Clear()
            Dim asig As New TipoProductoNegocio
            Dim lista As List(Of TipoProductoEntidad)
            lista = asig.retornaproducto("SEGUNDO")

            Dim n As Integer
            n = lista.Count
            If n = 0 Then
                limpiar()
            Else
                For i = 0 To n - 1
                    dg_bebidas_orden.Rows.Add(ByteArrayToImage(DirectCast(lista.Item(i).FOTO_P, Byte())), lista.Item(i).NOMBRE, lista.Item(i).STOCK, lista.Item(i).CODIGO_PLATOS)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_postres_o_Click(sender As Object, e As EventArgs) Handles btn_postres_o.Click
        Try
            dg_bebidas_orden.Rows.Clear()
            Dim asig As New TipoProductoNegocio
            Dim lista As List(Of TipoProductoEntidad)
            lista = asig.retornaproducto("POSTRES")

            Dim n As Integer
            n = lista.Count
            If n = 0 Then
                limpiar()
            Else
                For i = 0 To n - 1
                    dg_bebidas_orden.Rows.Add(ByteArrayToImage(DirectCast(lista.Item(i).FOTO_P, Byte())), lista.Item(i).NOMBRE, lista.Item(i).STOCK, lista.Item(i).CODIGO_PLATOS)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dg_bebidas_orden_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_bebidas_orden.CellMouseClick
        Try
            If e.RowIndex > -1 Then
                txt_codigo.Text = dg_bebidas_orden.Rows(e.RowIndex).Cells(3).Value
                txt_Descripción.Text = ""
                txt_precio.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_producto_Click(sender As Object, e As EventArgs) Handles btn_buscar_producto.Click
        Try
            Dim asig As New AsignarProductoNegocio
            Dim lista As List(Of AsignarProductoEntidad)
            lista = asig.asignarproducto(txt_codigo.Text)
            Dim n As Integer
            n = lista.Count
            If n = 0 Then
                limpiar()
            Else
                For i = 0 To n - 1

                    txt_Descripción.Text = lista.Item(i).NOMBRE
                    txt_precio.Text = lista.Item(i).precio
                    txt_s.Text = lista.Item(i).STOCK

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantp.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txt_cedula_busca_f_TextChanged(sender As Object, e As EventArgs) Handles txt_cedula_busca_f.TextChanged

    End Sub

    Private Sub btn_añadir_producto_o_Click(sender As Object, e As EventArgs) Handles btn_añadir_producto_o.Click
        Try
            If txt_codigo.Text <> "" And (Val(txt_cantp.Text) <= Val(txt_s.Text)) And Val(txt_cantp.Text) <> 0 Then
                dg_orden_d.Rows.Add(CDbl(txt_cantp.Text), txt_Descripción.Text, CDbl(txt_precio.Text), 0, 1, CDbl(txt_codigo.Text))
                MultiplicarDatos()
                subtotal()
                txt_codigo.Text = ""
                txt_cantp.Text = ""
                txt_Descripción.Text = ""
                txt_precio.Text = ""
                txt_codigo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim cantidad_p As Integer = 0
    Dim precio_p As Integer = 2
    Dim total_p1 As Integer = 3
    Sub MultiplicarDatos()
        Try
            If dg_orden_d.RowCount > 0 Then
                For fila = 0 To dg_orden_d.RowCount - 1
                    dg_orden_d.Rows(fila).Cells(total_p1).Value = Format(dg_orden_d.Rows(fila).Cells(cantidad_p).Value * (dg_orden_d.Rows(fila).Cells(precio_p).Value), "##,##0.00")
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub subtotal()
        Dim sub_t As Double
        Try
            If dg_orden_d.RowCount > 0 Then
                For fila = 0 To dg_orden_d.RowCount - 1
                    sub_t = sub_t + dg_orden_d.Rows(fila).Cells(total_p1).Value
                Next
            End If
            txt_subtotal_f.Text = Format(sub_t, "##,##0.00")

            If txt_codigo_cliente.Text = "" Then
                txt_descuento_f.Text = Format(0, "##,##0.00")
            Else
                If (txt_tipo_cliente_fact.Text = "PREMIUM") Then
                    txt_descuento_f.Text = Format((txt_subtotal_f.Text * (20 / 100)), "##,##0.00")
                ElseIf (txt_tipo_cliente_fact.Text = "VIP") Then
                    txt_descuento_f.Text = Format((txt_subtotal_f.Text * (25 / 100)), "##,##0.00")
                ElseIf (txt_tipo_cliente_fact.Text = "CLASICO") Then
                    txt_descuento_f.Text = Format(0, "##,##0.00")
                ElseIf (txt_tipo_cliente_fact.Text = "GOLD") Then
                    txt_descuento_f.Text = Format((txt_subtotal_f.Text * (10 / 100)), "##,##0.00")
                ElseIf (txt_tipo_cliente_fact.Text = "ESPECIAL") Then
                    txt_descuento_f.Text = Format((txt_subtotal_f.Text * (5 / 100)), "##,##0.00")
                End If
            End If

            txt_iva_f.Text = Format((txt_subtotal_f.Text * (14 / 100)), "##,##0.00")

            txt_total_p_f.Text = Format((CDbl(txt_subtotal_f.Text) + CDbl(txt_iva_f.Text) - CDbl(txt_descuento_f.Text)), "##,##0.00")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim accion_p As Integer = 4
        Try
            Dim fila As Integer
            Dim valor As String
            If dg_orden_d.RowCount > 0 Then
                fila = dg_orden_d.Rows.Count - 1
                valor = dg_orden_d(accion_p, fila).Value
                If valor = 1 Then
                    dg_orden_d.Rows.RemoveAt(fila)
                End If
            End If
            subtotal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_total_p_f.Text <= 0 Then
            MessageBox.Show("No Puede Facturar Porque No Tiene Productos Ingresados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            cancela_factura = txt_numero_pedido_o.Text
            total_f = txt_total_p_f.Text
            frm_pago.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub btn_guardar_cliente_Click(sender As Object, e As EventArgs) Handles btn_guardar_cliente.Click
        Try
            If int_accion_realizar = 0 Then
                'ingresar crear
                Dim str_mensage, str_titulo As String
                str_mensage = "Realmente desea Realizar el Pedido?"
                str_titulo = "SISTEMA..."
                Dim respuesta As MsgBoxResult
                respuesta = MsgBox(str_mensage, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, str_titulo)
                If respuesta = MsgBoxResult.Yes Then

                    'validad todos los datos estén corrector
                    If fun_validar() = False Then
                        Exit Sub
                    End If

                    Dim asig As New VerificaFacturaNegocio
                    If asig.verificar_numfactura(Trim(txt_numero_pedido_o.Text)) = True Then
                        MessageBox.Show("Número de factura ya existe", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txt_numero_pedido_o.Focus()
                        Exit Sub
                    End If


                    fun_grabarCabeceraFactura()

                    MessageBox.Show("Se realizó Pedido con éxito", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            ElseIf int_accion_realizar = 1 Then
                'actualizar
                Dim str_mensage1, str_titulo1 As String
                str_mensage1 = "Realmente desea Actualizar el Pedido?"
                str_titulo1 = "SISTEMA..."
                Dim respuesta1 As MsgBoxResult
                respuesta1 = MsgBox(str_mensage1, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, str_titulo1)
                If respuesta1 = MsgBoxResult.Yes Then
                    'iniciar la transacción
                    If txt_total_p_f.Text <= 0 Then
                        MessageBox.Show("Elimino sus Pedido, Ingrese Por Lo Menos Uno Nuevo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    fun_grabarCabeceraFactura_actualizada()

                    MessageBox.Show("Se Actualizo Pedido con éxito", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub fun_grabarCabeceraFactura_actualizada()
        Try
            fun_grabarDetalleFacturaactualizada()
            Dim FACTURA As New CabeceraFacturaEntidad
            Dim obj As New ActualizarCabeceraFacturaNegocio
            FACTURA.id_factura = Val(txt_numero_pedido_o.Text)
            FACTURA.FK_CLIENTE = Val(txt_codigo_cliente.Text)
            FACTURA.FK_TIPO_PAGO = 1
            FACTURA.TIPO_ORDEN = txt_tipo_orden_o.Text
            FACTURA.SUBTOTAL = txt_subtotal_f.Text
            FACTURA.DESCUENTO = txt_descuento_f.Text
            FACTURA.IVA = txt_iva_f.Text
            FACTURA.TOTAL_PAGO = txt_total_p_f.Text
            FACTURA.FECHA_FACTURA = msk_fecha.Text
            FACTURA.HORA_PEDIDO = "2012-11-11"
            FACTURA.TIEMPO_ENTREGA = txt_tiempo_e.Text
            FACTURA.ID_EMPLEADO = 1
            FACTURA.NOMBRE_PC = Environment.MachineName
            FACTURA.NOMRE_USU = Environment.UserName
            FACTURA.ESTADO_FACT = "P"
            FACTURA.NUMERO_MESA = txt_numero_mesa_o.Text

            obj.facturaactualizada(FACTURA, listaDetalle)

        Catch ex As Exception
        End Try

    End Sub

    Sub fun_grabarDetalleFacturaactualizada()
        Try
            If dg_orden_d.RowCount > 0 Then
                For fila = 0 To dg_orden_d.RowCount - 1
                    If dg_orden_d(accion_p, fila).Value = 1 Then
                        Dim registro As New DetalleFacturaEntidad
                        registro.FK_ID_FACTURA = Val(txt_numero_pedido_o.Text)
                        registro.FK_COD_PLATOS = dg_orden_d(codigo_p, fila).Value
                        registro.SUBTOTAL = dg_orden_d(sub_totalp, fila).Value
                        registro.CANTIDAD_P = dg_orden_d(cantidad_p_, fila).Value
                        registro.TOTAL = dg_orden_d(total_p_, fila).Value
                        registro.accion_p = dg_orden_d(accion_p, fila).Value
                        'registro.ESTADO_D_O = "A"
                        listaDetalle.Add(registro)
                    End If
                Next
                'listaDetalle = Nothing
                'dg_orden_d.DataSource = listaDetalle
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub fun_grabarCabeceraFactura()
        Try
            fun_grabarDetalleFactura()
            Dim FACTURA As New CabeceraFacturaEntidad
            Dim obj As New CabeceraFacturaNegocio

            FACTURA.FK_CLIENTE = Val(txt_codigo_cliente.Text)
            FACTURA.FK_TIPO_PAGO = 1
            FACTURA.TIPO_ORDEN = txt_tipo_orden_o.Text
            FACTURA.SUBTOTAL = txt_subtotal_f.Text
            FACTURA.DESCUENTO = txt_descuento_f.Text
            FACTURA.IVA = txt_iva_f.Text
            FACTURA.TOTAL_PAGO = txt_total_p_f.Text
            FACTURA.FECHA_FACTURA = msk_fecha.Text
            FACTURA.HORA_PEDIDO = "2012-11-11"
            FACTURA.TIEMPO_ENTREGA = txt_tiempo_e.Text
            FACTURA.ID_EMPLEADO = 1
            FACTURA.NOMBRE_PC = Environment.MachineName
            FACTURA.NOMRE_USU = Environment.UserName
            FACTURA.ESTADO_FACT = "P"
            FACTURA.NUMERO_MESA = txt_numero_mesa_o.Text

            obj.factura(FACTURA, listaDetalle)

        Catch ex As Exception
        End Try
    End Sub

    Sub fun_grabarDetalleFactura()

        Try
            If dg_orden_d.RowCount > 0 Then
                For fila = 0 To dg_orden_d.RowCount - 1
                    If dg_orden_d(accion_p, fila).Value = 1 Then
                        Dim registro As New DetalleFacturaEntidad
                        registro.FK_ID_FACTURA = Val(txt_numero_pedido_o.Text)
                        registro.FK_COD_PLATOS = dg_orden_d(codigo_p, fila).Value
                        registro.SUBTOTAL = dg_orden_d(sub_totalp, fila).Value
                        registro.CANTIDAD_P = dg_orden_d(cantidad_p_, fila).Value
                        registro.TOTAL = dg_orden_d(total_p_, fila).Value
                        'registro.ESTADO_D_O = "A"
                        listaDetalle.Add(registro)
                    End If
                Next
                'listaDetalle = Nothing
                'dg_orden_d.DataSource = listaDetalle
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function fun_validar() As Boolean
        Try
            fun_validar = False
            'campo numero factura vacio
            If Trim(txt_numero_pedido_o.Text) = "" Then
                MessageBox.Show("Registre número de factura", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_numero_pedido_o.Focus()
                Exit Function
            End If
            'campo numero de cedula vacio
            If txt_tipo_orden_o.Text = "Mesa" Then
                If Trim(txt_cedula_busca_f.Text) = "" Then
                    MessageBox.Show("Elija Cliente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txt_cedula_busca_f.Focus()
                    Exit Function
                End If
            End If
            'validar que al menos tenga un producto ingresado
            If (Trim(txt_total_p_f.Text = "")) Then
                MessageBox.Show("Ingrese al Menos Un producto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_codigo.Focus()
                Exit Function
            End If
            If (Trim(txt_total_p_f.Text) <= 0) Then
                MessageBox.Show("Ingrese al Menos Un producto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_codigo.Focus()
                Exit Function
            End If
            fun_validar = True
        Catch ex As Exception
            fun_validar = False
        End Try
    End Function

    Private Sub btn_volver_cliente_Click(sender As Object, e As EventArgs) Handles btn_volver_cliente.Click
        Me.Close()
    End Sub

    Private Sub btn_anular_Click(sender As Object, e As EventArgs) Handles btn_anular.Click
        Dim producto As Integer = 5
        Try
            If dg_orden_d.RowCount > 0 Then
                For fila = 0 To dg_orden_d.RowCount - 1
                    If dg_orden_d(6, fila).Value = True Then
                        Dim anula As New AnularPedidoNegocio
                        anula.anularpedido(Val(txt_numero_pedido_o.Text), dg_orden_d(producto, fila).Value, dg_orden_d(cantidad_p_, fila).Value, dg_orden_d(5, fila).Value)
                        MessageBox.Show("Pedido Anulado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Next
            End If
            recuperardetallefactura()
            subtotal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dg_orden_d_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dg_orden_d.CellEndEdit
        Dim fila As Integer
        dg_orden_d(4, fila).Value = 2
        MultiplicarDatos()
        subtotal()
    End Sub


    Private Sub btn_nuevo_cliente_f_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cliente_f.Click
        Dim frm As New frm_clientes
        frm.ShowDialog()
    End Sub

    Private Sub btn_nuevo_cliente_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cliente.Click
        Me.Close()
    End Sub
End Class