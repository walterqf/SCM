Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frm_MDI

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub



    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub IngresoDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeUsuariosToolStripMenuItem.Click

        iniciar_frm(frm_cat_usuarios)

    End Sub


    Private Sub iniciar_frm(ByVal frm As Form)

        frm.WindowState = FormWindowState.Maximized
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub frm_MDI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub StatusStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub TipoDeGestoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeGestoresToolStripMenuItem.Click
        iniciar_frm(frm_tipo_gestor)
    End Sub

    Private Sub IngresoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeProductosToolStripMenuItem.Click
        iniciar_frm(frm_gestor)
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        iniciar_frm(frm_empresa)
    End Sub

    Private Sub BodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BodegaToolStripMenuItem.Click
        iniciar_frm(frm_bodega)
    End Sub

    Private Sub TiposMedidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposMedidasToolStripMenuItem.Click
        iniciar_frm(frm_medidas)
    End Sub

    Private Sub MonedasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem.Click
        iniciar_frm(frm_monedas)
    End Sub
End Class
