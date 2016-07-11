
Imports BO
Imports Entity


Public Class frm_login
    Dim vCon As New Entity.Connection_Entity

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        vCon = Conexiones.EntityConnection_DB("", "")
    End Sub

    Private Sub btn_ingresar_login_Click(sender As Object, e As EventArgs) Handles btn_ingresar_login.Click
        frm_MDI.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        System.Windows.Forms.Application.Exit()
    End Sub
End Class