Public Class frm_ingreso_rutas
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim rtas As New Entity.tbl_scm_ruta_Entity
        rtas.Rtanombre = txt_desc.Text
        rtas.Rtaestado = Convert.ToInt32(cks_estado.Checked)
        rtas.Idruta = id
        If editar = False Then
            BO.BOtbl_scm_ruta.Insert(vCon, rtas)
        Else
            BO.BOtbl_scm_ruta.Update(vCon, rtas)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_rutas()
    End Sub

    Private Sub cargar_rutas()
        grd_rutas.AutoGenerateColumns = False
        grd_rutas.DataSource = BO.BOGeneral.GetAllrutas(vCon, New Entity.tbl_scm_ruta_Entity)
    End Sub
    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_rutas()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_desc.Enabled = estado
        cks_estado.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_scm_usuarios.Delete(vCon, New Entity.tbl_scm_usuarios_Entity With {.Idusuario = id})
        btn_acciones(2)
        cargar_rutas()
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_rutas.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_rutas.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim rta As New Entity.tbl_scm_ruta_Entity
        rta = BO.BOtbl_scm_ruta.getSingle(vCon, New Entity.tbl_scm_ruta_Entity With {.Idruta = id})
        txt_desc.Text = rta.Rtanombre
        cks_estado.Checked = Convert.ToBoolean(rta.Rtaestado)
        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_desc.Text = ""
        cks_estado.Checked = False
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