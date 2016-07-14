<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_selector_empresa
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
        Me.lst_empresa = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lst_empresa
        '
        Me.lst_empresa.FormattingEnabled = True
        Me.lst_empresa.Location = New System.Drawing.Point(5, 13)
        Me.lst_empresa.Name = "lst_empresa"
        Me.lst_empresa.Size = New System.Drawing.Size(267, 199)
        Me.lst_empresa.TabIndex = 0
        '
        'frm_selector_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lst_empresa)
        Me.Name = "frm_selector_empresa"
        Me.Text = "frm_selector_empresa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst_empresa As ListBox
End Class
