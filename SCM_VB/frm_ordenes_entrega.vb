Public Class frm_ordenes_entrega
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Public idO As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim ordenes As New Entity.tbl_scm_ordenes_entrega_Entity
        'usuarios.Medloginid = txt_login_id.Text
        ' usuarios.Medpassid = Globales.Encripta(txt_contrasena.Text)
        ' ordenes.Orddescripcion = txt_nombre.Text
        ' usuarios.Medestado = Convert.ToInt32(cks_estado.Checked)



        ordenes.Idordenesentrega = idO
        If editar = False Then
            BO.BOtbl_scm_ordenes_entrega.Insert(vCon, ordenes)
        Else
            BO.BOtbl_scm_ordenes_entrega.Update(vCon, ordenes)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_ordenes()
    End Sub

    Private Sub cargar_ordenes()
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.DataSource = BO.BOtbl_scm_ordenes_entrega.getAll(vCon, New Entity.tbl_scm_ordenes_entrega_Entity)

    End Sub

    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        'cargar_ordenes()
        cargar_ordenes_pendientes()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        'txt_login_id.Enabled = estado
        ' txt_nombre.Enabled = estado
        'txt_contrasena.Enabled = estado
        ' cks_estado.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_scm_ordenes_entrega.Delete(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idordenesentrega = idO})
        btn_acciones(2)
        cargar_ordenes()
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

    Private Sub grd_usuarios_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        idO = Val(grd_ordenes.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim ordenes As New Entity.tbl_scm_ordenes_entrega_Entity
        ordenes = BO.BOtbl_scm_ordenes_entrega.getSingle(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idordenesentrega = idO})

        'txt_login_id.Text = usuario.Medloginid
        ' txt_nombre.Text = ordenes.Orddescripcion
        'txt_contrasena.Text = Globales.DesEncripta(usuario.Medpassid)
        'cks_estado.Checked = Convert.ToBoolean(usuario.Medestado)

        Console.Write("")
        btn_acciones(6)
    End Sub



    Private Sub btn_detalle_Click(sender As Object, e As EventArgs)
        frm_detalle_ordenes.Show()
    End Sub

    Private Sub grd_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellContentClick

    End Sub


    Private Sub cargar_ordenes_pendientes()
        Dim data_pendiente As New DataTable
        data_pendiente = BO.BOtbl_ordenes_encabezado.getAll(vCon, New Entity.tbl_ordenes_encabezado_Entity With {.Idtipoorden = 1, .Idestadoorden = 1})
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.DataSource = data_pendiente


    End Sub
End Class