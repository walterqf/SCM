Public Class frm_empresa
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim empresa As New Entity.tbl_empresas_Entity

        empresa.Empnombre = txt_empresa.Text
        empresa.Empdireccion = txt_direccion_empresa.Text
        empresa.Empnit = txt_nit_empresa.Text
        empresa.Empactivo = Convert.ToInt32(cmb_estado_empresa.Checked)

        empresa.Idempresa = id




        If editar = False Then
            BO.BOtbl_empresas.Insert(vCon, empresa)

        Else
            BO.BOtbl_empresas.Update(vCon, empresa)
        End If
        btn_acciones(5)
        editar = False
        limpiar()
        cargar_empresas()
    End Sub

    Private Sub cargar_empresas()
        grd_empresas.AutoGenerateColumns = False
        grd_empresas.DataSource = BO.BOtbl_empresas.getAll(vCon, New Entity.tbl_empresas_Entity With {.Empactivo = 1})
    End Sub

    Private Sub fr_cat_empresas_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        cargar_empresas()
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        txt_empresa.Enabled = estado
        txt_nit_empresa.Enabled = estado
        txt_direccion_empresa.Enabled = estado
        cmb_estado_empresa.Enabled = estado

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        BO.BOtbl_empresas.Delete(vCon, New Entity.tbl_empresas_Entity With {.Idempresa = id})
        btn_acciones(2)
        cargar_empresas()
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

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_empresas.CellDoubleClick
        'Dim value As Object = grd_usuarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        id = Val(grd_empresas.Rows(e.RowIndex).Cells(0).Value.ToString)
        Dim empresas As New Entity.tbl_empresas_Entity
        empresas = BO.BOtbl_empresas.getSingle(vCon, New Entity.tbl_empresas_Entity With {.Idempresa = id})

        txt_empresa.Text = empresas.Empnombre
        txt_direccion_empresa.Text = empresas.Empdireccion
        txt_nit_empresa.Text = empresas.Empnit

        cmb_estado_empresa.Checked = Convert.ToBoolean(empresas.Empactivo)


        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub limpiar()
        txt_empresa.Text = ""
        txt_direccion_empresa.Text = ""
        txt_nit_empresa.Text = ""
        cmb_estado_empresa.Checked = False

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