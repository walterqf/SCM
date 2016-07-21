Public Class frm_asignar_ruta
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim detrtas As New Entity.tbl_scm_detalle_ruta_Entity
        Dim idcliente, idord As New DataTable
        If cb_ordenes.SelectedValue <> Nothing Then
            detrtas.Idempleado = cb_emp.SelectedValue
            detrtas.Idordenesentrega = cb_ordenes.SelectedValue
            detrtas.Idruta = cb_rtas.SelectedValue
            detrtas.Idvehiculos = cb_vehiculos.SelectedValue
            detrtas.Iddetruta = id
            idcliente = BO.BOtbl_scm_ordenes_entrega.getAll(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idordenesentrega = cb_ordenes.SelectedValue})
            detrtas.Idcliente = idcliente.Rows(0).Item(3).ToString
            If editar = False Then
                BO.BOtbl_scm_detalle_ruta.Insert(vCon, detrtas)
                BO.BOGeneral.modificar_estados_ordmod(vCon, cb_ordenes.SelectedValue.ToString, "2")
                idord = BO.BOtbl_scm_ordenes_entrega.getAll(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idordenesentrega = "1"})
                recargar()
            Else
                BO.BOtbl_scm_detalle_ruta.Update(vCon, detrtas)
            End If
            btn_acciones(5)
            editar = False
            limpiar()
            cargar_rtas()
        Else
            MessageBox.Show("No se puede continuar faltan datos",
                            "Ayuda",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1)
            btn_acciones(5)
            editar = False
            limpiar()
            cargar_rtas()
        End If
    End Sub

    Private Sub cargar_rtas()
        grd_asignacion.AutoGenerateColumns = False
        grd_asignacion.DataSource = BO.BOGeneral.GetAlldetallerutas(vCon, New Entity.tbl_scm_detalle_ruta_Entity)
    End Sub

    Private Sub recargar()
        Dim iDord As DataTable
        cb_ordenes.DataSource = Nothing
        cb_ordenes.Items.Clear()
        iDord = BO.BOtbl_scm_ordenes_entrega.getAll(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idscmestadoorden = "1"})

        cb_ordenes.DataSource = iDord
        cb_ordenes.DisplayMember = "ord_descripcion"
        cb_ordenes.ValueMember = "id_ordenes_entrega"
    End Sub


    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_rtas()
        Dim iDord, iDveh, iDemp, iDrtas As DataTable
        iDord = BO.BOtbl_scm_ordenes_entrega.getAll(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idscmestadoorden = "1"})
        iDemp = BO.BOtbl_scm_empleados.getAll(vCon, New Entity.tbl_scm_empleados_Entity With {.Empcargo = "Piloto"})
        iDveh = BO.BOGeneral.get_vehciulosf(vCon, New Entity.tbl_scm_vehiculos_Entity)
        iDrtas = BO.BOtbl_scm_ruta.getAll(vCon, New Entity.tbl_scm_ruta_Entity)
        cb_emp.Items.Clear()
        cb_vehiculos.Items.Clear()
        cb_ordenes.Items.Clear()
        cb_rtas.Items.Clear()

        cb_emp.DataSource = iDemp
        cb_emp.DisplayMember = "nombrecompleto"
        cb_emp.ValueMember = "id_empleado"

        cb_ordenes.DataSource = iDord
        cb_ordenes.DisplayMember = "ord_descripcion"
        cb_ordenes.ValueMember = "id_ordenes_entrega"

        cb_vehiculos.DataSource = iDveh
        cb_vehiculos.DisplayMember = "vehiculo_dis"
        cb_vehiculos.ValueMember = "id_vehiculos"

        cb_rtas.DataSource = iDrtas
        cb_rtas.DisplayMember = "rta_nombre"
        cb_rtas.ValueMember = "id_ruta"

    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        cb_emp.Enabled = estado
        cb_vehiculos.Enabled = estado
        cb_ordenes.Enabled = estado
        cb_rtas.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_scm_detalle_ruta.Delete(vCon, New Entity.tbl_scm_detalle_ruta_Entity With {.Iddetruta = id})
        btn_acciones(2)
        cargar_rtas()
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

    Private Sub grd_usuarios_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles grd_asignacion.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_asignacion.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim detrta As New Entity.tbl_scm_detalle_ruta_Entity
        detrta = BO.BOtbl_scm_detalle_ruta.getSingle(vCon, New Entity.tbl_scm_detalle_ruta_Entity With {.Iddetruta = id})
        cb_emp.DisplayMember = detrta.Idempleado
        cb_ordenes.DisplayMember = detrta.Idordenesentrega
        cb_vehiculos.DisplayMember = detrta.Idvehiculos
        cb_rtas.DisplayMember = detrta.Idruta
        Console.Write("")
        btn_acciones(6)
    End Sub

End Class