Public Class frm_tipo_gestor
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim tipos As New Entity.tbl_tipo_gestor_Entity
        tipos.Nombretipogestor = txt_tipo.Text

        tipos.Idtipogestor = id
        If editar = False Then
            BO.BOtbl_tipo_gestor.Insert(vCon, tipos)
        Else
            BO.BOtbl_tipo_gestor.Update(vCon, tipos)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_tipos()
    End Sub

    Private Sub cargar_tipos()
        grd_tipos.AutoGenerateColumns = False
        grd_tipos.DataSource = BO.BOtbl_tipo_gestor.getAll(vCon, New Entity.tbl_tipo_gestor_Entity)
    End Sub

    Private Sub frm_tipo_gestor_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_tipos()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_tipo.Enabled = estado

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_tipo_gestor.Delete(vCon, New Entity.tbl_tipo_gestor_Entity With {.Idtipogestor = id})
        btn_acciones(2)
        cargar_tipos()
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_tipos.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_tipos.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim tipos As New Entity.tbl_tipo_gestor_Entity
        tipos = BO.BOtbl_tipo_gestor.getSingle(vCon, New Entity.tbl_tipo_gestor_Entity With {.Idtipogestor = id})

        txt_tipo.Text = tipos.Nombretipogestor


        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_tipo.Text = ""


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