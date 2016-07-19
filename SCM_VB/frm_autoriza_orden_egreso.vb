Public Class frm_autoriza_orden_egreso
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer
    Dim id_estado As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub cargar_ordenes_pendientes()
        Dim data_tmp As DataTable
        data_tmp = BO.BOGeneral.GetAll_ordenes_empresa_estado(vCon, Convert.ToInt32(cmb_empresa.SelectedValue), 1, 1)
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.DataSource = data_tmp
    End Sub

    Private Sub guardar()

    End Sub

    Private Sub cargar_gestores()
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.DataSource = BO.BOGeneral.GetAllGestores(vCon, New Entity.tbl_gestor_ordenes_Entity)
    End Sub

    Private Sub frm_autoriza_orden_egreso_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        mostrar_detalle(False)
        cargar_empresas()
        cargar_ordenes_pendientes()
    End Sub

    Private Sub mostrar_detalle(ByVal estado As Boolean)
        pnl_detalle.Visible = estado
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        id_estado = 4
        recorrer_seleccionados()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        id_estado = 2
        recorrer_seleccionados()
    End Sub

    Private Sub cargar_empresas()
        Dim iDGenero As DataTable
        iDGenero = BO.BOtbl_empresas.getAll(vCon, New Entity.tbl_empresas_Entity)
        cmb_empresa.Items.Clear()
        cmb_empresa.DataSource = iDGenero
        cmb_empresa.DisplayMember = "emp_nombre"
        cmb_empresa.ValueMember = "id_empresa"
    End Sub

    Private Sub cmb_empresa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_empresa.SelectionChangeCommitted
        mostrar_detalle(False)
        cargar_ordenes_pendientes()
    End Sub

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        mostrar_detalle(False)
    End Sub

    Private Sub grd_gestores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellDoubleClick
        id = Val(grd_ordenes.Rows(e.RowIndex).Cells(1).Value.ToString)
        lbl_no_orden.Text = "No. " + id.ToString()
        carga_detalle()
        mostrar_detalle(True)
    End Sub

    Private Sub carga_detalle()
        Dim data_detalle As DataTable
        data_detalle = BO.BOGeneral.get_detalle_orden(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idorden = id})
        grd_detalle.AutoGenerateColumns = False
        If data_detalle.Rows.Count > 0 Then
            grd_detalle.DataSource = data_detalle
        Else
            grd_detalle.DataSource = Nothing
        End If
    End Sub

    Private Sub recorrer_seleccionados()
        Dim conteo As Integer = 0
        Dim ids As String = ""
        grd_ordenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grd_ordenes.ClearSelection()
        grd_ordenes.CurrentCell = Nothing
        Dim intCount As Integer = 0

        For Each row As DataGridViewRow In grd_ordenes.Rows

            Console.WriteLine(grd_ordenes.Rows(intCount).Cells(1).Value)

            If Convert.ToBoolean(grd_ordenes.Rows(intCount).Cells(0).Value) = True Then
                If conteo = 0 Then
                    ids = (grd_ordenes.Rows(intCount).Cells(1).Value.ToString)
                Else
                    ids = ids + "," + (grd_ordenes.Rows(intCount).Cells(1).Value.ToString)
                End If
                conteo = conteo + 1
            Else

            End If

            intCount += 1
        Next row



        If conteo = 0 Then
            Console.WriteLine("NO")
        Else
            Console.WriteLine("SI" + ids)
            Try
                BO.BOGeneral.modificar_estados_lote(vCon, ids, id_estado.ToString)
                cargar_ordenes_pendientes()
            Catch ex As Exception

            End Try

            'ENVIO EL GRUPO DE IDS  A ACTUALIZAR


        End If
    End Sub
    Private Sub cargar_ordenes_pendientes_ruta()

    End Sub

End Class