<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGastos
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grpGasto = New System.Windows.Forms.GroupBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.grpHistorial = New System.Windows.Forms.GroupBox()
        Me.dgv_articulosPrestamo = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalGastosTextos = New System.Windows.Forms.Label()
        Me.lblTotalGastos = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.grpGasto.SuspendLayout()
        Me.grpHistorial.SuspendLayout()
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(241, 32)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "REGISTRO DE DATOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpGasto
        '
        Me.grpGasto.BackColor = System.Drawing.Color.White
        Me.grpGasto.Controls.Add(Me.txtObservaciones)
        Me.grpGasto.Controls.Add(Me.lblMonto)
        Me.grpGasto.Controls.Add(Me.cmbCategoria)
        Me.grpGasto.Controls.Add(Me.lblObservaciones)
        Me.grpGasto.Controls.Add(Me.txtUsuario)
        Me.grpGasto.Controls.Add(Me.lblUsuario)
        Me.grpGasto.Controls.Add(Me.txtMonto)
        Me.grpGasto.Controls.Add(Me.dtpFecha)
        Me.grpGasto.Controls.Add(Me.txtDescripcion)
        Me.grpGasto.Controls.Add(Me.lblCategoria)
        Me.grpGasto.Controls.Add(Me.lblDescripcion)
        Me.grpGasto.Controls.Add(Me.lblFecha)
        Me.grpGasto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGasto.Location = New System.Drawing.Point(6, 35)
        Me.grpGasto.Name = "grpGasto"
        Me.grpGasto.Size = New System.Drawing.Size(920, 159)
        Me.grpGasto.TabIndex = 11
        Me.grpGasto.TabStop = False
        Me.grpGasto.Text = "INFORMACION DEL GASTO"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(495, 43)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(100, 17)
        Me.lblObservaciones.TabIndex = 11
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(355, 76)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(117, 25)
        Me.txtUsuario.TabIndex = 10
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(294, 79)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lblUsuario.TabIndex = 9
        Me.lblUsuario.Text = "Usuario:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(139, 111)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(149, 25)
        Me.txtMonto.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(355, 40)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(117, 25)
        Me.dtpFecha.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(139, 40)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(149, 25)
        Me.txtDescripcion.TabIndex = 4
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(52, 79)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(69, 17)
        Me.lblCategoria.TabIndex = 7
        Me.lblCategoria.Text = "Categoría:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(41, 43)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 17)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(305, 43)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 17)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha:"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Items.AddRange(New Object() {"Servicios", "Materiales", "Mantenimiento", "Transporte", "Publicidad", "Equipos", "Otros"})
        Me.cmbCategoria.Location = New System.Drawing.Point(139, 76)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(149, 25)
        Me.cmbCategoria.TabIndex = 15
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(69, 114)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(52, 17)
        Me.lblMonto.TabIndex = 16
        Me.lblMonto.Text = "Monto:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(601, 43)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(288, 93)
        Me.txtObservaciones.TabIndex = 17
        '
        'grpHistorial
        '
        Me.grpHistorial.BackColor = System.Drawing.Color.White
        Me.grpHistorial.Controls.Add(Me.dgv_articulosPrestamo)
        Me.grpHistorial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistorial.Location = New System.Drawing.Point(6, 200)
        Me.grpHistorial.Name = "grpHistorial"
        Me.grpHistorial.Size = New System.Drawing.Size(920, 263)
        Me.grpHistorial.TabIndex = 18
        Me.grpHistorial.TabStop = False
        Me.grpHistorial.Text = "HISTORIAL DE GASTOS"
        '
        'dgv_articulosPrestamo
        '
        Me.dgv_articulosPrestamo.AllowUserToAddRows = False
        Me.dgv_articulosPrestamo.AllowUserToDeleteRows = False
        Me.dgv_articulosPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_articulosPrestamo.BackgroundColor = System.Drawing.Color.White
        Me.dgv_articulosPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulosPrestamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Descripción, Me.Categoria, Me.Monto, Me.Usuario})
        Me.dgv_articulosPrestamo.Location = New System.Drawing.Point(36, 24)
        Me.dgv_articulosPrestamo.MultiSelect = False
        Me.dgv_articulosPrestamo.Name = "dgv_articulosPrestamo"
        Me.dgv_articulosPrestamo.ReadOnly = True
        Me.dgv_articulosPrestamo.RowHeadersVisible = False
        Me.dgv_articulosPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulosPrestamo.Size = New System.Drawing.Size(853, 183)
        Me.dgv_articulosPrestamo.TabIndex = 8
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoría"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'lblTotalGastosTextos
        '
        Me.lblTotalGastosTextos.AutoSize = True
        Me.lblTotalGastosTextos.Location = New System.Drawing.Point(34, 473)
        Me.lblTotalGastosTextos.Name = "lblTotalGastosTextos"
        Me.lblTotalGastosTextos.Size = New System.Drawing.Size(112, 15)
        Me.lblTotalGastosTextos.TabIndex = 9
        Me.lblTotalGastosTextos.Text = "TOTAL DE GASTOS:"
        '
        'lblTotalGastos
        '
        Me.lblTotalGastos.AutoSize = True
        Me.lblTotalGastos.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGastos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblTotalGastos.Location = New System.Drawing.Point(159, 466)
        Me.lblTotalGastos.Name = "lblTotalGastos"
        Me.lblTotalGastos.Size = New System.Drawing.Size(102, 30)
        Me.lblTotalGastos.TabIndex = 10
        Me.lblTotalGastos.Text = "RD$ 0.00"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(42, 512)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(95, 39)
        Me.btn_guardar.TabIndex = 19
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(143, 512)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 39)
        Me.btnEditar.TabIndex = 20
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(244, 512)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 39)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_limpiar.Location = New System.Drawing.Point(345, 512)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(95, 39)
        Me.btn_limpiar.TabIndex = 22
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'frmGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 611)
        Me.Controls.Add(Me.lblTotalGastos)
        Me.Controls.Add(Me.lblTotalGastosTextos)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.grpHistorial)
        Me.Controls.Add(Me.grpGasto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Gastos"
        Me.grpGasto.ResumeLayout(False)
        Me.grpGasto.PerformLayout()
        Me.grpHistorial.ResumeLayout(False)
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents grpGasto As GroupBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents grpHistorial As GroupBox
    Friend WithEvents dgv_articulosPrestamo As DataGridView
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalGastosTextos As Label
    Friend WithEvents lblTotalGastos As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btn_limpiar As Button
End Class
