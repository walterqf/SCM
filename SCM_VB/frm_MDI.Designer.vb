<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MDI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MDI))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Catalogos = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposMedidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeGestoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonedasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoDeProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Procesos = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenesDeEgresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreacionDeOrdenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizacionDeOrdenDeEgresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenesDeEntregaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecepcionDeOrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lst_tool_empresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Catalogos, Me.Procesos, Me.Reportes, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Catalogos
        '
        Me.Catalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeProductosToolStripMenuItem, Me.BodegaToolStripMenuItem, Me.TiposMedidasToolStripMenuItem, Me.TipoDeGestoresToolStripMenuItem, Me.MonedasToolStripMenuItem, Me.EmpresasToolStripMenuItem, Me.IngresoDeUsuariosToolStripMenuItem, Me.IngresoDeProductosToolStripMenuItem1})
        Me.Catalogos.Name = "Catalogos"
        Me.Catalogos.Size = New System.Drawing.Size(72, 20)
        Me.Catalogos.Text = "&Catalogos"
        '
        'IngresoDeProductosToolStripMenuItem
        '
        Me.IngresoDeProductosToolStripMenuItem.Name = "IngresoDeProductosToolStripMenuItem"
        Me.IngresoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.IngresoDeProductosToolStripMenuItem.Text = "Ingreso de gestores"
        '
        'BodegaToolStripMenuItem
        '
        Me.BodegaToolStripMenuItem.Name = "BodegaToolStripMenuItem"
        Me.BodegaToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.BodegaToolStripMenuItem.Text = "Ingreso de bodega"
        '
        'TiposMedidasToolStripMenuItem
        '
        Me.TiposMedidasToolStripMenuItem.Name = "TiposMedidasToolStripMenuItem"
        Me.TiposMedidasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TiposMedidasToolStripMenuItem.Text = "Ingreso de tipo de medida"
        '
        'TipoDeGestoresToolStripMenuItem
        '
        Me.TipoDeGestoresToolStripMenuItem.Name = "TipoDeGestoresToolStripMenuItem"
        Me.TipoDeGestoresToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TipoDeGestoresToolStripMenuItem.Text = "Ingreso de tipo de gestor"
        '
        'MonedasToolStripMenuItem
        '
        Me.MonedasToolStripMenuItem.Name = "MonedasToolStripMenuItem"
        Me.MonedasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.MonedasToolStripMenuItem.Text = "Ingreso de moneda"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.EmpresasToolStripMenuItem.Text = "Ingreso de empresa"
        '
        'IngresoDeUsuariosToolStripMenuItem
        '
        Me.IngresoDeUsuariosToolStripMenuItem.Name = "IngresoDeUsuariosToolStripMenuItem"
        Me.IngresoDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.IngresoDeUsuariosToolStripMenuItem.Text = "Ingreso de usuarios"
        '
        'IngresoDeProductosToolStripMenuItem1
        '
        Me.IngresoDeProductosToolStripMenuItem1.Name = "IngresoDeProductosToolStripMenuItem1"
        Me.IngresoDeProductosToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.IngresoDeProductosToolStripMenuItem1.Text = "Ingreso de productos"
        '
        'Procesos
        '
        Me.Procesos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenesDeEgresoToolStripMenuItem, Me.OrdenesDeEntregaToolStripMenuItem, Me.InventarioToolStripMenuItem})
        Me.Procesos.Name = "Procesos"
        Me.Procesos.Size = New System.Drawing.Size(66, 20)
        Me.Procesos.Text = "&Procesos"
        '
        'OrdenesDeEgresoToolStripMenuItem
        '
        Me.OrdenesDeEgresoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreacionDeOrdenToolStripMenuItem, Me.AutorizacionDeOrdenDeEgresoToolStripMenuItem})
        Me.OrdenesDeEgresoToolStripMenuItem.Name = "OrdenesDeEgresoToolStripMenuItem"
        Me.OrdenesDeEgresoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OrdenesDeEgresoToolStripMenuItem.Text = "Ordenes de egreso"
        '
        'CreacionDeOrdenToolStripMenuItem
        '
        Me.CreacionDeOrdenToolStripMenuItem.Name = "CreacionDeOrdenToolStripMenuItem"
        Me.CreacionDeOrdenToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.CreacionDeOrdenToolStripMenuItem.Text = "Creacion orden de egreso"
        '
        'AutorizacionDeOrdenDeEgresoToolStripMenuItem
        '
        Me.AutorizacionDeOrdenDeEgresoToolStripMenuItem.Name = "AutorizacionDeOrdenDeEgresoToolStripMenuItem"
        Me.AutorizacionDeOrdenDeEgresoToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AutorizacionDeOrdenDeEgresoToolStripMenuItem.Text = "Autorizacion orden de egreso"
        '
        'OrdenesDeEntregaToolStripMenuItem
        '
        Me.OrdenesDeEntregaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecepcionDeOrdenesToolStripMenuItem})
        Me.OrdenesDeEntregaToolStripMenuItem.Name = "OrdenesDeEntregaToolStripMenuItem"
        Me.OrdenesDeEntregaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OrdenesDeEntregaToolStripMenuItem.Text = "Ordenes de entrega"
        '
        'RecepcionDeOrdenesToolStripMenuItem
        '
        Me.RecepcionDeOrdenesToolStripMenuItem.Name = "RecepcionDeOrdenesToolStripMenuItem"
        Me.RecepcionDeOrdenesToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.RecepcionDeOrdenesToolStripMenuItem.Text = "Recepcion de ordenes"
        '
        'Reportes
        '
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Size = New System.Drawing.Size(65, 20)
        Me.Reportes.Text = "&Reportes"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lst_tool_empresa, Me.ToolStripStatusLabel2})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'lst_tool_empresa
        '
        Me.lst_tool_empresa.Name = "lst_tool_empresa"
        Me.lst_tool_empresa.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExistenciasToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ExistenciasToolStripMenuItem
        '
        Me.ExistenciasToolStripMenuItem.Name = "ExistenciasToolStripMenuItem"
        Me.ExistenciasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExistenciasToolStripMenuItem.Text = "Existencias"
        '
        'frm_MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.SCM_VB.My.Resources.Resources.yr1qegc8j0f1enws84uo1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frm_MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SCM - Supply chain management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Catalogos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Procesos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Reportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lst_tool_empresa As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents TipoDeGestoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BodegaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposMedidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonedasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenesDeEgresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreacionDeOrdenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorizacionDeOrdenDeEgresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoDeProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OrdenesDeEntregaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecepcionDeOrdenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistenciasToolStripMenuItem As ToolStripMenuItem
End Class
