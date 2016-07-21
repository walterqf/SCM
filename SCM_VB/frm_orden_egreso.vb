Public Class frm_orden_egreso
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer
    Dim id_bodega_tmp As Integer
    Dim id_detalle_orden As Integer
    Dim editar_detalle As Boolean


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()

        btn_acciones(5)
        editar = False
        grd_detalle.DataSource = Nothing
        lbl_no_orden.Text = "No."
    End Sub

    Private Sub cargar_gestores()
        'grd_detalle.AutoGenerateColumns = False
        'grd_detalle.DataSource = BO.BOGeneral.GetAllGestores(vCon, New Entity.tbl_gestor_ordenes_Entity)
    End Sub

    Private Sub frm_orden_egreso_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        cmb_gestores.Enabled = estado
        txt_usuario.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
        crear_encabezado()
    End Sub



    Private Sub btn_editar_Click(sender As Object, e As EventArgs)
        btn_acciones(3)
        editar = True
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        frm_habilitar(False)
        btn_acciones(4)
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        guardar()
        cargar_ordenes_estado()
    End Sub



    Private Sub limpiar()
        grd_detalle.DataSource = Nothing

    End Sub

    Private Sub btn_acciones(ByVal estado As Integer)
        Select Case (estado)
            Case 1 'Nuevo
                btn_nuevo.Enabled = False
                btncancelar.Enabled = True
                btn_guardar.Enabled = True
                frm_habilitar(True)
            Case 2 'eliminar
                btn_nuevo.Enabled = True
                btncancelar.Enabled = False
                btn_guardar.Enabled = False
                frm_habilitar(False)
            Case 3 'editar
                btn_nuevo.Enabled = False
                btncancelar.Enabled = True
                btn_guardar.Enabled = True
                frm_habilitar(True)
            Case 4 'cancelar
                btn_nuevo.Enabled = True
                btncancelar.Enabled = False
                btn_guardar.Enabled = False
                frm_habilitar(False)
                pnl_producto.Visible = False
            Case 5 'guardar
                btn_nuevo.Enabled = True
                btncancelar.Enabled = False
                btn_guardar.Enabled = False
                frm_habilitar(False)
            Case 6 'habilitar edicion
                btn_nuevo.Enabled = True
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
        iDGestores = BO.BOtbl_gestor_ordenes.getAll(vCon, New Entity.tbl_gestor_ordenes_Entity With {.Idempresa = My.Settings.id_empresa})
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
        txt_cantidad_detalle.Text = 0
        lbl_deta.Text = "Agregar"
        btn_editar_deta.Visible = False
        Label9.Visible = False
        cmb_producto.Enabled = True
        editar_detalle = False
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
            encabezado.Idtipoorden = 1
            encabezado.Idgestorordenes = cmb_gestores.SelectedValue
            encabezado.Idestadoorden = 1

            encabezado_tmp = BO.BOtbl_ordenes_encabezado.Insert(vCon, encabezado)
            lbl_no_orden.Text = "No. " + encabezado_tmp.Idorden.ToString
            id = encabezado_tmp.Idorden

            pnl_producto.Visible = False

        Catch ex As Exception

        End Try

    End Sub


    Private Sub guardar_detalle_orden()
        Try


            If editar_detalle = True Then
                Dim detalle_temporal As New Entity.tbl_ordenes_detalle_Entity

                detalle_temporal = BO.BOtbl_ordenes_detalle.getSingle(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idordenesdetalle = id_detalle_orden})
                detalle_temporal.Cantidadproducto = txt_cantidad_detalle.Text
                detalle_temporal.Idproducto = cmb_producto.SelectedValue

                BO.BOtbl_ordenes_detalle.Update(vCon, detalle_temporal)

            Else

                If validar_producto_ingresado(Convert.ToInt32(cmb_producto.SelectedValue)) = 0 Then

                    Console.Write("")
                    Dim detalle_orden As New Entity.tbl_ordenes_detalle_Entity
                    detalle_orden.Costounitarioproducto = 0
                    detalle_orden.Cantidadproducto = txt_cantidad_detalle.Text
                    detalle_orden.Tipocambio = 1
                    detalle_orden.Idorden = id
                    detalle_orden.Idmoneda = 1
                    detalle_orden.Idproducto = cmb_producto.SelectedValue
                    detalle_orden.Idbodega = id_bodega_tmp

                    BO.BOtbl_ordenes_detalle.Insert(vCon, detalle_orden)
                Else
                    MessageBox.Show("Producto ya registrado en la orden",
               "Error en ingreso de orden",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1)
                End If

            End If
            pnl_producto.Visible = False
            btn_editar_deta.Visible = False
            Label9.Visible = False

            carga_detalle()
            editar_detalle = False
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


    End Sub


    Private Sub cargar_ordenes_estado()
        Dim data_ordenes As DataTable
        grd_ordenes.AutoGenerateColumns = False
        data_ordenes = BO.BOtbl_ordenes_encabezado.getAll(vCon, New Entity.tbl_ordenes_encabezado_Entity With {.Idtipoorden = 1, .Idestadoorden = 1, .Idempresa = My.Settings.id_empresa})
        If data_ordenes.Rows.Count > 0 Then
            grd_ordenes.DataSource = data_ordenes
        Else
            grd_ordenes.DataSource = Nothing
        End If
    End Sub

    Private Sub grd_ordenes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellDoubleClick
        Dim data_tmp As New DataTable


        id = Val(grd_ordenes.Rows(e.RowIndex).Cells(0).Value.ToString)
        lbl_no_orden.Text = "No. " + id.ToString
        data_tmp = BO.BOtbl_ordenes_encabezado.getAll(vCon, New Entity.tbl_ordenes_encabezado_Entity With {.Idorden = id})
        If data_tmp.Rows.Count > 0 Then
            cmb_gestores.SelectedValue = Val(data_tmp.Rows(0)("id_gestor_ordenes"))
        Else

        End If

        carga_detalle()
        btn_mas_producto.Enabled = True
        pnl_producto.Visible = False
    End Sub

    Private Sub grd_detalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_detalle.CellDoubleClick
        Dim data_tmp_detalle As New DataTable
        id_detalle_orden = grd_detalle.Rows(e.RowIndex).Cells(0).Value
        editar_detalle = True

        btn_editar_deta.Visible = True
        Label9.Visible = True

        data_tmp_detalle = BO.BOtbl_ordenes_detalle.getAll(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idordenesdetalle = id_detalle_orden})


        If data_tmp_detalle.Rows.Count <> 0 Then
            cmb_medida.SelectedValue = Val(data_tmp_detalle.Rows(0)("id_medida"))
            txt_cantidad_detalle.Text = data_tmp_detalle.Rows(0)("cantidad_producto").ToString()
            cmb_producto.SelectedValue = Val(data_tmp_detalle.Rows(0)("id_producto"))

            lbl_deta.Text = "Actualizar"
            pnl_producto.Visible = True
        Else

        End If

        cmb_producto.Enabled = False
    End Sub
    Private Sub eliminar_detalle()

        BO.BOtbl_ordenes_detalle.Delete(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idordenesdetalle = id_detalle_orden})

    End Sub

    Private Sub btn_eliminar_detalle_Click(sender As Object, e As EventArgs)
        eliminar_detalle()
        pnl_producto.Visible = False
        carga_detalle()
    End Sub

    Private Function validar_producto_ingresado(ByVal id_producto As Integer) As Integer
        Dim estado As Boolean
        Dim conteo As Integer = 0
        Dim ids As String = ""
        grd_detalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grd_detalle.ClearSelection()
        grd_detalle.CurrentCell = Nothing
        Dim intCount As Integer = 0

        For Each row As DataGridViewRow In grd_detalle.Rows
            If Convert.ToInt32(grd_detalle.Rows(intCount).Cells(4).Value) = id_producto Then
                conteo = conteo + 1
            Else
            End If
            intCount += 1
        Next row
        If conteo = 0 Then
            estado = True
        Else
            estado = False
        End If
        Return conteo
    End Function



    Private Sub btn_agregar_deta_Click(sender As Object, e As EventArgs) Handles btn_agregar_deta.Click
        guardar_detalle_orden()
    End Sub

    Private Sub btn_editar_deta_Click(sender As Object, e As EventArgs) Handles btn_editar_deta.Click
        eliminar_detalle()
        pnl_producto.Visible = False
        carga_detalle()
    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        pnl_producto.Visible = False
    End Sub
End Class