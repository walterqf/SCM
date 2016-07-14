
Imports BO
Imports Entity



Public Class frm_login
    Dim vCon As New Entity.Connection_Entity

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
    End Sub

    Private Sub btn_ingresar_login_Click(sender As Object, e As EventArgs) Handles btn_ingresar_login.Click
        validar_login()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        System.Windows.Forms.Application.Exit()
    End Sub




    Private Sub validar_login()
        Try


            Dim data_tmp As New DataTable
            data_tmp = BO.BOtbl_scm_usuarios.getAll(vCon, New Entity.tbl_scm_usuarios_Entity With {.Medloginid = txt_usuario.Text, .Medpassid = Globales.Encripta(txt_contrasena.Text)})
            If data_tmp.Rows.Count > 0 Then
                My.Settings.user = txt_usuario.Text
                My.Settings.id_user = data_tmp.Rows(0)("id_usuario").ToString()
                'frm_MDI.Show()
                frm_selector_empresa.Show()
                Me.Hide()
            Else
                MessageBox.Show("Ingrese correctamente sus credenciales",
            "Inicio de sesión inválido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
            End If


        Catch ex As Exception

        End Try

    End Sub
End Class