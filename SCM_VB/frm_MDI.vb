﻿Imports System.ComponentModel
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

    Private Sub CreacionDeOrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreacionDeOrdenToolStripMenuItem.Click
        iniciar_frm(frm_orden_egreso)
    End Sub

    Private Sub frm_MDI_Load(sender As Object, e As EventArgs) Handles Me.Load
        ToolStripStatusLabel2.Text = "    Usuario: " + My.Settings.user
        lst_tool_empresa.Text = "Empresa: " + My.Settings.id_empresa + " - " + My.Settings.empresa_nombre
    End Sub

    Private Sub IngresoDeProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresoDeProductosToolStripMenuItem1.Click
        iniciar_frm(frm_productos)
    End Sub

    Private Sub AutorizacionDeOrdenDeEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizacionDeOrdenDeEgresoToolStripMenuItem.Click
        iniciar_frm(frm_autoriza_orden_egreso)
    End Sub

    Private Sub RecepcionDeOrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepcionDeOrdenesToolStripMenuItem.Click
        iniciar_frm(frm_ordenes_entrega)
    End Sub

    Private Sub ExistenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciasToolStripMenuItem.Click
        iniciar_frm(frm_inventario)
    End Sub

    Private Sub CreacionOrdenDeIngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreacionOrdenDeIngresoToolStripMenuItem.Click
        iniciar_frm(frm_orden_ingreso)
    End Sub

    Private Sub AutorizacionOrdenesDeIngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizacionOrdenesDeIngresoToolStripMenuItem.Click
        iniciar_frm(frm_autorizacion_orden_ingreso)
    End Sub

    Private Sub OrdenesDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesDeInventarioToolStripMenuItem.Click
        iniciar_frm(frm_reporte_ordenes)
    End Sub

    Private Sub VerOrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerOrdenesToolStripMenuItem.Click
        iniciar_frm(frm_ver_ordenes)
    End Sub

    Private Sub AsignarRutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarRutaToolStripMenuItem.Click
        iniciar_frm(frm_asignar_ruta)
    End Sub

    Private Sub ValidacionDeOrdenesDeEntregaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidacionDeOrdenesDeEntregaToolStripMenuItem.Click
        iniciar_frm(frm_validacion_entregas_orden)
    End Sub

    Private Sub IngresoDeRutasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeRutasToolStripMenuItem.Click
        iniciar_frm(frm_ingreso_rutas)
    End Sub

    Private Sub IngresoDeVehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeVehiculosToolStripMenuItem.Click
        iniciar_frm(frm_vehiculos)
    End Sub

    Private Sub IngresoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeClientesToolStripMenuItem.Click
        iniciar_frm(frm_cliente)
    End Sub

    Private Sub IngresoDeEmpreadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeEmpreadoToolStripMenuItem.Click
        iniciar_frm(frm_empleados)
    End Sub
End Class
