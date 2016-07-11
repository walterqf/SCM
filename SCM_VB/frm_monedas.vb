Public Class frm_monedas
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim monedas As New Entity.tbl_monedas_Entity
        monedas.Nombremoneda = txt_nombre_moneda.Text
        monedas.Simbolomoneda = txt_simbolo_moneda.Text

        monedas.Idmoneda = id
        If editar = False Then
            BO.BOtbl_monedas.Insert(vCon, monedas)
        Else
            BO.BOtbl_monedas.Update(vCon, monedas)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_monedas()
    End Sub

    Private Sub cargar_monedas()
        grd_monedas.AutoGenerateColumns = False
        grd_monedas.DataSource = BO.BOtbl_monedas.getAll(vCon, New Entity.tbl_monedas_Entity)
    End Sub

    Private Sub frm_monedas_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_monedas()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_nombre_moneda.Enabled = estado
        txt_simbolo_moneda.Enabled = estado

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_monedas.Delete(vCon, New Entity.tbl_monedas_Entity With {.Idmoneda = id})
        btn_acciones(2)
        cargar_monedas()
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_monedas.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_monedas.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim monedas As New Entity.tbl_monedas_Entity
        monedas = BO.BOtbl_monedas.getSingle(vCon, New Entity.tbl_monedas_Entity With {.Idmoneda = id})

        txt_nombre_moneda.Text = monedas.Nombremoneda
        txt_simbolo_moneda.Text = monedas.Simbolomoneda

        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_nombre_moneda.Text = ""
        txt_simbolo_moneda.Text = ""

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