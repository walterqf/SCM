Public Class frm_productos
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim productos As New Entity.tbl_scm_productos_Entity
        productos.Prddescripcion = txt_nombre_producto.Text
        productos.Idmedida = cmb_medida.SelectedValue
        productos.Prdestado = 1
        productos.Prdnivel = 1

        productos.Idproducto = id
        If txt_nombre_producto.Text <> "" Then
            If editar = False Then
                BO.BOtbl_scm_productos.Insert(vCon, productos)
            Else
                BO.BOtbl_scm_productos.Update(vCon, productos)
            End If
            btn_acciones(5)
            editar = False
            limpiar()
            cargar_productos()
        Else

        End If

    End Sub

    Private Sub cargar_productos()
        grd_productos.AutoGenerateColumns = False
        grd_productos.DataSource = BO.BOGeneral.get_productos(vCon)
    End Sub

    Private Sub frm_productos_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_tipos()
        cargar_productos()

    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        cmb_medida.Enabled = estado
        txt_nombre_producto.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_scm_productos.Delete(vCon, New Entity.tbl_scm_productos_Entity With {.Idproducto = id})
        btn_acciones(2)
        cargar_productos()
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_productos.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_productos.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim usuario As New DataTable


        usuario = BO.BOtbl_scm_productos.getAll(vCon, New Entity.tbl_scm_productos_Entity With {.Idproducto = id})

        If usuario.Rows.Count <> 0 Then

            txt_nombre_producto.Text = usuario.Rows(0)("prd_descripcion").ToString()
            cmb_medida.SelectedValue = usuario.Rows(0)("id_medida").ToString()

        Else
            txt_nombre_producto.Text = ""

        End If


        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_nombre_producto.Text = ""
        cmb_medida.SelectedIndex = 0


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


    Private Sub cargar_tipos()
        Dim iDTipoG As DataTable
        iDTipoG = BO.BOtbl_scm_medidas_productos.getAll(vCon, New Entity.tbl_scm_medidas_productos_Entity)
        cmb_medida.Items.Clear()


        cmb_medida.DataSource = iDTipoG
        cmb_medida.DisplayMember = "med_descripcion"
        cmb_medida.ValueMember = "id_medida"

    End Sub




End Class