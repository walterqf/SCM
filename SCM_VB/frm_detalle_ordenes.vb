Public Class frm_detalle_ordenes
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer
    Dim idorden As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim deto As New Entity.tbl_scm_detalle_ordenes_Entity
        Dim inv As New Entity.tbl_inventario_Entity
        Dim costo As Decimal
        ' inv = BO.BOtbl_inventario.getSingle(vCon, New Entity.tbl_inventario_Entity With {.Idproducto = cb_producto.SelectedValue})
        costo = inv.Costounitarioproducto
        'MessageBox.Show(costo.ToString * txt_cantidad.Text)

        ' deto.Detfechasolicitud = dt_fecha_solicitud.Value.ToString
        deto.Detfechaentrega = dt_fecha_entrega.Value.ToString
        'deto.Idproducto = cb_producto.SelectedValue
        deto.Detcantidadproducto = txt_cantidad.Text
        deto.Detvolumenpeso = txt_peso.Text
        deto.Idruta = cb_ruta.SelectedValue
        'deto.Idscmestadoorden = cb_estado.SelectedValue
        deto.Idcliente = cb_cliente.SelectedValue
        deto.Idordenesentrega = idorden
        deto.Detcostototal = txt_cantidad.Text * costo.ToString
        deto.Iddetalleordenes = id
        If editar = False Then
            BO.BOtbl_scm_detalle_ordenes.Insert(vCon, deto)
        Else
            BO.BOtbl_scm_detalle_ordenes.Update(vCon, deto)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_vehiculos()
    End Sub

    Private Sub cargar_vehiculos()
        grd_usuarios.AutoGenerateColumns = False
        grd_usuarios.DataSource = BO.BOtbl_scm_detalle_ordenes.getAll(vCon, New Entity.tbl_scm_detalle_ordenes_Entity)
    End Sub

    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_vehiculos()
        'grd_usuarios.AutoGenerateColumns = False
        'grd_usuarios.DataSource = BO.BOtbl_scm_vehiculos.getAll(vCon, New Entity.tbl_scm_detalle_ordenes)
        'MessageBox.Show(frm_ordenes_entrega.idO.ToString)
        idorden = frm_ordenes_entrega.idO
        Dim iDproducto, iDruta, iDestado, iDcliente As DataTable
        'Dim nombre As String
        iDproducto = BO.BOtbl_scm_productos.getAll(vCon, New Entity.tbl_scm_productos_Entity)
        iDruta = BO.BOtbl_scm_ruta.getAll(vCon, New Entity.tbl_scm_ruta_Entity)
        iDestado = BO.BOtbl_scm_estado_orden.getAll(vCon, New Entity.tbl_scm_estado_orden_Entity)
        iDcliente = BO.BOtbl_scm_cliente.getAll(vCon, New Entity.tbl_scm_cliente_Entity)
        'cb_producto.Items.Clear()
        'cb_estado.Items.Clear()
        cb_ruta.Items.Clear()
        cb_cliente.Items.Clear()

        'cb_producto.DataSource = iDproducto
        'cb_producto.DisplayMember = "prd_descripcion"
        'cb_producto.ValueMember = "id_producto"
        'cb_estado.DataSource = iDestado
        'cb_estado.DataSource = iDestado
        'cb_estado.DisplayMember = "std_nombre"
        'cb_estado.ValueMember = "id_scm_estado_orden"
        cb_ruta.DataSource = iDruta
        cb_ruta.DisplayMember = "rta_nombre"
        cb_ruta.ValueMember = "id_ruta"


        cb_cliente.DataSource = iDcliente
        cb_cliente.DisplayMember += "cli_primer_nombre"
        cb_cliente.ValueMember = "id_cliente"
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        ' dt_fecha_solicitud.Enabled = estado
        dt_fecha_entrega.Enabled = estado
        '' cb_producto.Enabled = estado
        txt_cantidad.Enabled = estado
        txt_peso.Enabled = estado
        cb_ruta.Enabled = estado
        '' cb_estado.Enabled = estado
        cb_cliente.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_scm_detalle_ordenes.Delete(vCon, New Entity.tbl_scm_detalle_ordenes_Entity With {.Iddetalleordenes = id})
        btn_acciones(2)
        cargar_vehiculos()
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub limpiar()
        'txt_login_id.Text = ""
        'txt_nombre.Text = ""
        'txt_contrasena.Text = ""
        'cks_estado.Checked = False
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

    Private Sub grd_usuarios_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles grd_usuarios.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_usuarios.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim deto As New Entity.tbl_scm_detalle_ordenes_Entity
        deto = BO.BOtbl_scm_detalle_ordenes.getSingle(vCon, New Entity.tbl_scm_detalle_ordenes_Entity With {.Iddetalleordenes = id})

        '  dt_fecha_solicitud.Value = deto.Detfechasolicitud
        '  cb_producto.DisplayMember=deto.

        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub grd_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_usuarios.CellContentClick

    End Sub
End Class