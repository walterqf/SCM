<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vehiculos
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grd_vehiculos = New System.Windows.Forms.DataGridView()
        Me.pnl_usuario = New System.Windows.Forms.Panel()
        Me.dt_fecha_compra = New System.Windows.Forms.DateTimePicker()
        Me.txt_kil_original = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cb_estado = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_kilo_actual = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_clr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb_tipo_vehiculs = New System.Windows.Forms.ComboBox()
        Me.cb_marca = New System.Windows.Forms.ComboBox()
        Me.txt_mtr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca_vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtr_vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clr_vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mod_vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.km_vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kilometraje_actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ultimoservicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_vehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_usuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel2.Location = New System.Drawing.Point(1, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 65)
        Me.Panel2.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(408, 42)
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
        Me.btn_nuevo.Location = New System.Drawing.Point(410, 3)
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
        Me.Label9.Location = New System.Drawing.Point(457, 42)
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
        Me.btn_eliminar.Location = New System.Drawing.Point(461, 3)
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
        Me.Label8.Location = New System.Drawing.Point(513, 42)
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
        Me.btn_editar.Location = New System.Drawing.Point(514, 3)
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
        Me.Label7.Location = New System.Drawing.Point(559, 42)
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
        Me.btncancelar.Location = New System.Drawing.Point(566, 3)
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
        Me.Label6.Location = New System.Drawing.Point(614, 42)
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
        Me.btn_guardar.Location = New System.Drawing.Point(617, 3)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(35, 35)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 13
        Me.btn_guardar.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(672, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Salir"
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salir.Image = Global.SCM_VB.My.Resources.Resources.inside
        Me.btn_salir.Location = New System.Drawing.Point(668, 3)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(35, 35)
        Me.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Vehículos"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.grd_vehiculos)
        Me.Panel1.Controls.Add(Me.pnl_usuario)
        Me.Panel1.Location = New System.Drawing.Point(1, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 304)
        Me.Panel1.TabIndex = 14
        '
        'grd_vehiculos
        '
        Me.grd_vehiculos.AllowUserToAddRows = False
        Me.grd_vehiculos.AllowUserToDeleteRows = False
        Me.grd_vehiculos.AllowUserToOrderColumns = True
        Me.grd_vehiculos.AllowUserToResizeColumns = False
        Me.grd_vehiculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_vehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usuarios, Me.id_tipo_vehiculo, Me.marca_vehiculo, Me.mtr_vehiculo, Me.clr_vehiculo, Me.mod_vehiculo, Me.km_vehiculo, Me.kilometraje_actual, Me.fecha_ultimoservicio, Me.fecha_compra, Me.id_estado})
        Me.grd_vehiculos.Location = New System.Drawing.Point(12, 157)
        Me.grd_vehiculos.MultiSelect = False
        Me.grd_vehiculos.Name = "grd_vehiculos"
        Me.grd_vehiculos.RowHeadersVisible = False
        Me.grd_vehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_vehiculos.Size = New System.Drawing.Size(620, 146)
        Me.grd_vehiculos.TabIndex = 9
        '
        'pnl_usuario
        '
        Me.pnl_usuario.Controls.Add(Me.dt_fecha_compra)
        Me.pnl_usuario.Controls.Add(Me.txt_kil_original)
        Me.pnl_usuario.Controls.Add(Me.Label17)
        Me.pnl_usuario.Controls.Add(Me.Label15)
        Me.pnl_usuario.Controls.Add(Me.cb_estado)
        Me.pnl_usuario.Controls.Add(Me.Label16)
        Me.pnl_usuario.Controls.Add(Me.dt_fecha)
        Me.pnl_usuario.Controls.Add(Me.Label14)
        Me.pnl_usuario.Controls.Add(Me.txt_kilo_actual)
        Me.pnl_usuario.Controls.Add(Me.Label13)
        Me.pnl_usuario.Controls.Add(Me.txt_modelo)
        Me.pnl_usuario.Controls.Add(Me.Label12)
        Me.pnl_usuario.Controls.Add(Me.txt_clr)
        Me.pnl_usuario.Controls.Add(Me.Label11)
        Me.pnl_usuario.Controls.Add(Me.cb_tipo_vehiculs)
        Me.pnl_usuario.Controls.Add(Me.cb_marca)
        Me.pnl_usuario.Controls.Add(Me.txt_mtr)
        Me.pnl_usuario.Controls.Add(Me.Label3)
        Me.pnl_usuario.Controls.Add(Me.Label2)
        Me.pnl_usuario.Controls.Add(Me.Label4)
        Me.pnl_usuario.Location = New System.Drawing.Point(12, 3)
        Me.pnl_usuario.Name = "pnl_usuario"
        Me.pnl_usuario.Size = New System.Drawing.Size(620, 148)
        Me.pnl_usuario.TabIndex = 9
        '
        'dt_fecha_compra
        '
        Me.dt_fecha_compra.Location = New System.Drawing.Point(420, 107)
        Me.dt_fecha_compra.Name = "dt_fecha_compra"
        Me.dt_fecha_compra.Size = New System.Drawing.Size(163, 20)
        Me.dt_fecha_compra.TabIndex = 25
        '
        'txt_kil_original
        '
        Me.txt_kil_original.Location = New System.Drawing.Point(420, 3)
        Me.txt_kil_original.Name = "txt_kil_original"
        Me.txt_kil_original.Size = New System.Drawing.Size(163, 20)
        Me.txt_kil_original.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(296, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Kilometraje original"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(296, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Fecha de compra"
        '
        'cb_estado
        '
        Me.cb_estado.FormattingEnabled = True
        Me.cb_estado.Location = New System.Drawing.Point(107, 119)
        Me.cb_estado.Name = "cb_estado"
        Me.cb_estado.Size = New System.Drawing.Size(163, 21)
        Me.cb_estado.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Estado"
        '
        'dt_fecha
        '
        Me.dt_fecha.Location = New System.Drawing.Point(420, 81)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(163, 20)
        Me.dt_fecha.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(294, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Fecha de últmo servicio"
        '
        'txt_kilo_actual
        '
        Me.txt_kilo_actual.Location = New System.Drawing.Point(420, 55)
        Me.txt_kilo_actual.Name = "txt_kilo_actual"
        Me.txt_kilo_actual.Size = New System.Drawing.Size(163, 20)
        Me.txt_kilo_actual.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(296, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Kilometraje actual"
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(420, 29)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(163, 20)
        Me.txt_modelo.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(296, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Modelo"
        '
        'txt_clr
        '
        Me.txt_clr.Location = New System.Drawing.Point(107, 88)
        Me.txt_clr.Name = "txt_clr"
        Me.txt_clr.Size = New System.Drawing.Size(163, 20)
        Me.txt_clr.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Color"
        '
        'cb_tipo_vehiculs
        '
        Me.cb_tipo_vehiculs.FormattingEnabled = True
        Me.cb_tipo_vehiculs.Location = New System.Drawing.Point(107, 33)
        Me.cb_tipo_vehiculs.Name = "cb_tipo_vehiculs"
        Me.cb_tipo_vehiculs.Size = New System.Drawing.Size(163, 21)
        Me.cb_tipo_vehiculs.TabIndex = 11
        '
        'cb_marca
        '
        Me.cb_marca.FormattingEnabled = True
        Me.cb_marca.Location = New System.Drawing.Point(107, 6)
        Me.cb_marca.Name = "cb_marca"
        Me.cb_marca.Size = New System.Drawing.Size(163, 21)
        Me.cb_marca.TabIndex = 10
        '
        'txt_mtr
        '
        Me.txt_mtr.Location = New System.Drawing.Point(107, 59)
        Me.txt_mtr.Name = "txt_mtr"
        Me.txt_mtr.Size = New System.Drawing.Size(163, 20)
        Me.txt_mtr.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Matricula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tipo vehículo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Marca"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCM_VB.My.Resources.Resources.car
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'usuarios
        '
        Me.usuarios.DataPropertyName = "id_vehiculos"
        Me.usuarios.HeaderText = "ID"
        Me.usuarios.Name = "usuarios"
        '
        'id_tipo_vehiculo
        '
        Me.id_tipo_vehiculo.DataPropertyName = "nombre"
        Me.id_tipo_vehiculo.HeaderText = "Tipo"
        Me.id_tipo_vehiculo.Name = "id_tipo_vehiculo"
        '
        'marca_vehiculo
        '
        Me.marca_vehiculo.DataPropertyName = "marca"
        Me.marca_vehiculo.HeaderText = "Marca"
        Me.marca_vehiculo.Name = "marca_vehiculo"
        '
        'mtr_vehiculo
        '
        Me.mtr_vehiculo.DataPropertyName = "vhc_matricula"
        Me.mtr_vehiculo.HeaderText = "Matricula"
        Me.mtr_vehiculo.Name = "mtr_vehiculo"
        '
        'clr_vehiculo
        '
        Me.clr_vehiculo.DataPropertyName = "vhc_color"
        Me.clr_vehiculo.HeaderText = "Color"
        Me.clr_vehiculo.Name = "clr_vehiculo"
        '
        'mod_vehiculo
        '
        Me.mod_vehiculo.DataPropertyName = "vhc_modelo"
        Me.mod_vehiculo.HeaderText = "Modelo"
        Me.mod_vehiculo.Name = "mod_vehiculo"
        '
        'km_vehiculo
        '
        Me.km_vehiculo.DataPropertyName = "vhc_km_original"
        Me.km_vehiculo.HeaderText = "Kilometraje Original"
        Me.km_vehiculo.Name = "km_vehiculo"
        '
        'kilometraje_actual
        '
        Me.kilometraje_actual.DataPropertyName = "vhc_km_actual"
        Me.kilometraje_actual.HeaderText = "Kilometraje Actual"
        Me.kilometraje_actual.Name = "kilometraje_actual"
        '
        'fecha_ultimoservicio
        '
        Me.fecha_ultimoservicio.DataPropertyName = "fecha_ultimoserv"
        Me.fecha_ultimoservicio.HeaderText = "Ultimo servicio"
        Me.fecha_ultimoservicio.Name = "fecha_ultimoservicio"
        '
        'fecha_compra
        '
        Me.fecha_compra.DataPropertyName = "fecha_compra"
        Me.fecha_compra.HeaderText = "Fecha de compra"
        Me.fecha_compra.Name = "fecha_compra"
        '
        'id_estado
        '
        Me.id_estado.DataPropertyName = "stdnombre"
        Me.id_estado.HeaderText = "Estado"
        Me.id_estado.Name = "id_estado"
        '
        'frm_vehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_vehiculos"
        Me.ShowIcon = False
        Me.Text = "Vehículos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grd_vehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_usuario.ResumeLayout(False)
        Me.pnl_usuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_nuevo As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_eliminar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_editar As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btncancelar As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_guardar As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_salir As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grd_vehiculos As DataGridView
    Friend WithEvents pnl_usuario As Panel
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_kilo_actual As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_clr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cb_tipo_vehiculs As ComboBox
    Friend WithEvents cb_marca As ComboBox
    Friend WithEvents txt_mtr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cb_estado As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_kil_original As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dt_fecha_compra As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents usuarios As DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents marca_vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents mtr_vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents clr_vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents mod_vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents km_vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents kilometraje_actual As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ultimoservicio As DataGridViewTextBoxColumn
    Friend WithEvents fecha_compra As DataGridViewTextBoxColumn
    Friend WithEvents id_estado As DataGridViewTextBoxColumn
End Class
