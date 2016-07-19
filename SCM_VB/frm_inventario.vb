Imports System.Threading

Public Class frm_inventario
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer
    Dim id_estado As Integer
    Private trd As Thread

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub cargar_inventarios()
        Dim data_tmp As DataTable
        data_tmp = BO.BOtbl_inventario.getAll(vCon, New Entity.tbl_inventario_Entity With {.Idbodega = Val(IIf(cmb_bodega.SelectedValue Is Nothing, 4000004, cmb_bodega.SelectedValue))})
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.Rows.Clear()
        For Z As Integer = 0 To data_tmp.Rows.Count - 1
            grd_ordenes.Rows.Add(data_tmp.Rows(Z)("id_inventario"), data_tmp.Rows(Z)("prd_descripcion"), data_tmp.Rows(Z)("fecha_modif"), data_tmp.Rows(Z)("cantidad_real"), data_tmp.Rows(Z)("costo_unitario_producto"), "")
            Select Case Val(data_tmp.Rows(Z)("flag_real"))
                Case 0
                    grd_ordenes.Rows(Z).Cells(5).Style.BackColor = Color.Red
                Case 1
                    grd_ordenes.Rows(Z).Cells(5).Style.BackColor = Color.Yellow
                Case 2
                    grd_ordenes.Rows(Z).Cells(5).Style.BackColor = Color.Green
            End Select
        Next
        mostrar_panel(False)
    End Sub

    Private Sub guardar()

    End Sub

    Private Sub cargar_gestores()
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.DataSource = BO.BOGeneral.GetAllGestores(vCon, New Entity.tbl_gestor_ordenes_Entity)
    End Sub

    Private Sub frm_inventario_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        'mostrar_detalle(False)
        cargar_empresas()
        cargar_inventarios()

    End Sub

    Private Sub mostrar_detalle(ByVal estado As Boolean)
        'pnl_detalle.Visible = estado
    End Sub

    'Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
    '    id_estado = 4
    '    recorrer_seleccionados()
    'End Sub

    'Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
    '    id_estado = 2
    '    recorrer_seleccionados()
    'End Sub

    Private Sub cargar_empresas()
        Dim iDEmpresa As DataTable
        iDEmpresa = BO.BOtbl_empresas.getAll(vCon, New Entity.tbl_empresas_Entity)
        cmb_empresa.Items.Clear()
        cmb_empresa.DataSource = iDEmpresa
        cmb_empresa.DisplayMember = "emp_nombre"
        cmb_empresa.ValueMember = "id_empresa"
        cargar_bodega()
    End Sub

    Private Sub cargar_bodega()
        Dim iDBodega As DataTable
        iDBodega = BO.BOtbl_bodegas.getAll(vCon, New Entity.tbl_bodegas_Entity With {.Idempresa = Val(cmb_empresa.SelectedValue)})
        cmb_bodega.DataSource = Nothing
        cmb_bodega.DataSource = iDBodega
        cmb_bodega.DisplayMember = "nombre_bodega"
        cmb_bodega.ValueMember = "id_bodega"
        cargar_inventarios()
    End Sub


    Private Sub cmb_empresa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_empresa.SelectionChangeCommitted
        cargar_bodega()

    End Sub

    Private Sub cmb_bodega_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_bodega.SelectionChangeCommitted
        cargar_inventarios()
    End Sub

    Private Sub grd_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs)
        mostrar_detalle(False)
    End Sub

    Private Sub grd_gestores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellDoubleClick
        id = Val(grd_ordenes.Rows(e.RowIndex).Cells(1).Value.ToString)
        Dim data_tmp As New DataTable
        data_tmp = BO.BOGeneral.get_detalle_producto(vCon, New Entity.tbl_inventario_Entity With {.Idinventario = id})

        If data_tmp.Rows.Count > 0 Then
            lbl_producto.Text = data_tmp.Rows(0)("prd_descripcion")
            lbl_cantidad.Text = data_tmp.Rows(0)("cantidad_real")
            lbl_medida.Text = data_tmp.Rows(0)("med_descripcion")

            txtinvmin.Text = data_tmp.Rows(0)("producto_minimo")
            txtinvopt.Text = data_tmp.Rows(0)("producto_maximo")
            txtinvmax.Text = data_tmp.Rows(0)("producto_optimo")

        Else
            lbl_producto.Text = ""
            lbl_cantidad.Text = ""
            lbl_medida.Text = ""

            txtinvmin.Text = ""
            txtinvopt.Text = ""
            txtinvmax.Text = ""
        End If

        mostrar_panel(True)
    End Sub


    Private Sub btn_agregar_deta_Click(sender As Object, e As EventArgs) Handles btn_agregar_deta.Click
        Dim inventario As New Entity.tbl_inventario_Entity
        inventario = BO.BOtbl_inventario.getSingle(vCon, New Entity.tbl_inventario_Entity With {.Idinventario = id})

        inventario.Productominimo = Convert.ToInt32(txtinvmin.Text)
        inventario.Productooptimo = Convert.ToInt32(txtinvopt.Text)
        inventario.Productomaximo = Convert.ToInt32(txtinvmax.Text)


        BO.BOtbl_inventario.Update(vCon, inventario)
        mostrar_panel(False)
        cargar_inventarios()

    End Sub

    Private Sub mostrar_panel(ByVal estado As Boolean)
        pnl_inventario.Visible = estado
    End Sub

    Private Sub carga_detalle()
        'Dim data_detalle As DataTable
        'data_detalle = BO.BOGeneral.get_detalle_orden(vCon, New Entity.tbl_ordenes_detalle_Entity With {.Idorden = id})
        'grd_detalle.AutoGenerateColumns = False
        'If data_detalle.Rows.Count > 0 Then
        '    grd_detalle.DataSource = data_detalle
        'Else
        '    grd_detalle.DataSource = Nothing
        'End If
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
                cargar_inventarios()
            Catch ex As Exception

            End Try

            'ENVIO EL GRUPO DE IDS  A ACTUALIZAR


        End If
    End Sub
    Private Sub cargar_inventarios_ruta()

    End Sub

    Private Sub lbl_close_Click_1(sender As Object, e As EventArgs) Handles lbl_close.Click
        mostrar_panel(False)
    End Sub


End Class