﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_detalle_ordenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.grd_carga_det = New System.Windows.Forms.DataGridView()
        Me.pnl_usuario = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_cliente = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dt_fecha_entrega = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peso_volumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_bodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_carga_det, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Location = New System.Drawing.Point(12, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(673, 61)
        Me.Panel2.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(366, 38)
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
        Me.btn_nuevo.Location = New System.Drawing.Point(368, -1)
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
        Me.Label9.Location = New System.Drawing.Point(415, 38)
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
        Me.btn_eliminar.Location = New System.Drawing.Point(419, -1)
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
        Me.Label8.Location = New System.Drawing.Point(471, 38)
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
        Me.btn_editar.Location = New System.Drawing.Point(472, -1)
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
        Me.Label7.Location = New System.Drawing.Point(517, 38)
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
        Me.btncancelar.Location = New System.Drawing.Point(524, -1)
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
        Me.Label6.Location = New System.Drawing.Point(572, 38)
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
        Me.btn_guardar.Location = New System.Drawing.Point(575, -1)
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
        Me.Label5.Location = New System.Drawing.Point(630, 37)
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
        Me.btn_salir.Location = New System.Drawing.Point(626, -1)
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
        Me.Label1.Location = New System.Drawing.Point(89, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Detalle de la orden"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.grd_carga_det)
        Me.Panel1.Controls.Add(Me.pnl_usuario)
        Me.Panel1.Location = New System.Drawing.Point(12, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 324)
        Me.Panel1.TabIndex = 14
        '
        'grd_carga_det
        '
        Me.grd_carga_det.AllowUserToAddRows = False
        Me.grd_carga_det.AllowUserToDeleteRows = False
        Me.grd_carga_det.AllowUserToOrderColumns = True
        Me.grd_carga_det.AllowUserToResizeColumns = False
        Me.grd_carga_det.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_carga_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_carga_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccionar, Me.id_det, Me.id_producto, Me.fecha_solicitud, Me.peso_volumen, Me.id_bodega})
        Me.grd_carga_det.Location = New System.Drawing.Point(8, 135)
        Me.grd_carga_det.MultiSelect = False
        Me.grd_carga_det.Name = "grd_carga_det"
        Me.grd_carga_det.RowHeadersVisible = False
        Me.grd_carga_det.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_carga_det.Size = New System.Drawing.Size(427, 186)
        Me.grd_carga_det.TabIndex = 9
        '
        'pnl_usuario
        '
        Me.pnl_usuario.Controls.Add(Me.Label3)
        Me.pnl_usuario.Controls.Add(Me.cb_cliente)
        Me.pnl_usuario.Controls.Add(Me.Label16)
        Me.pnl_usuario.Controls.Add(Me.dt_fecha_entrega)
        Me.pnl_usuario.Location = New System.Drawing.Point(8, 3)
        Me.pnl_usuario.Name = "pnl_usuario"
        Me.pnl_usuario.Size = New System.Drawing.Size(427, 126)
        Me.pnl_usuario.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Cliente"
        '
        'cb_cliente
        '
        Me.cb_cliente.FormattingEnabled = True
        Me.cb_cliente.Location = New System.Drawing.Point(115, 45)
        Me.cb_cliente.Name = "cb_cliente"
        Me.cb_cliente.Size = New System.Drawing.Size(200, 21)
        Me.cb_cliente.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(37, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Fecha entrega"
        '
        'dt_fecha_entrega
        '
        Me.dt_fecha_entrega.Location = New System.Drawing.Point(115, 16)
        Me.dt_fecha_entrega.Name = "dt_fecha_entrega"
        Me.dt_fecha_entrega.Size = New System.Drawing.Size(200, 20)
        Me.dt_fecha_entrega.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCM_VB.My.Resources.Resources.email
        Me.PictureBox1.Location = New System.Drawing.Point(21, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'seleccionar
        '
        Me.seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.seleccionar.HeaderText = "seleccionar"
        Me.seleccionar.Name = "seleccionar"
        '
        'id_det
        '
        Me.id_det.DataPropertyName = "id_ordenes_detalle"
        Me.id_det.HeaderText = "ID"
        Me.id_det.Name = "id_det"
        Me.id_det.Width = 43
        '
        'id_producto
        '
        Me.id_producto.DataPropertyName = "nombre_producto"
        Me.id_producto.HeaderText = "Producto"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.Width = 75
        '
        'fecha_solicitud
        '
        Me.fecha_solicitud.DataPropertyName = "cantidad_producto"
        Me.fecha_solicitud.HeaderText = "Cantidad"
        Me.fecha_solicitud.Name = "fecha_solicitud"
        Me.fecha_solicitud.Width = 74
        '
        'peso_volumen
        '
        Me.peso_volumen.DataPropertyName = "costo_unitario_producto"
        Me.peso_volumen.HeaderText = "Costo unitario"
        Me.peso_volumen.Name = "peso_volumen"
        Me.peso_volumen.Width = 96
        '
        'id_bodega
        '
        Me.id_bodega.DataPropertyName = "nombre_bodega"
        Me.id_bodega.HeaderText = "Bodega"
        Me.id_bodega.Name = "id_bodega"
        Me.id_bodega.Width = 69
        '
        'frm_detalle_ordenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 468)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_detalle_ordenes"
        Me.ShowIcon = False
        Me.Text = "Detalle ordenes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_editar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grd_carga_det, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grd_carga_det As DataGridView
    Friend WithEvents pnl_usuario As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents dt_fecha_entrega As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_cliente As ComboBox
    Friend WithEvents seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents id_det As DataGridViewTextBoxColumn
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents fecha_solicitud As DataGridViewTextBoxColumn
    Friend WithEvents peso_volumen As DataGridViewTextBoxColumn
    Friend WithEvents id_bodega As DataGridViewTextBoxColumn
End Class
