Public Class frm_empleados
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim empleados As New Entity.tbl_scm_empleados_Entity
        empleados.Empprimernombre = txt_primer_nombre.Text
        empleados.Empsegundonombre = txt_primer_nombre.Text
        empleados.Empprimerapellido = txt_primer_nombre.Text
        empleados.Empsegundoapellido = txt_segundo_apellido.Text
        empleados.Emptelefono = txt_tel.Text
        empleados.Empsueldo = txt_salario.Text
        empleados.Empcargo = cb_cargos.SelectedValue.ToString
        empleados.Idempleado = id
        If editar = False Then
            BO.BOtbl_scm_empleados.Insert(vCon, empleados)
        Else
            BO.BOtbl_scm_empleados.Update(vCon, empleados)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_usuarios()
    End Sub

    Private Sub cargar_usuarios()
        grd_usuarios.AutoGenerateColumns = False
        grd_usuarios.DataSource = BO.BOtbl_scm_empleados.getAll(vCon, New Entity.tbl_scm_empleados_Entity)
    End Sub

    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_usuarios()
        cargar_combbox()
    End Sub
    Private Sub cargar_combbox()
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Descripcion") = "Piloto"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Descripcion") = "Gerente"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Descripcion") = "Programador"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Descripcion") = "Bodeguero"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Descripcion") = "Mecánico"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Descripcion") = "Mensajero"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Descripcion") = "Vendedor"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Descripcion") = "Cajero"
        dt.Rows.Add(dr)

        cb_cargos.DataSource = dt
        cb_cargos.ValueMember = "Descripcion"
        cb_cargos.DisplayMember = "Descripcion"
    End Sub
    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_primer_nombre.Enabled = estado
        txt_segundo_nombre.Enabled = estado
        txt_primer_apellido.Enabled = estado
        txt_segundo_apellido.Enabled = estado
        txt_salario.Enabled = estado
        cb_cargos.Enabled = estado
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
        Dim empleados As New Entity.tbl_scm_empleados_Entity
        empleados = BO.BOtbl_scm_empleados.getSingle(vCon, New Entity.tbl_scm_empleados_Entity With {.Idempleado = id})

        txt_primer_nombre.Text = empleados.Empprimernombre
        txt_segundo_nombre.Text = empleados.Empsegundonombre
        txt_primer_apellido.Text = empleados.Empprimerapellido
        txt_segundo_apellido.Text = empleados.Empsegundoapellido
        txt_salario.Text = empleados.Empsueldo
        cb_cargos.DisplayMember = empleados.Empcargo
        txt_tel.Text = empleados.Emptelefono

        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_primer_nombre.Text = ""
        txt_segundo_nombre.Text = ""
        txt_primer_apellido.Text = ""
        txt_segundo_apellido.Text = ""
        txt_salario.Text = ""
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