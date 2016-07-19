<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inventario
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_inventario = New System.Windows.Forms.Panel()
        Me.pnl_usuario = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_bodega = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_empresa = New System.Windows.Forms.ComboBox()
        Me.grd_ordenes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_actualizar = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.btn_salir = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtinvmin = New System.Windows.Forms.TextBox()
        Me.txtinvopt = New System.Windows.Forms.TextBox()
        Me.txtinvmax = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.labe155 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.lbl_medida = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.btn_agregar_deta = New System.Windows.Forms.PictureBox()
        Me.lbl_deta = New System.Windows.Forms.Label()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Totales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.pnl_inventario.SuspendLayout()
        Me.pnl_usuario.SuspendLayout()
        CType(Me.grd_ordenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_actualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_agregar_deta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnl_inventario)
        Me.Panel1.Controls.Add(Me.pnl_usuario)
        Me.Panel1.Controls.Add(Me.grd_ordenes)
        Me.Panel1.Location = New System.Drawing.Point(3, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 412)
        Me.Panel1.TabIndex = 5
        '
        'pnl_inventario
        '
        Me.pnl_inventario.Controls.Add(Me.btn_agregar_deta)
        Me.pnl_inventario.Controls.Add(Me.lbl_deta)
        Me.pnl_inventario.Controls.Add(Me.lbl_cantidad)
        Me.pnl_inventario.Controls.Add(Me.lbl_medida)
        Me.pnl_inventario.Controls.Add(Me.lbl_close)
        Me.pnl_inventario.Controls.Add(Me.lbl_producto)
        Me.pnl_inventario.Controls.Add(Me.Label12)
        Me.pnl_inventario.Controls.Add(Me.Label11)
        Me.pnl_inventario.Controls.Add(Me.labe155)
        Me.pnl_inventario.Controls.Add(Me.Label9)
        Me.pnl_inventario.Controls.Add(Me.Label8)
        Me.pnl_inventario.Controls.Add(Me.Label4)
        Me.pnl_inventario.Controls.Add(Me.txtinvmax)
        Me.pnl_inventario.Controls.Add(Me.txtinvopt)
        Me.pnl_inventario.Controls.Add(Me.txtinvmin)
        Me.pnl_inventario.Location = New System.Drawing.Point(608, 98)
        Me.pnl_inventario.Name = "pnl_inventario"
        Me.pnl_inventario.Size = New System.Drawing.Size(307, 215)
        Me.pnl_inventario.TabIndex = 10
        Me.pnl_inventario.Visible = False
        '
        'pnl_usuario
        '
        Me.pnl_usuario.Controls.Add(Me.Label3)
        Me.pnl_usuario.Controls.Add(Me.cmb_bodega)
        Me.pnl_usuario.Controls.Add(Me.Label15)
        Me.pnl_usuario.Controls.Add(Me.cmb_empresa)
        Me.pnl_usuario.Location = New System.Drawing.Point(12, 3)
        Me.pnl_usuario.Name = "pnl_usuario"
        Me.pnl_usuario.Size = New System.Drawing.Size(590, 68)
        Me.pnl_usuario.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Bodega"
        '
        'cmb_bodega
        '
        Me.cmb_bodega.FormattingEnabled = True
        Me.cmb_bodega.Location = New System.Drawing.Point(74, 37)
        Me.cmb_bodega.Name = "cmb_bodega"
        Me.cmb_bodega.Size = New System.Drawing.Size(221, 21)
        Me.cmb_bodega.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Empresa"
        '
        'cmb_empresa
        '
        Me.cmb_empresa.FormattingEnabled = True
        Me.cmb_empresa.Location = New System.Drawing.Point(74, 10)
        Me.cmb_empresa.Name = "cmb_empresa"
        Me.cmb_empresa.Size = New System.Drawing.Size(221, 21)
        Me.cmb_empresa.TabIndex = 10
        '
        'grd_ordenes
        '
        Me.grd_ordenes.AllowUserToAddRows = False
        Me.grd_ordenes.AllowUserToDeleteRows = False
        Me.grd_ordenes.AllowUserToResizeColumns = False
        Me.grd_ordenes.AllowUserToResizeRows = False
        Me.grd_ordenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_ordenes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grd_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_ordenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.nombre, Me.usuarios, Me.Totales, Me.Costo, Me.estado})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_ordenes.DefaultCellStyle = DataGridViewCellStyle5
        Me.grd_ordenes.Location = New System.Drawing.Point(12, 77)
        Me.grd_ordenes.MultiSelect = False
        Me.grd_ordenes.Name = "grd_ordenes"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_ordenes.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grd_ordenes.RowHeadersVisible = False
        Me.grd_ordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_ordenes.Size = New System.Drawing.Size(590, 323)
        Me.grd_ordenes.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Inventario"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1124, 41)
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
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_actualizar)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btncancelar)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btn_guardar)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btn_salir)
        Me.Panel2.Location = New System.Drawing.Point(0, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1167, 65)
        Me.Panel2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(957, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Actualizar"
        Me.Label2.Visible = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar.Image = Global.SCM_VB.My.Resources.Resources.refresh4
        Me.btn_actualizar.Location = New System.Drawing.Point(964, 3)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(35, 35)
        Me.btn_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_actualizar.TabIndex = 17
        Me.btn_actualizar.TabStop = False
        Me.btn_actualizar.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(845, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Rechazar"
        Me.Label7.Visible = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.Image = Global.SCM_VB.My.Resources.Resources.close2
        Me.btncancelar.Location = New System.Drawing.Point(852, 3)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(35, 35)
        Me.btncancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncancelar.TabIndex = 15
        Me.btncancelar.TabStop = False
        Me.btncancelar.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(903, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Autorizar"
        Me.Label6.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.Image = Global.SCM_VB.My.Resources.Resources.Floppy_disk_512
        Me.btn_guardar.Location = New System.Drawing.Point(906, 3)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(35, 35)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 13
        Me.btn_guardar.TabStop = False
        Me.btn_guardar.Visible = False
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.Image = Global.SCM_VB.My.Resources.Resources.inside
        Me.btn_salir.Location = New System.Drawing.Point(1120, 3)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(35, 35)
        Me.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCM_VB.My.Resources.Resources.refresh
        Me.PictureBox1.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'txtinvmin
        '
        Me.txtinvmin.Location = New System.Drawing.Point(233, 77)
        Me.txtinvmin.Name = "txtinvmin"
        Me.txtinvmin.Size = New System.Drawing.Size(64, 20)
        Me.txtinvmin.TabIndex = 0
        '
        'txtinvopt
        '
        Me.txtinvopt.Location = New System.Drawing.Point(233, 103)
        Me.txtinvopt.Name = "txtinvopt"
        Me.txtinvopt.Size = New System.Drawing.Size(64, 20)
        Me.txtinvopt.TabIndex = 1
        '
        'txtinvmax
        '
        Me.txtinvmax.Location = New System.Drawing.Point(233, 129)
        Me.txtinvmax.Name = "txtinvmax"
        Me.txtinvmax.Size = New System.Drawing.Size(64, 20)
        Me.txtinvmax.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Inv. minimo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Inv. optimo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Inv. maximo"
        '
        'labe155
        '
        Me.labe155.AutoSize = True
        Me.labe155.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labe155.Location = New System.Drawing.Point(14, 48)
        Me.labe155.Name = "labe155"
        Me.labe155.Size = New System.Drawing.Size(48, 13)
        Me.labe155.TabIndex = 17
        Me.labe155.Text = "Medida"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Producto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(180, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Existencia"
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.Location = New System.Drawing.Point(71, 23)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(0, 13)
        Me.lbl_producto.TabIndex = 20
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.Location = New System.Drawing.Point(285, 9)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(15, 13)
        Me.lbl_close.TabIndex = 22
        Me.lbl_close.Text = "X"
        '
        'lbl_medida
        '
        Me.lbl_medida.AutoSize = True
        Me.lbl_medida.Location = New System.Drawing.Point(71, 48)
        Me.lbl_medida.Name = "lbl_medida"
        Me.lbl_medida.Size = New System.Drawing.Size(0, 13)
        Me.lbl_medida.TabIndex = 23
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(238, 48)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(0, 13)
        Me.lbl_cantidad.TabIndex = 24
        '
        'btn_agregar_deta
        '
        Me.btn_agregar_deta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_deta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agregar_deta.Image = Global.SCM_VB.My.Resources.Resources.Floppy_disk_512
        Me.btn_agregar_deta.Location = New System.Drawing.Point(262, 155)
        Me.btn_agregar_deta.Name = "btn_agregar_deta"
        Me.btn_agregar_deta.Size = New System.Drawing.Size(35, 35)
        Me.btn_agregar_deta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_agregar_deta.TabIndex = 26
        Me.btn_agregar_deta.TabStop = False
        '
        'lbl_deta
        '
        Me.lbl_deta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_deta.AutoSize = True
        Me.lbl_deta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deta.Location = New System.Drawing.Point(259, 193)
        Me.lbl_deta.Name = "lbl_deta"
        Me.lbl_deta.Size = New System.Drawing.Size(45, 13)
        Me.lbl_deta.TabIndex = 25
        Me.lbl_deta.Text = "Guardar"
        '
        'id_usuario
        '
        Me.id_usuario.DataPropertyName = "id_inventario"
        Me.id_usuario.HeaderText = "No. orden"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.Width = 80
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre.DataPropertyName = "prd_descripcion"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'usuarios
        '
        Me.usuarios.DataPropertyName = "fecha_modif"
        Me.usuarios.HeaderText = "Fecha"
        Me.usuarios.Name = "usuarios"
        '
        'Totales
        '
        Me.Totales.DataPropertyName = "cantidad_real"
        Me.Totales.HeaderText = "Exitencia"
        Me.Totales.Name = "Totales"
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "costo_unitario_producto"
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'estado
        '
        Me.estado.HeaderText = ""
        Me.estado.Name = "estado"
        Me.estado.Width = 20
        '
        'frm_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_inventario"
        Me.ShowIcon = False
        Me.Text = "Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.pnl_inventario.ResumeLayout(False)
        Me.pnl_inventario.PerformLayout()
        Me.pnl_usuario.ResumeLayout(False)
        Me.pnl_usuario.PerformLayout()
        CType(Me.grd_ordenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_actualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_agregar_deta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_salir As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grd_ordenes As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_guardar As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btncancelar As PictureBox
    Friend WithEvents pnl_usuario As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents cmb_empresa As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_actualizar As PictureBox
    Friend WithEvents pnl_inventario As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_bodega As ComboBox
    Friend WithEvents lbl_producto As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents labe155 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtinvmax As TextBox
    Friend WithEvents txtinvopt As TextBox
    Friend WithEvents txtinvmin As TextBox
    Friend WithEvents lbl_cantidad As Label
    Friend WithEvents lbl_medida As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents btn_agregar_deta As PictureBox
    Friend WithEvents lbl_deta As Label
    Friend WithEvents id_usuario As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents usuarios As DataGridViewTextBoxColumn
    Friend WithEvents Totales As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
