Public Class frm_autoriza_orden_egreso
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer
    Dim id_estado As Integer
    Dim id_autrech As Integer
    Dim ordencompra As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub cargar_ordenes_pendientes()
        Dim data_tmp As DataTable
        data_tmp = BO.BOGeneral.GetAll_ordenes_empresa_estado_inv(vCon, Convert.ToInt32(cmb_empresa.SelectedValue), 1, 1)
        grd_ordenes.AutoGenerateColumns = False
        'grd_ordenes.DataSource = data_tmp
        ''''-----------
        'Dim data_tmp As DataTable
        'data_tmp = BO.BOtbl_inventario.getAll(vCon, New Entity.tbl_inventario_Entity With {.Idbodega = Val(IIf(cmb_bodega.SelectedValue Is Nothing, 4000004, cmb_bodega.SelectedValue))})
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.Rows.Clear()
        For Z As Integer = 0 To data_tmp.Rows.Count - 1
            grd_ordenes.Rows.Add(Convert.ToBoolean(data_tmp.Rows(Z)("seleccionar")), data_tmp.Rows(Z)("id_orden"), data_tmp.Rows(Z)("nombre_gestor"), data_tmp.Rows(Z)("fecha_fomat"), data_tmp.Rows(Z)("total_productos"), "", data_tmp.Rows(Z)("estado_detalle_total"))
            Select Case Val(data_tmp.Rows(Z)("estado_detalle_total"))
                Case 1
                    grd_ordenes.Rows(Z).Cells(5).Style.BackColor = Color.Red
                Case 0
                    grd_ordenes.Rows(Z).Cells(5).Style.BackColor = Color.Green
            End Select
        Next
        'mostrar_panel(False)


        ''''-----------



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
        id_autrech = Val(grd_ordenes.Rows(grd_ordenes.CurrentRow.Index).Cells(1).Value.ToString)
        rechazarsolicitud()
        'recorrer_seleccionados()
    End Sub

    Private Sub rechazar_orden(ByVal id_rech As Integer)
        Dim encabezado As New Entity.tbl_ordenes_encabezado_Entity
        encabezado = BO.BOtbl_ordenes_encabezado.getSingle(vCon, New Entity.tbl_ordenes_encabezado_Entity With {.Idorden = id_rech})

        encabezado.Idestadoorden = 4
        Try
            BO.BOtbl_ordenes_encabezado.Update(vCon, encabezado)
        Catch ex As Exception

        End Try
        pnl_detalle.Visible = False
        cargar_ordenes_pendientes()
    End Sub


    Private Sub rechazarsolicitud()
        Dim result As Integer = MessageBox.Show("Desea rechazar la siguiente orden " + id_autrech.ToString, "Rechazo de solicitud", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            rechazar_orden(id_autrech)
        End If
    End Sub


    Private Sub autorizarsolicitud()
        ordencompra = Val(grd_ordenes.Rows(grd_ordenes.CurrentRow.Index).Cells(6).Value.ToString)

        Dim result As Integer = MessageBox.Show("Desea Autorizar la siguiente orden " + id_autrech.ToString, "Rechazo de solicitud", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then


            Select Case ordencompra
                Case 1
                    subvalidar_ordencompra()

                   ''malo
                Case 0
                    '' nDA
            End Select
        End If
    End Sub

    Private Sub subvalidar_ordencompra()
        Dim result As Integer = MessageBox.Show("Desea generar la orden de compra necesaria para la orden:  " + id_autrech.ToString, "Generacion de orden de compra", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            BO.BOGeneral.crear_orden_compra_auto(vCon, id_autrech)
            cargar_ordenes_pendientes()
        End If
    End Sub


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        id_estado = 2
        'recorrer_seleccionados_autorizar()
        id_autrech = Val(grd_ordenes.Rows(grd_ordenes.CurrentRow.Index).Cells(1).Value.ToString)
        autorizarsolicitud()
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


    Private Sub recorrer_seleccionados_autorizar()
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