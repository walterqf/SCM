Public Class frm_detalle_ordenes
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer
    Dim idorden_g As Integer
    Dim conteo As Integer = 0
    Dim ids, detfecha As String

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub guardar()
        Dim deto As New Entity.tbl_scm_detalle_ordenes_Entity
        Dim inv As New Entity.tbl_inventario_Entity
        Dim ord As New Entity.tbl_scm_ordenes_entrega_Entity
        Dim detor As New Entity.tbl_ordenes_detalle_Entity
        Dim detorca As New Entity.tbl_ordenes_encabezado_Entity
        Dim SoloNumero As String = ""
        Dim index As Integer
        Dim data_tmp, data_tmp1 As New DataTable

        Dim delimiter As Char = ","
        Dim substrings() As String = ids.Split(delimiter)
        MessageBox.Show(ids)
        If ids <> Nothing Then
            data_tmp = BO.BOtbl_scm_ordenes_entrega.getAll(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idorden = idorden_g})
            If data_tmp.Rows.Count > 0 Then
                For Each substring In substrings
                    data_tmp1 = BO.BOtbl_scm_detalle_ordenes.getAll(vCon, New Entity.tbl_scm_detalle_ordenes_Entity With {.Idordenesdetalle = substring})

                    If data_tmp1.Rows.Count > 0 Then
                        detor = BO.BOtbl_ordenes_detalle.getSingle(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idordenesdetalle = substring})
                        deto.Idordenesentrega = data_tmp.Rows(0).Item(0)
                        deto.Detcostototal = detor.Cantidadproducto * detor.Costounitarioproducto
                        deto.Detcantidadproducto = detor.Cantidadproducto
                        deto.Detfechasolicitud = detfecha
                        deto.Detfechaentrega = dt_fecha_entrega.Value.ToString
                        deto.Idproducto = detor.Idproducto
                        deto.Detvolumenpeso = "0.0"
                        deto.Idbodega = detor.Idbodega
                        deto.Idordenesdetalle = detor.Idordenesdetalle
                    Else
                        detor = BO.BOtbl_ordenes_detalle.getSingle(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idordenesdetalle = substring})
                        deto.Idordenesentrega = data_tmp.Rows(0).Item(0)
                        deto.Detcostototal = detor.Cantidadproducto * detor.Costounitarioproducto
                        deto.Detcantidadproducto = detor.Cantidadproducto
                        deto.Detfechasolicitud = detfecha
                        deto.Detfechaentrega = dt_fecha_entrega.Value.ToString
                        deto.Idproducto = detor.Idproducto
                        deto.Detvolumenpeso = "0.0"
                        deto.Idbodega = detor.Idbodega
                        deto.Idordenesdetalle = detor.Idordenesdetalle

                        BO.BOtbl_scm_detalle_ordenes.Insert(vCon, deto)
                    End If
                Next
            Else
                ord.Idorden = idorden_g
                ord.Orddescripcion = "Orden No." + Convert.ToString(idorden_g)
                ord.Idcliente = cb_cliente.SelectedValue
                BO.BOtbl_scm_ordenes_entrega.Insert(vCon, ord)
                For Each substring In substrings
                    data_tmp1 = BO.BOtbl_scm_detalle_ordenes.getAll(vCon, New Entity.tbl_scm_detalle_ordenes_Entity With {.Idordenesdetalle = substring})
                    If data_tmp1.Rows.Count > 0 Then

                        detor = BO.BOtbl_ordenes_detalle.getSingle(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idordenesdetalle = substring})

                        deto.Idordenesentrega = data_tmp.Rows(0).Item(0)
                        deto.Detcostototal = detor.Cantidadproducto * detor.Costounitarioproducto
                        deto.Detcantidadproducto = detor.Cantidadproducto
                        deto.Detfechasolicitud = detfecha
                        deto.Detfechaentrega = dt_fecha_entrega.Value.ToString
                        deto.Idproducto = detor.Idproducto
                        deto.Detvolumenpeso = "0.0"
                        deto.Idbodega = detor.Idbodega
                        deto.Idordenesdetalle = detor.Idordenesdetalle
                    Else
                        data_tmp = BO.BOtbl_scm_ordenes_entrega.getAll(vCon, New Entity.tbl_scm_ordenes_entrega_Entity With {.Idorden = idorden_g})
                        detor = BO.BOtbl_ordenes_detalle.getSingle(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idordenesdetalle = substring})

                        deto.Idordenesentrega = data_tmp.Rows(0).Item(0)
                        deto.Detcostototal = detor.Cantidadproducto * detor.Costounitarioproducto
                        deto.Detcantidadproducto = detor.Cantidadproducto
                        deto.Detfechasolicitud = detfecha
                        deto.Detfechaentrega = dt_fecha_entrega.Value.ToString
                        deto.Idproducto = detor.Idproducto
                        deto.Detvolumenpeso = "0.0"
                        deto.Idbodega = detor.Idbodega
                        deto.Idordenesdetalle = detor.Idordenesdetalle

                        BO.BOtbl_scm_detalle_ordenes.Insert(vCon, deto)
                    End If
                Next

            End If
        Else
            ord.Idorden = idorden_g
            ord.Orddescripcion = "Orden No." + Convert.ToString(idorden_g)
            ord.Idcliente = cb_cliente.SelectedValue
            BO.BOtbl_scm_ordenes_entrega.Insert(vCon, ord)
        End If

        If (grd_carga_det.Rows.Count = conteo) Then
            detorca.Idestadoorden = "6"
            detorca.Idorden = idorden_g.ToString
            ord.Idscmestadoorden = "1"
            ord.Idordenesentrega = idorden_g.ToString
            BO.BOGeneral.transportar_orden_entrega(vCon, idorden_g)
            BO.BOGeneral.modificar_estados_ord(vCon, idorden_g.ToString, "1")
            MessageBox.Show("Orden aprobada exitosamente",
            "Orden Verificada",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1)
            Me.Close()
        End If

        btn_acciones(5)
        editar = False
        limpiar()
    End Sub


    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load

        detfecha = ""
        vCon = Conexiones.EntityConnection_DB("", "")
        frm_habilitar(False)
        btn_acciones(4)
        idorden_g = frm_ordenes_entrega.idO
        detfecha = frm_ordenes_entrega.fecha
        cargar_detalle()
        Dim iDproducto, iDruta, iDestado, iDcliente As DataTable
            iDproducto = BO.BOtbl_scm_productos.getAll(vCon, New Entity.tbl_scm_productos_Entity)
            iDruta = BO.BOtbl_scm_ruta.getAll(vCon, New Entity.tbl_scm_ruta_Entity)
            iDestado = BO.BOtbl_scm_estado_orden.getAll(vCon, New Entity.tbl_scm_estado_orden_Entity)
            iDcliente = BO.BOtbl_scm_cliente.getAll(vCon, New Entity.tbl_scm_cliente_Entity)
            cb_cliente.Items.Clear()
            cb_cliente.DataSource = iDcliente
            cb_cliente.DisplayMember = "nombrecompleto"
        cb_cliente.ValueMember = "id_cliente"
    End Sub

    Private Sub frm_habilitar(ByVal estado As Boolean)
        grd_carga_det.Enabled = estado
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        frm_habilitar(True)
        btn_acciones(1)
        limpiar()
        editar = False
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
        recorrer_seleccionados()
        guardar()

    End Sub

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub limpiar()
        'txt_login_id.Text = ""
        'txt_nombre.Text = ""
        'txt_contrasena.Text = ""
        'cks_estado.Checked = False
    End Sub

    Private Sub btn_acciones(ByVal estado As Integer)
        Select Case (estado)
            Case 1 'Nuevo
                btn_nuevo.Enabled = False
                btn_eliminar.Enabled = False
                btn_editar.Enabled = False
                btncancelar.Enabled = True
                btn_guardar.Enabled = True
                grd_carga_det.Enabled = True
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

    Private Sub grd_usuarios_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles grd_carga_det.CellDoubleClick
        id = Val(grd_carga_det.Rows(e.RowIndex).Cells(1).Value.ToString)
        Dim deto As New Entity.tbl_ordenes_detalle_Entity
        Dim pro As New Entity.tbl_scm_productos_Entity
        deto = BO.BOtbl_ordenes_detalle.getSingle(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idordenesdetalle = id})
        pro = BO.BOtbl_scm_productos.getSingle(vCon, New Entity.tbl_scm_productos_Entity With {.Idproducto = deto.Idproducto})
        Console.Write("")
        btn_acciones(6)
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub


    Private Sub cargar_detalle()
        Dim data_tmp As New DataTable
        data_tmp = BO.BOGeneral.get_detalle_orden(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idorden = idorden_g})
        grd_carga_det.AutoGenerateColumns = False
        grd_carga_det.DataSource = data_tmp
    End Sub



    Private Sub recorrer_seleccionados()
        ids = ""
        conteo = 0

        grd_carga_det.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grd_carga_det.ClearSelection()
        grd_carga_det.CurrentCell = Nothing
        Dim intCount As Integer = 0

        For Each row As DataGridViewRow In grd_carga_det.Rows

            Console.WriteLine(grd_carga_det.Rows(intCount).Cells(1).Value)

            If Convert.ToBoolean(grd_carga_det.Rows(intCount).Cells(0).Value) = True Then
                If conteo = 0 Then
                    ids = (grd_carga_det.Rows(intCount).Cells(1).Value.ToString)
                Else
                    ids = ids + "," + (grd_carga_det.Rows(intCount).Cells(1).Value.ToString)
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
        End If

    End Sub



End Class