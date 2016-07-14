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

    Private Sub frm_selector_empresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub seleccionar_empresa()

        My.Settings.id_empresa = lst_empresa.SelectedValue.ToString
        My.Settings.empresa_nombre = lst_empresa.Text

        frm_MDI.Show()
        Me.Hide()

    End Sub

    Private Sub btn_ingresar_login_Click(sender As Object, e As EventArgs) Handles btn_ingresar_login.Click
        seleccionar_empresa()
    End Sub
End Class