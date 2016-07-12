Public Class frm_bodega
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()


        Dim bodegas As New Entity.tbl_bodegas_Entity
        bodegas.Nombrebodega = txt_nombre_bodega.Text
        bodegas.Idempresa = cmb_empresa.SelectedValue
        bodegas.Bdgdireccion = txt_direccion.Text
        bodegas.Idusuario = txt_id_usuario.Text


        bodegas.Idbodega = id

        If txt_id_usuario.Text <> "0" Then
            If editar = False Then
                BO.BOtbl_bodegas.Insert(vCon, bodegas)
            Else
                BO.BOtbl_bodegas.Update(vCon, bodegas)
            End If
            btn_acciones(5)
            editar = False
            limpiar()
            cargar_bodegas()
        Else

        End If

    End Sub

    Private Sub cargar_bodegas()
        grd_bodegas.AutoGenerateColumns = False
        grd_bodegas.DataSource = BO.BOtbl_bodegas.getAll(vCon, New Entity.tbl_bodegas_Entity)
    End Sub

    Private Sub frm_bodega_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_empresas()
        cargar_bodegas()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_nombre_bodega.Enabled = estado
        txt_direccion.Enabled = estado
        cmb_empresa.Enabled = estado
        txt_encargado.Enabled = estado

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_bodegas.Delete(vCon, New Entity.tbl_bodegas_Entity With {.Idusuario = id})
        btn_acciones(2)
        cargar_bodegas()
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

        Try
            guardar()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_bodegas.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_bodegas.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim bodega As New Entity.tbl_bodegas_Entity
        Dim usuario As New DataTable


        bodega = BO.BOtbl_bodegas.getSingle(vCon, New Entity.tbl_bodegas_Entity With {.Idbodega = id})

        txt_nombre_bodega.Text = bodega.Nombrebodega
        txt_direccion.Text = bodega.Bdgdireccion
        cmb_empresa.SelectedValue = Val(bodega.Idempresa)
        txt_id_usuario.Text = bodega.Idusuario

        usuario = BO.BOtbl_scm_usuarios.getAll(vCon, New Entity.tbl_scm_usuarios_Entity With {.Idusuario = bodega.Idusuario})

        If usuario.Rows.Count <> 0 Then
            lbl_usuario.Text = usuario.Rows(0)("med_nombre").ToString()
            txt_encargado.Text = usuario.Rows(0)("med_loginid").ToString()

        Else
            lbl_usuario.Text = ""
            txt_id_usuario.Text = 0
        End If

        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_nombre_bodega.Text = ""
        txt_direccion.Text = ""
        lbl_usuario.Text = ""
        txt_id_usuario.Text = 0
        txt_encargado.Text = ""
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

    Private Sub txt_encargado_TextChanged(sender As Object, e As EventArgs) Handles txt_encargado.TextChanged

    End Sub

    Private Sub txt_encargado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_encargado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim usuario As New Entity.tbl_scm_usuarios_Entity
            Dim data_tmp As New DataTable
            data_tmp = BO.BOtbl_scm_usuarios.getAll(vCon, New Entity.tbl_scm_usuarios_Entity With {.Medloginid = txt_encargado.Text})

            If data_tmp.Rows.Count <> 0 Then
                lbl_usuario.Text = data_tmp.Rows(0)("med_nombre").ToString()
                txt_id_usuario.Text = data_tmp.Rows(0)("id_usuario").ToString()

            Else
                lbl_usuario.Text = ""
                txt_id_usuario.Text = 0
            End If

        End If



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