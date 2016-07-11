<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empresa
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
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_usuario = New System.Windows.Forms.Panel()
        Me.cmb_estado_empresa = New System.Windows.Forms.CheckBox()
        Me.txt_nit_empresa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_direccion_empresa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grd_empresas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_nuevo = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_editar = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.btn_salir = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.pnl_usuario.SuspendLayout()
        CType(Me.grd_empresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_empresa
        '
        Me.txt_empresa.Location = New System.Drawing.Point(84, 5)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(249, 20)
        Me.txt_empresa.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnl_usuario)
        Me.Panel1.Controls.Add(Me.grd_empresas)
        Me.Panel1.Location = New System.Drawing.Point(3, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 249)
        Me.Panel1.TabIndex = 5
        '
        'pnl_usuario
        '
        Me.pnl_usuario.Controls.Add(Me.cmb_estado_empresa)
        Me.pnl_usuario.Controls.Add(Me.txt_nit_empresa)
        Me.pnl_usuario.Controls.Add(Me.Label4)
        Me.pnl_usuario.Controls.Add(Me.txt_direccion_empresa)
        Me.pnl_usuario.Controls.Add(Me.Label3)
        Me.pnl_usuario.Controls.Add(Me.txt_empresa)
        Me.pnl_usuario.Controls.Add(Me.Label2)
        Me.pnl_usuario.Location = New System.Drawing.Point(12, 3)
        Me.pnl_usuario.Name = "pnl_usuario"
        Me.pnl_usuario.Size = New System.Drawing.Size(348, 89)
        Me.pnl_usuario.TabIndex = 9
        '
        'cmb_estado_empresa
        '
        Me.cmb_estado_empresa.AutoSize = True
        Me.cmb_estado_empresa.Location = New System.Drawing.Point(277, 59)
        Me.cmb_estado_empresa.Name = "cmb_estado_empresa"
        Me.cmb_estado_empresa.Size = New System.Drawing.Size(56, 17)
        Me.cmb_estado_empresa.TabIndex = 7
        Me.cmb_estado_empresa.Text = "Activo"
        Me.cmb_estado_empresa.UseVisualStyleBackColor = True
        '
        'txt_nit_empresa
        '
        Me.txt_nit_empresa.Location = New System.Drawing.Point(84, 57)
        Me.txt_nit_empresa.Name = "txt_nit_empresa"
        Me.txt_nit_empresa.Size = New System.Drawing.Size(91, 20)
        Me.txt_nit_empresa.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nit"
        '
        'txt_direccion_empresa
        '
        Me.txt_direccion_empresa.Location = New System.Drawing.Point(84, 31)
        Me.txt_direccion_empresa.Name = "txt_direccion_empresa"
        Me.txt_direccion_empresa.Size = New System.Drawing.Size(249, 20)
        Me.txt_direccion_empresa.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Empresa"
        '
        'grd_empresas
        '
        Me.grd_empresas.AllowUserToAddRows = False
        Me.grd_empresas.AllowUserToDeleteRows = False
        Me.grd_empresas.AllowUserToOrderColumns = True
        Me.grd_empresas.AllowUserToResizeColumns = False
        Me.grd_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_empresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.usuarios, Me.nombre, Me.Nit})
        Me.grd_empresas.Location = New System.Drawing.Point(12, 98)
        Me.grd_empresas.MultiSelect = False
        Me.grd_empresas.Name = "grd_empresas"
        Me.grd_empresas.RowHeadersVisible = False
        Me.grd_empresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_empresas.Size = New System.Drawing.Size(348, 146)
        Me.grd_empresas.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empresas"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(665, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Salir"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btn_nuevo)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.btn_eliminar)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btn_editar)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btncancelar)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btn_guardar)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btn_salir)
        Me.Panel2.Location = New System.Drawing.Point(0, 326)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(708, 65)
        Me.Panel2.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(401, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nuevo"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.Image = Global.SCM_VB.My.Resources.Resources.plainicon_com_54405_512px_4d4
        Me.btn_nuevo.Location = New System.Drawing.Point(403, 3)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(35, 35)
        Me.btn_nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_nuevo.TabIndex = 21
        Me.btn_nuevo.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(450, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Eliminar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.Image = Global.SCM_VB.My.Resources.Resources.substract
        Me.btn_eliminar.Location = New System.Drawing.Point(454, 3)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(35, 35)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_eliminar.TabIndex = 19
        Me.btn_eliminar.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(506, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Editar"
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editar.Image = Global.SCM_VB.My.Resources.Resources.pen
        Me.btn_editar.Location = New System.Drawing.Point(507, 3)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(35, 35)
        Me.btn_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_editar.TabIndex = 17
        Me.btn_editar.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(552, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cancelar"
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.Image = Global.SCM_VB.My.Resources.Resources.close2
        Me.btncancelar.Location = New System.Drawing.Point(559, 3)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(35, 35)
        Me.btncancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncancelar.TabIndex = 15
        Me.btncancelar.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(607, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Guardar"
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.Image = Global.SCM_VB.My.Resources.Resources.Floppy_disk_512
        Me.btn_guardar.Location = New System.Drawing.Point(610, 3)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(35, 35)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 13
        Me.btn_guardar.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.Image = Global.SCM_VB.My.Resources.Resources.inside
        Me.btn_salir.Location = New System.Drawing.Point(661, 3)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(35, 35)
        Me.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCM_VB.My.Resources.Resources.man2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'id_usuario
        '
        Me.id_usuario.DataPropertyName = "id_empresa"
        Me.id_usuario.HeaderText = "id_usuario"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.Visible = False
        '
        'usuarios
        '
        Me.usuarios.DataPropertyName = "emp_nombre"
        Me.usuarios.HeaderText = "Empresa"
        Me.usuarios.Name = "usuarios"
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre.DataPropertyName = "emp_direccion"
        Me.nombre.HeaderText = "Direccion"
        Me.nombre.Name = "nombre"
        '
        'Nit
        '
        Me.Nit.DataPropertyName = "emp_nit"
        Me.Nit.HeaderText = "Nit"
        Me.Nit.Name = "Nit"
        '
        'frm_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_empresa"
        Me.ShowIcon = False
        Me.Text = "Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.pnl_usuario.ResumeLayout(False)
        Me.pnl_usuario.PerformLayout()
        CType(Me.grd_empresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_empresa As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_salir As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grd_empresas As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_guardar As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btncancelar As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_eliminar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_editar As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_nuevo As PictureBox
    Friend WithEvents pnl_usuario As Panel
    Friend WithEvents txt_nit_empresa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_direccion_empresa As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents Panel1 As Panel
    Friend WithEvents cmb_estado_empresa As CheckBox
    Friend WithEvents id_usuario As DataGridViewTextBoxColumn
    Friend WithEvents usuarios As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Nit As DataGridViewTextBoxColumn
End Class
