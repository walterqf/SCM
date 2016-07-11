Public Class frm_medidas
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim medidas As New Entity.tbl_scm_medidas_productos_Entity
        medidas.Meddescripcion = txt_nombre_medida.Text
        medidas.Medsimbolo = txt_simbolo_medida.Text

        medidas.Idmedida = id
        If editar = False Then
            BO.BOtbl_scm_medidas_productos.Insert(vCon, medidas)
        Else
            BO.BOtbl_scm_medidas_productos.Update(vCon, medidas)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_medidas()
    End Sub

    Private Sub cargar_medidas()
        grd_medidas.AutoGenerateColumns = False
        grd_medidas.DataSource = BO.BOtbl_scm_medidas_productos.getAll(vCon, New Entity.tbl_scm_medidas_productos_Entity)
    End Sub

    Private Sub frm_medidas_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_medidas()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_nombre_medida.Enabled = estado
        txt_simbolo_medida.Enabled = estado

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_scm_medidas_productos.Delete(vCon, New Entity.tbl_scm_medidas_productos_Entity With {.Idmedida = id})
        btn_acciones(2)
        cargar_medidas()
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_medidas.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_medidas.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim medidas As New Entity.tbl_scm_medidas_productos_Entity
        medidas = BO.BOtbl_scm_medidas_productos.getSingle(vCon, New Entity.tbl_scm_medidas_productos_Entity With {.Idmedida = id})

        txt_nombre_medida.Text = medidas.Meddescripcion
        txt_simbolo_medida.Text = medidas.Medsimbolo

        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_nombre_medida.Text = ""
        txt_simbolo_medida.Text = ""

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