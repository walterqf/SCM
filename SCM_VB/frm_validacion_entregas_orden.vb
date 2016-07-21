Public Class frm_validacion_entregas_orden
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim ordenes As New Entity.tbl_scm_ordenes_entrega_Entity

        If cks_entrega.Checked = True Then
            BO.BOGeneral.modificar_estados_ordmod(vCon, id.ToString, "3")
            cargar_ordenes()
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_ordenes()
    End Sub

    Private Sub cargar_ordenes()
        grd_ordenes.DataSource = Nothing
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.DataSource = BO.BOGeneral.get_orden_mod(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idscmestadoorden = "2"})
    End Sub

    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_ordenes()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_login_id.Enabled = estado
        cks_entrega.Enabled = estado
        'txt_nombre.Enabled = estado
        'txt_contrasena.Enabled = estado
        'cks_estado.Enabled = estado
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellDoubleClick
        id = Val(grd_ordenes.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim ordenes As Entity.tbl_scm_ordenes_entrega_Entity

        ordenes = BO.BOtbl_scm_ordenes_entrega.getSingle(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idordenesentrega = id})
        txt_login_id.Text = ordenes.Orddescripcion
        btn_guardar.Enabled = True
        Console.Write("")
        btn_editar.Enabled = True
    End Sub

    Private Sub limpiar()
        txt_login_id.Text = ""
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

End Class