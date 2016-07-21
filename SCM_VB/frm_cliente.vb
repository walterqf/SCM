Public Class frm_cliente
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim cliente As New Entity.tbl_scm_cliente_Entity
        cliente.Cliprimernombre = txt_primer_nombre.Text
        cliente.Clisegundonombre = txt_primer_nombre.Text
        cliente.Cliprimerapellido = txt_primer_nombre.Text
        cliente.Clisegundoapellido = txt_segundo_apellido.Text
        cliente.Clitelefono = txt_tel.Text
        cliente.Clidireccion = txt_dir.Text
        cliente.Clinit = txt_nit.Text
        cliente.Idcliente = id
        If editar = False Then
            BO.BOtbl_scm_cliente.Insert(vCon, cliente)
        Else
            BO.BOtbl_scm_cliente.Update(vCon, cliente)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_usuarios()
    End Sub

    Private Sub cargar_usuarios()
        grd_usuarios.AutoGenerateColumns = False
        grd_usuarios.DataSource = BO.BOtbl_scm_cliente.getAll(vCon, New Entity.tbl_scm_cliente_Entity)
    End Sub

    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_usuarios()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_primer_nombre.Enabled = estado
        txt_segundo_nombre.Enabled = estado
        txt_primer_apellido.Enabled = estado
        txt_segundo_apellido.Enabled = estado
        txt_dir.Enabled = estado
        txt_nit.Enabled = estado
        txt_tel.Enabled = estado
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
        cargar_usuarios()
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_usuarios.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_usuarios.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim cliente As New Entity.tbl_scm_cliente_Entity
        cliente = BO.BOtbl_scm_cliente.getSingle(vCon, New Entity.tbl_scm_cliente_Entity With {.Idcliente = id})

        txt_primer_nombre.Text = cliente.Cliprimernombre
        txt_segundo_nombre.Text = cliente.Clisegundonombre
        txt_primer_apellido.Text = cliente.Clisegundoapellido
        txt_segundo_apellido.Text = cliente.Clisegundoapellido
        txt_dir.Text = cliente.Clidireccion
        txt_nit.Text = cliente.Clinit
        txt_tel.Text = cliente.Clitelefono

        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_primer_nombre.Text = ""
        txt_segundo_nombre.Text = ""
        txt_primer_apellido.Text = ""
        txt_segundo_apellido.Text = ""
        txt_dir.Text = ""
        txt_nit.Text = ""
        txt_tel.Text = ""
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