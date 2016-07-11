Public Class frm_gestor
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim gestores As New Entity.tbl_gestor_ordenes_Entity
        gestores.Nitsolicitanteorden = txt_nombre_gestor.Text
        gestores.Nombrecomercialsolicitanteorden = txt_nombre_comercial_gestor.Text
        gestores.Idtipogestor = cmb_tipos.SelectedValue
        gestores.Nitsolicitanteorden = txt_nit_gestor.Text
        gestores.Direccionsolicitanteorden = txt_direccion_gestor.Text
        gestores.Telefonosolicitanteorden = txt_telefono_gestor.Text
        gestores.Idusuario = Val(txt_id_usuario.Text)
        gestores.Idempresa = Val(cmb_empresa.SelectedValue)

        gestores.Idgestorordenes = id
        If txt_id_usuario.Text <> "0" Then
            If editar = False Then
                BO.BOtbl_gestor_ordenes.Insert(vCon, gestores)
            Else
                BO.BOtbl_gestor_ordenes.Update(vCon, gestores)
            End If
            btn_acciones(5)
            editar = False
            limpiar()
            cargar_gestores()
        Else

        End If

    End Sub

    Private Sub cargar_gestores()
        grd_gestores.AutoGenerateColumns = False
        grd_gestores.DataSource = BO.BOGeneral.GetAllGestores(vCon, New Entity.tbl_gestor_ordenes_Entity)
    End Sub

    Private Sub frm_gestor_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_tipos()
        cargar_empresas()
        cargar_gestores()

    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        cmb_tipos.Enabled = estado
        cmb_empresa.Enabled = estado
        txt_nombre_gestor.Enabled = estado
        txt_nombre_comercial_gestor.Enabled = estado
        txt_direccion_gestor.Enabled = estado

        txt_nit_gestor.Enabled = estado
        txt_telefono_gestor.Enabled = estado
        txt_usuario.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_gestores.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_gestores.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim gestor As New Entity.tbl_gestor_ordenes_Entity
        Dim usuario As New DataTable

        gestor = BO.BOtbl_gestor_ordenes.getSingle(vCon, New Entity.tbl_gestor_ordenes_Entity With {.Idgestorordenes = id})

        txt_nombre_gestor.Text = gestor.Nombresolicitanteorden
        txt_direccion_gestor.Text = gestor.Direccionsolicitanteorden
        txt_nit_gestor.Text = gestor.Nitsolicitanteorden
        txt_telefono_gestor.Text = gestor.Telefonosolicitanteorden
        txt_nombre_comercial_gestor.Text = gestor.Nombrecomercialsolicitanteorden
        cmb_empresa.SelectedValue = gestor.Idempresa
        cmb_tipos.SelectedValue = gestor.Idtipogestor

        txt_id_usuario.Text = gestor.Idusuario

        Usuario = BO.BOtbl_scm_usuarios.getAll(vCon, New Entity.tbl_scm_usuarios_Entity With {.Idusuario = gestor.Idusuario})

        If Usuario.Rows.Count <> 0 Then
            lbl_usuario.Text = Usuario.Rows(0)("med_nombre").ToString()
            txt_usuario.Text = usuario.Rows(0)("med_loginid").ToString()

        Else
            lbl_usuario.Text = ""
            txt_id_usuario.Text = 0
        End If


        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_nombre_gestor.Text = ""
        txt_direccion_gestor.Text = ""
        cmb_empresa.SelectedIndex = 0
        cmb_tipos.SelectedIndex = 0
        txt_nombre_comercial_gestor.Text = ""
        txt_id_usuario.Text = "1"
        txt_nit_gestor.Text = ""
        txt_telefono_gestor.Text = ""
        txt_usuario.Text = ""

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

    Private Sub cargar_tipos()
        Dim iDTipoG As DataTable
        iDTipoG = BO.BOtbl_tipo_gestor.getAll(vCon, New Entity.tbl_tipo_gestor_Entity)
        cmb_tipos.Items.Clear()


        cmb_tipos.DataSource = iDTipoG
        cmb_tipos.DisplayMember = "nombre_tipo_gestor"
        cmb_tipos.ValueMember = "id_tipo_gestor"

    End Sub

    Private Sub cargar_empresas()
        Dim iDGenero As DataTable
        iDGenero = BO.BOtbl_empresas.getAll(vCon, New Entity.tbl_empresas_Entity)
        cmb_empresa.Items.Clear()


        cmb_empresa.DataSource = iDGenero
        cmb_empresa.DisplayMember = "emp_nombre"
        cmb_empresa.ValueMember = "id_empresa"

    End Sub
End Class