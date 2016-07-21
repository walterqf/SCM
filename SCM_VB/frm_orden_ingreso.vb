Public Class frm_orden_ingreso
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer
    Dim id_bodega_tmp As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        'Dim gestores As New Entity.tbl_gestor_ordenes_Entity
        'gestores.Nombresolicitanteorden = txt_nombre_gestor.Text
        'gestores.Nombrecomercialsolicitanteorden = txt_nombre_comercial_gestor.Text
        'gestores.Idtipogestor = cmb_tipos.SelectedValue
        'gestores.Nitsolicitanteorden = txt_nit_gestor.Text
        'gestores.Direccionsolicitanteorden = txt_direccion_gestor.Text
        'gestores.Telefonosolicitanteorden = txt_telefono_gestor.Text
        'gestores.Idusuario = Val(txt_id_usuario.Text)
        'gestores.Idempresa = Val(cmb_empresa.SelectedValue)

        'gestores.Idgestorordenes = id


        '        If txt_id_usuario.Text <> "0" Then
        '       If editar = False Then
        '      BO.BOtbl_gestor_ordenes.Insert(vCon, gestores)
        '     Else
        '    BO.BOtbl_gestor_ordenes.Update(vCon, gestores)
        '   End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_gestores()
        '  Else

        'End If

    End Sub

    Private Sub cargar_gestores()
        'grd_detalle.AutoGenerateColumns = False
        'grd_detalle.DataSource = BO.BOGeneral.GetAllGestores(vCon, New Entity.tbl_gestor_ordenes_Entity)
    End Sub

    Private Sub frm_orden_ingreso_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_gestores_ordenes()
        cargar_productos()

        cargar_gestores()
        cargar_medidas()
        cargar_encabezado()
        busqueda_medida_producto()

        cargar_ordenes_estado()
    End Sub
    Private Sub cargar_encabezado()
        lbl_fecha.Text = Now.Day.ToString + "/" + Now.Month.ToString + "/" + Now.Year.ToString
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        btn_mas_producto.Enabled = estado
        grd_detalle.Enabled = estado
        cmb_gestores.Enabled = estado
        'cmb_empresa.Enabled = estado
        'txt_nombre_gestor.Enabled = estado
        'txt_nombre_comercial_gestor.Enabled = estado
        'txt_direccion_gestor.Enabled = estado

        'txt_nit_gestor.Enabled = estado
        'txt_telefono_gestor.Enabled = estado
        txt_usuario.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
        crear_encabezado()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_gestor_ordenes.Delete(vCon, New Entity.tbl_gestor_ordenes_Entity With {.Idgestorordenes = id})
        btn_acciones(2)
        cargar_gestores()
        limpiar()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        btn_acciones(3)
        editar = True
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        frm_habilitar(False)
        btn_acciones(4)
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        guardar()
    End Sub

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_detalle.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_detalle.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim gestor As New Entity.tbl_gestor_ordenes_Entity
        Dim usuario As New DataTable

        gestor = BO.BOtbl_gestor_ordenes.getSingle(vCon, New Entity.tbl_gestor_ordenes_Entity With {.Idgestorordenes = id})

        'txt_nombre_gestor.Text = gestor.Nombresolicitanteorden
        'txt_direccion_gestor.Text = gestor.Direccionsolicitanteorden
        'txt_nit_gestor.Text = gestor.Nitsolicitanteorden
        'txt_telefono_gestor.Text = gestor.Telefonosolicitanteorden
        'txt_nombre_comercial_gestor.Text = gestor.Nombrecomercialsolicitanteorden
        'cmb_empresa.SelectedValue = gestor.Idempresa
        cmb_gestores.SelectedValue = gestor.Idtipogestor

        txt_id_usuario.Text = gestor.Idusuario

        usuario = BO.BOtbl_scm_usuarios.getAll(vCon, New Entity.tbl_scm_usuarios_Entity With {.Idusuario = gestor.Idusuario})

        If usuario.Rows.Count <> 0 Then
            lbl_usuario.Text = usuario.Rows(0)("med_nombre").ToString()
            txt_usuario.Text = usuario.Rows(0)("med_loginid").ToString()

        Else
            lbl_usuario.Text = ""
            txt_id_usuario.Text = 0
        End If



        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        'txt_nombre_gestor.Text = ""
        'txt_direccion_gestor.Text = ""
        'cmb_empresa.SelectedIndex = 0
        'cmb_tipos.SelectedIndex = 0
        'txt_nombre_comercial_gestor.Text = ""
        'txt_id_usuario.Text = "1"
        'txt_nit_gestor.Text = ""
        'txt_telefono_gestor.Text = ""
        'txt_usuario.Text = ""

    End Sub

    Private Sub btn_acciones(ByVal estado As Integer)
        Select Case (estado)
            Case 1 'Nuevo
                btn_nuevo.Enabled = False
                btn_eliminar.Enabled = False
                btn_editar.Enabled = False
                btncancelar.Enabled = True
                btn_guardar.Enabled = True
                frm_habilitar(True)
            Case 2 'eliminar
                btn_nuevo.Enabled = True
                btn_eliminar.Enabled = False
                btn_editar.Enabled = False
                btncancelar.Enabled = False
                btn_guardar.Enabled = False
                frm_habilitar(False)
            Case 3 'editar
                btn_nuevo.Enabled = False
                btn_eliminar.Enabled = False
                btn_editar.Enabled = False
                btncancelar.Enabled = True
                btn_guardar.Enabled = True
                frm_habilitar(True)
            Case 4 'cancelar
                btn_nuevo.Enabled = True
                btn_eliminar.Enabled = False
                btn_editar.Enabled = False
                btncancelar.Enabled = False
                btn_guardar.Enabled = False
                frm_habilitar(False)
                pnl_producto.Visible = False
            Case 5 'guardar
                btn_nuevo.Enabled = True
                btn_eliminar.Enabled = False
                btn_editar.Enabled = False
                btncancelar.Enabled = False
                btn_guardar.Enabled = False
                frm_habilitar(False)
            Case 6 'habilitar edicion
                btn_nuevo.Enabled = True
                btn_eliminar.Enabled = True
                btn_editar.Enabled = True
                btncancelar.Enabled = False
                btn_guardar.Enabled = False
                frm_habilitar(False)
        End Select
    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim usuario As New Entity.tbl_scm_usuarios_Entity
            Dim data_tmp As New DataTable
            data_tmp = BO.BOtbl_scm_usuarios.getAll(vCon, New Entity.tbl_scm_usuarios_Entity With {.Medloginid = txt_usuario.Text})

            If data_tmp.Rows.Count <> 0 Then
                lbl_usuario.Text = data_tmp.Rows(0)("med_nombre").ToString()
                txt_id_usuario.Text = data_tmp.Rows(0)("id_usuario").ToString()

            Else
                lbl_usuario.Text = ""
                txt_id_usuario.Text = 0
            End If

        End If

    End Sub

    Private Sub cargar_gestores_ordenes()
        Dim iDGestores As DataTable
        iDGestores = BO.BOtbl_gestor_ordenes.getAll(vCon, New Entity.tbl_gestor_ordenes_Entity)
        cmb_gestores.Items.Clear()


        cmb_gestores.DataSource = iDGestores
        cmb_gestores.DisplayMember = "nombre_solicitante_orden"
        cmb_gestores.ValueMember = "id_gestor_ordenes"
    End Sub



    Private Sub cargar_productos()
        Dim iDProducto As DataTable
        iDProducto = BO.BOtbl_scm_productos.getAll(vCon, New Entity.tbl_scm_productos_Entity)
        cmb_producto.Items.Clear()


        cmb_producto.DataSource = iDProducto
        cmb_producto.DisplayMember = "prd_descripcion"
        cmb_producto.ValueMember = "id_producto"

    End Sub


    Private Sub cargar_medidas()
        Dim iDMedida As DataTable
        iDMedida = BO.BOtbl_scm_medidas_productos.getAll(vCon, New Entity.tbl_scm_medidas_productos_Entity)
        cmb_medida.Items.Clear()


        cmb_medida.DataSource = iDMedida
        cmb_medida.DisplayMember = "med_descripcion"
        cmb_medida.ValueMember = "id_medida"

    End Sub

    Private Sub busqueda_medida_producto()
        Dim producto As New Entity.tbl_scm_productos_Entity
        Dim data_tmp As DataTable

        producto = BO.BOtbl_scm_productos.getSingle(vCon, New Entity.tbl_scm_productos_Entity With {.Idproducto = cmb_producto.SelectedValue})
        data_tmp = BO.BOGeneral.GetBodega(vCon, cmb_producto.SelectedValue)

        If data_tmp.Rows.Count <> 0 Then
            id_bodega_tmp = Val(data_tmp.Rows(0)("id_bodega"))
        End If



        cmb_medida.SelectedValue = producto.Idmedida



    End Sub

    Private Sub btn_mas_producto_Click(sender As Object, e As EventArgs) Handles btn_mas_producto.Click
        pnl_producto.Visible = True
    End Sub

    Private Sub btn_agregar_producto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_producto.SelectedIndexChanged
        busqueda_medida_producto()
    End Sub

    Private Sub crear_encabezado()
        Dim encabezado As New Entity.tbl_ordenes_encabezado_Entity
        Dim encabezado_tmp As New Entity.tbl_ordenes_encabezado_Entity

        Try

            encabezado.Fechamovmiento = Now
            encabezado.Ivaorden = 0
            encabezado.Ivaorden1 = 0
            encabezado.Totalorden = 0
            encabezado.Idusuario = My.Settings.id_user
            encabezado.Idtipoorden = 2
            encabezado.Idgestorordenes = cmb_gestores.SelectedValue
            encabezado.Idestadoorden = 1

            encabezado_tmp = BO.BOtbl_ordenes_encabezado.Insert(vCon, encabezado)
            lbl_no_orden.Text = "No. " + encabezado_tmp.Idorden.ToString
            id = encabezado_tmp.Idorden
        Catch ex As Exception

        End Try

    End Sub


    Private Sub guardar_detalle_orden()
        Try
            Dim detalle_orden As New Entity.tbl_ordenes_detalle_Entity
            detalle_orden.Costounitarioproducto = Val(txt_precio.Text)
            detalle_orden.Cantidadproducto = txt_cantidad_detalle.Text
            detalle_orden.Tipocambio = 1
            detalle_orden.Idorden = id
            detalle_orden.Idmoneda = 1
            detalle_orden.Idproducto = cmb_producto.SelectedValue
            detalle_orden.Idbodega = id_bodega_tmp

            BO.BOtbl_ordenes_detalle.Insert(vCon, detalle_orden)
            carga_detalle()

        Catch ex As Exception

        End Try


    End Sub


    Private Sub carga_detalle()
        Dim data_detalle As DataTable
        data_detalle = BO.BOGeneral.get_detalle_orden(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idorden = id})
        grd_detalle.AutoGenerateColumns = False
        If data_detalle.Rows.Count > 0 Then
            grd_detalle.DataSource = data_detalle
        Else
            grd_detalle.DataSource = Nothing
        End If



        For Each row As DataGridViewRow In grd_detalle.Rows

            Dim suma As Double = Convert.ToDouble(row.Cells(3).Value) * Convert.ToDouble(row.Cells(4).Value)

            row.Cells("Subtotal").Value = suma

        Next


        Dim total As Decimal = 0
        For Each row As DataGridViewRow In grd_detalle.Rows
            total += Convert.ToDecimal(row.Cells("Subtotal").Value)
        Next
        Label13.Text = total.ToString("C")

    End Sub

    Private Sub sumaSaldosFactura()


    End Sub


    Private Sub cargar_ordenes_estado()
        Dim data_ordenes As DataTable
        grd_ordenes.AutoGenerateColumns = False
        data_ordenes = BO.BOtbl_ordenes_encabezado.getAll(vCon, New Entity.tbl_ordenes_encabezado_Entity)
        If data_ordenes.Rows.Count > 0 Then
            grd_ordenes.DataSource = data_ordenes
        Else
            grd_ordenes.DataSource = Nothing
        End If
    End Sub


    Private Sub grd_ordenes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellContentDoubleClick

    End Sub

    Private Sub grd_ordenes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellDoubleClick

        id = Val(grd_ordenes.Rows(e.RowIndex).Cells(0).Value.ToString)
        carga_detalle()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles pnl_precio.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        pnl_producto.Visible = False
        guardar_detalle_orden()
    End Sub

    Private Sub grd_detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_detalle.CellContentClick

    End Sub

    Private Sub grd_detalle_AutoGenerateColumnsChanged(sender As Object, e As EventArgs) Handles grd_detalle.AutoGenerateColumnsChanged

    End Sub
End Class