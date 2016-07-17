Public Class frm_vehiculos
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim vehiculo As New Entity.tbl_scm_vehiculos_Entity
        'usuarios.Medloginid = txt_login_id.Text
        ' usuarios.Medpassid = Globales.Encripta(txt_contrasena.Text)
        'ordenes.Orddescripcion = txt_nombre.Text
        ' usuarios.Medestado = Convert.ToInt32(cks_estado.Checked)

        vehiculo.Idestadovehiculo = cb_estado.SelectedValue
        vehiculo.Idtipovehiculo = cb_tipo_vehiculs.SelectedValue
        vehiculo.Idmarca = cb_marca.SelectedValue
        vehiculo.Vhcmatricula = txt_mtr.Text
        vehiculo.Vhccolor = txt_clr.Text
        ' vehiculo.Numchasis = txt_num_chasis.Text
        vehiculo.Vhcmodelo = txt_modelo.Text
        vehiculo.Vhckmactual = txt_kilo_actual.Text
        vehiculo.Vhckmoriginal = txt_kil_original.Text
        'vehiculo.Vhcfechaultimoservicio = dt_fecha.Value.ToString

        vehiculo.Idvehiculos = id
        If editar = False Then
            BO.BOtbl_scm_vehiculos.Insert(vCon, vehiculo)
        Else
            BO.BOtbl_scm_vehiculos.Update(vCon, vehiculo)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_vehiculos()
    End Sub

    Private Sub cargar_vehiculos()
        grd_usuarios.AutoGenerateColumns = False
        grd_usuarios.DataSource = BO.BOtbl_scm_vehiculos.getAll(vCon, New Entity.tbl_scm_vehiculos_Entity)
    End Sub

    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_vehiculos()
        'grd_usuarios.AutoGenerateColumns = False
        'grd_usuarios.DataSource = BO.BOtbl_scm_vehiculos.getAll(vCon, New Entity.tbl_scm_vehiculos_Entity)

        Dim iDMarca, iDtipo, iDestado As DataTable
        iDMarca = BO.BOtbl_scm_marca_vehiculo.getAll(vCon, New Entity.tbl_scm_marca_vehiculo_Entity)
        iDtipo = BO.BOtbl_scm_tipo_vehiculo.getAll(vCon, New Entity.tbl_scm_tipo_vehiculo_Entity)
        iDestado = BO.BOtbl_scm_estado.getAll(vCon, New Entity.tbl_scm_estado_Entity)
        cb_marca.Items.Clear()
        cb_tipo_vehiculs.Items.Clear()
        cb_estado.Items.Clear()


        cb_marca.DataSource = iDMarca
        cb_marca.DisplayMember = "mrc_marca"
        cb_marca.ValueMember = "id_marca"
        cb_tipo_vehiculs.DataSource = iDtipo
        cb_tipo_vehiculs.DisplayMember = "tpo_nombre"
        cb_tipo_vehiculs.ValueMember = "id_tipo_vehiculo"
        cb_estado.DataSource = iDestado
        cb_estado.DisplayMember = "nbr_estado"
        cb_estado.ValueMember = "id_estado"

    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        'txt_login_id.Enabled = estado
        ' txt_nombre.Enabled = estado
        'txt_contrasena.Enabled = estado
        ' cks_estado.Enabled = estado

        cb_marca.Enabled = estado
        cb_tipo_vehiculs.Enabled = estado
        cb_estado.Enabled = estado
        txt_mtr.Enabled = estado
        txt_clr.Enabled = estado
        ' txt_num_chasis.Enabled = estado
        txt_modelo.Enabled = estado
        txt_kilo_actual.Enabled = estado
        txt_kil_original.Enabled = estado
        dt_fecha.Enabled = estado

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_scm_vehiculos.Delete(vCon, New Entity.tbl_scm_vehiculos_Entity With {.Idvehiculos = id})
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
        Dim vehiculos As New Entity.tbl_scm_vehiculos_Entity
        vehiculos = BO.BOtbl_scm_vehiculos.getSingle(vCon, New Entity.tbl_scm_vehiculos_Entity With {.Idvehiculos = id})

        cb_marca.DisplayMember = vehiculos.Idmarca
        cb_tipo_vehiculs.DisplayMember = vehiculos.Idtipovehiculo
        txt_mtr.Text = vehiculos.Vhcmatricula
        txt_clr.Text = vehiculos.Vhccolor
        'txt_num_chasis.Text = vehiculos.Numchasis
        txt_modelo.Text = vehiculos.Vhcmodelo
        txt_kilo_actual.Text = vehiculos.Vhckmactual
        txt_kil_original.Text = vehiculos.Vhckmoriginal
        dt_fecha.Value = vehiculos.Vhcfechaultimoservicio
        cb_estado.DisplayMember = vehiculos.Idestadovehiculo


        'txt_login_id.Text = usuario.Medloginid
        'txt_nombre.Text = ordenes.Orddescripcion
        'txt_contrasena.Text = Globales.DesEncripta(usuario.Medpassid)
        'cks_estado.Checked = Convert.ToBoolean(usuario.Medestado)

        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
End Class