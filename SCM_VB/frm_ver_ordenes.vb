Public Class frm_ver_ordenes
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Public idO As Integer
    Public fecha As String
    Dim id As Integer
    Private Sub fr_cat_usuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        cargar_ordenes()
    End Sub
    Private Sub cargar_ordenes()
        grd_ordenes.AutoGenerateColumns = False
        grd_ordenes.DataSource = BO.BOGeneral.get_ordenes_ent(vCon, New Entity.tbl_scm_ordenes_entrega_Entity)

    End Sub

    Private Sub grd_ordenes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_ordenes.CellDoubleClick
        Dim data_tmp As New DataTable
        id = Val(grd_ordenes.Rows(e.RowIndex).Cells(0).Value.ToString)
        data_tmp = BO.BOGeneral.getalldetor(vCon, New Entity.tbl_scm_detalle_ordenes_Entity With {.Idordenesentrega = id})
        lb_no_orden.Text = "Detalle Orden No. " + id.ToString
        grd_carga_det.AutoGenerateColumns = False
        grd_carga_det.DataSource = data_tmp
        Panel1.Visible = True
        lb_no_orden.Visible = True
        grd_carga_det.Visible = True
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class