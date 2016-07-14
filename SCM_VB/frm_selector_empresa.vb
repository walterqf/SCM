Public Class frm_selector_empresa
    Dim vCon As New Entity.Connection_Entity
    Dim editar As Boolean
    Dim id As Integer

    Private Sub frm_selector_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vCon = Conexiones.EntityConnection_DB("", "")
        cargar_empresas()
    End Sub

    Private Sub cargar_empresas()
        Dim iDGenero As DataTable
        iDGenero = BO.BOtbl_empresas.getAll(vCon, New Entity.tbl_empresas_Entity)
        lst_empresa.Items.Clear()


        lst_empresa.DataSource = iDGenero
        lst_empresa.DisplayMember = "emp_nombre"
        lst_empresa.ValueMember = "id_empresa"

    End Sub


End Class