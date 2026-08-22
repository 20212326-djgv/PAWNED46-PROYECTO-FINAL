<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenovaciones
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grpBuscarPrestamo = New System.Windows.Forms.GroupBox()
        Me.txtSaldoPendiente = New System.Windows.Forms.TextBox()
        Me.lblSaldoTexto = New System.Windows.Forms.Label()
        Me.txtMontoPrestamo = New System.Windows.Forms.TextBox()
        Me.lblMontoTexto = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedulaTexto = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblClienteTexto = New System.Windows.Forms.Label()
        Me.btnBuscarPrestamo = New System.Windows.Forms.Button()
        Me.cmbPrestamo = New System.Windows.Forms.ComboBox()
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.grpFechas = New System.Windows.Forms.GroupBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtMontoRenovacion = New System.Windows.Forms.TextBox()
        Me.nudPlazoAdicional = New System.Windows.Forms.NumericUpDown()
        Me.dtpVencimientoActual = New System.Windows.Forms.DateTimePicker()
        Me.lblMontoRenovacion = New System.Windows.Forms.Label()
        Me.dtp_NuevoVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblNuevoVencimiento = New System.Windows.Forms.Label()
        Me.lblPlazoAdicional = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTotalRenovacion = New System.Windows.Forms.Label()
        Me.lblVencimientoActual = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grpHistorial = New System.Windows.Forms.GroupBox()
        Me.dgv_articulosPrestamo = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vencimientoAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nuevoVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRenovar = New System.Windows.Forms.Button()
        Me.grpBuscarPrestamo.SuspendLayout()
        Me.grpFechas.SuspendLayout()
        CType(Me.nudPlazoAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(329, 32)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "RENOVACIÓN DE PRESTAMO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpBuscarPrestamo
        '
        Me.grpBuscarPrestamo.BackColor = System.Drawing.Color.White
        Me.grpBuscarPrestamo.Controls.Add(Me.txtSaldoPendiente)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblSaldoTexto)
        Me.grpBuscarPrestamo.Controls.Add(Me.txtMontoPrestamo)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblMontoTexto)
        Me.grpBuscarPrestamo.Controls.Add(Me.txtCedula)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblCedulaTexto)
        Me.grpBuscarPrestamo.Controls.Add(Me.txtCliente)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblClienteTexto)
        Me.grpBuscarPrestamo.Controls.Add(Me.btnBuscarPrestamo)
        Me.grpBuscarPrestamo.Controls.Add(Me.cmbPrestamo)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblContrato)
        Me.grpBuscarPrestamo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBuscarPrestamo.Location = New System.Drawing.Point(6, 38)
        Me.grpBuscarPrestamo.Name = "grpBuscarPrestamo"
        Me.grpBuscarPrestamo.Size = New System.Drawing.Size(921, 150)
        Me.grpBuscarPrestamo.TabIndex = 4
        Me.grpBuscarPrestamo.TabStop = False
        Me.grpBuscarPrestamo.Text = "Datos del Prestamo"
        '
        'txtSaldoPendiente
        '
        Me.txtSaldoPendiente.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoPendiente.Location = New System.Drawing.Point(696, 108)
        Me.txtSaldoPendiente.Name = "txtSaldoPendiente"
        Me.txtSaldoPendiente.ReadOnly = True
        Me.txtSaldoPendiente.Size = New System.Drawing.Size(146, 36)
        Me.txtSaldoPendiente.TabIndex = 10
        '
        'lblSaldoTexto
        '
        Me.lblSaldoTexto.AutoSize = True
        Me.lblSaldoTexto.Location = New System.Drawing.Point(581, 118)
        Me.lblSaldoTexto.Name = "lblSaldoTexto"
        Me.lblSaldoTexto.Size = New System.Drawing.Size(109, 17)
        Me.lblSaldoTexto.TabIndex = 9
        Me.lblSaldoTexto.Text = "Saldo Pendiente:"
        '
        'txtMontoPrestamo
        '
        Me.txtMontoPrestamo.Location = New System.Drawing.Point(696, 65)
        Me.txtMontoPrestamo.Name = "txtMontoPrestamo"
        Me.txtMontoPrestamo.ReadOnly = True
        Me.txtMontoPrestamo.Size = New System.Drawing.Size(146, 25)
        Me.txtMontoPrestamo.TabIndex = 8
        '
        'lblMontoTexto
        '
        Me.lblMontoTexto.AutoSize = True
        Me.lblMontoTexto.Location = New System.Drawing.Point(554, 68)
        Me.lblMontoTexto.Name = "lblMontoTexto"
        Me.lblMontoTexto.Size = New System.Drawing.Size(136, 17)
        Me.lblMontoTexto.TabIndex = 7
        Me.lblMontoTexto.Text = "Monto del Prestamo:"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(403, 63)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(146, 25)
        Me.txtCedula.TabIndex = 6
        '
        'lblCedulaTexto
        '
        Me.lblCedulaTexto.AutoSize = True
        Me.lblCedulaTexto.Location = New System.Drawing.Point(345, 66)
        Me.lblCedulaTexto.Name = "lblCedulaTexto"
        Me.lblCedulaTexto.Size = New System.Drawing.Size(52, 17)
        Me.lblCedulaTexto.TabIndex = 5
        Me.lblCedulaTexto.Text = "Cedula:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(82, 63)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(254, 25)
        Me.txtCliente.TabIndex = 4
        '
        'lblClienteTexto
        '
        Me.lblClienteTexto.AutoSize = True
        Me.lblClienteTexto.Location = New System.Drawing.Point(24, 66)
        Me.lblClienteTexto.Name = "lblClienteTexto"
        Me.lblClienteTexto.Size = New System.Drawing.Size(52, 17)
        Me.lblClienteTexto.TabIndex = 3
        Me.lblClienteTexto.Text = "Cliente:"
        '
        'btnBuscarPrestamo
        '
        Me.btnBuscarPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBuscarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPrestamo.ForeColor = System.Drawing.Color.White
        Me.btnBuscarPrestamo.Location = New System.Drawing.Point(264, 24)
        Me.btnBuscarPrestamo.Name = "btnBuscarPrestamo"
        Me.btnBuscarPrestamo.Size = New System.Drawing.Size(76, 28)
        Me.btnBuscarPrestamo.TabIndex = 2
        Me.btnBuscarPrestamo.Text = "Buscar"
        Me.btnBuscarPrestamo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarPrestamo.UseVisualStyleBackColor = False
        '
        'cmbPrestamo
        '
        Me.cmbPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrestamo.FormattingEnabled = True
        Me.cmbPrestamo.Location = New System.Drawing.Point(117, 26)
        Me.cmbPrestamo.Name = "cmbPrestamo"
        Me.cmbPrestamo.Size = New System.Drawing.Size(143, 25)
        Me.cmbPrestamo.TabIndex = 1
        '
        'lblContrato
        '
        Me.lblContrato.AutoSize = True
        Me.lblContrato.Location = New System.Drawing.Point(21, 29)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(90, 17)
        Me.lblContrato.TabIndex = 0
        Me.lblContrato.Text = "No. Contrato:"
        '
        'grpFechas
        '
        Me.grpFechas.BackColor = System.Drawing.Color.White
        Me.grpFechas.Controls.Add(Me.lblObservaciones)
        Me.grpFechas.Controls.Add(Me.lblTotal)
        Me.grpFechas.Controls.Add(Me.txtMontoRenovacion)
        Me.grpFechas.Controls.Add(Me.nudPlazoAdicional)
        Me.grpFechas.Controls.Add(Me.dtpVencimientoActual)
        Me.grpFechas.Controls.Add(Me.lblMontoRenovacion)
        Me.grpFechas.Controls.Add(Me.dtp_NuevoVencimiento)
        Me.grpFechas.Controls.Add(Me.lblNuevoVencimiento)
        Me.grpFechas.Controls.Add(Me.lblPlazoAdicional)
        Me.grpFechas.Controls.Add(Me.TextBox2)
        Me.grpFechas.Controls.Add(Me.lblTotalRenovacion)
        Me.grpFechas.Controls.Add(Me.lblVencimientoActual)
        Me.grpFechas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFechas.Location = New System.Drawing.Point(6, 194)
        Me.grpFechas.Name = "grpFechas"
        Me.grpFechas.Size = New System.Drawing.Size(921, 152)
        Me.grpFechas.TabIndex = 12
        Me.grpFechas.TabStop = False
        Me.grpFechas.Text = "INFORMACIÓN DE RENOVACIÓN"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(441, 77)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(100, 17)
        Me.lblObservaciones.TabIndex = 20
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(71, 120)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(47, 17)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "TOTAL:"
        '
        'txtMontoRenovacion
        '
        Me.txtMontoRenovacion.Location = New System.Drawing.Point(233, 71)
        Me.txtMontoRenovacion.Name = "txtMontoRenovacion"
        Me.txtMontoRenovacion.ReadOnly = True
        Me.txtMontoRenovacion.Size = New System.Drawing.Size(146, 25)
        Me.txtMontoRenovacion.TabIndex = 18
        '
        'nudPlazoAdicional
        '
        Me.nudPlazoAdicional.Location = New System.Drawing.Point(700, 31)
        Me.nudPlazoAdicional.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudPlazoAdicional.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPlazoAdicional.Name = "nudPlazoAdicional"
        Me.nudPlazoAdicional.Size = New System.Drawing.Size(120, 25)
        Me.nudPlazoAdicional.TabIndex = 17
        Me.nudPlazoAdicional.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dtpVencimientoActual
        '
        Me.dtpVencimientoActual.Enabled = False
        Me.dtpVencimientoActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimientoActual.Location = New System.Drawing.Point(200, 31)
        Me.dtpVencimientoActual.Name = "dtpVencimientoActual"
        Me.dtpVencimientoActual.Size = New System.Drawing.Size(137, 25)
        Me.dtpVencimientoActual.TabIndex = 16
        '
        'lblMontoRenovacion
        '
        Me.lblMontoRenovacion.AutoSize = True
        Me.lblMontoRenovacion.Location = New System.Drawing.Point(69, 74)
        Me.lblMontoRenovacion.Name = "lblMontoRenovacion"
        Me.lblMontoRenovacion.Size = New System.Drawing.Size(145, 17)
        Me.lblMontoRenovacion.TabIndex = 15
        Me.lblMontoRenovacion.Text = "Monto de Renovación:"
        '
        'dtp_NuevoVencimiento
        '
        Me.dtp_NuevoVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_NuevoVencimiento.Location = New System.Drawing.Point(395, 31)
        Me.dtp_NuevoVencimiento.Name = "dtp_NuevoVencimiento"
        Me.dtp_NuevoVencimiento.Size = New System.Drawing.Size(137, 25)
        Me.dtp_NuevoVencimiento.TabIndex = 14
        '
        'lblNuevoVencimiento
        '
        Me.lblNuevoVencimiento.AutoSize = True
        Me.lblNuevoVencimiento.Location = New System.Drawing.Point(343, 35)
        Me.lblNuevoVencimiento.Name = "lblNuevoVencimiento"
        Me.lblNuevoVencimiento.Size = New System.Drawing.Size(46, 17)
        Me.lblNuevoVencimiento.TabIndex = 13
        Me.lblNuevoVencimiento.Text = "Fecha:"
        '
        'lblPlazoAdicional
        '
        Me.lblPlazoAdicional.AutoSize = True
        Me.lblPlazoAdicional.Location = New System.Drawing.Point(544, 35)
        Me.lblPlazoAdicional.Name = "lblPlazoAdicional"
        Me.lblPlazoAdicional.Size = New System.Drawing.Size(152, 17)
        Me.lblPlazoAdicional.TabIndex = 11
        Me.lblPlazoAdicional.Text = "Plazo Adicional (meses):"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(547, 74)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(272, 69)
        Me.TextBox2.TabIndex = 10
        '
        'lblTotalRenovacion
        '
        Me.lblTotalRenovacion.AutoSize = True
        Me.lblTotalRenovacion.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRenovacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.lblTotalRenovacion.Location = New System.Drawing.Point(127, 113)
        Me.lblTotalRenovacion.Name = "lblTotalRenovacion"
        Me.lblTotalRenovacion.Size = New System.Drawing.Size(102, 30)
        Me.lblTotalRenovacion.TabIndex = 9
        Me.lblTotalRenovacion.Text = "RD$ 0.00"
        '
        'lblVencimientoActual
        '
        Me.lblVencimientoActual.AutoSize = True
        Me.lblVencimientoActual.Location = New System.Drawing.Point(69, 35)
        Me.lblVencimientoActual.Name = "lblVencimientoActual"
        Me.lblVencimientoActual.Size = New System.Drawing.Size(127, 17)
        Me.lblVencimientoActual.TabIndex = 0
        Me.lblVencimientoActual.Text = "Vencimiento Actual:"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(123, 557)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 48)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(193, 557)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(64, 48)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'grpHistorial
        '
        Me.grpHistorial.BackColor = System.Drawing.Color.White
        Me.grpHistorial.Controls.Add(Me.dgv_articulosPrestamo)
        Me.grpHistorial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistorial.Location = New System.Drawing.Point(6, 352)
        Me.grpHistorial.Name = "grpHistorial"
        Me.grpHistorial.Size = New System.Drawing.Size(916, 199)
        Me.grpHistorial.TabIndex = 15
        Me.grpHistorial.TabStop = False
        Me.grpHistorial.Text = "HISTORIAL DE RENOVACIONES"
        '
        'dgv_articulosPrestamo
        '
        Me.dgv_articulosPrestamo.AllowUserToAddRows = False
        Me.dgv_articulosPrestamo.AllowUserToDeleteRows = False
        Me.dgv_articulosPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_articulosPrestamo.BackgroundColor = System.Drawing.Color.White
        Me.dgv_articulosPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulosPrestamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.vencimientoAnterior, Me.nuevoVencimiento, Me.Monto})
        Me.dgv_articulosPrestamo.Location = New System.Drawing.Point(39, 24)
        Me.dgv_articulosPrestamo.MultiSelect = False
        Me.dgv_articulosPrestamo.Name = "dgv_articulosPrestamo"
        Me.dgv_articulosPrestamo.ReadOnly = True
        Me.dgv_articulosPrestamo.RowHeadersVisible = False
        Me.dgv_articulosPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulosPrestamo.Size = New System.Drawing.Size(853, 169)
        Me.dgv_articulosPrestamo.TabIndex = 11
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'vencimientoAnterior
        '
        Me.vencimientoAnterior.HeaderText = "Vencimiento Anterior"
        Me.vencimientoAnterior.Name = "vencimientoAnterior"
        Me.vencimientoAnterior.ReadOnly = True
        '
        'nuevoVencimiento
        '
        Me.nuevoVencimiento.HeaderText = "Nuevo Vencimiento"
        Me.nuevoVencimiento.Name = "nuevoVencimiento"
        Me.nuevoVencimiento.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'btnRenovar
        '
        Me.btnRenovar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRenovar.ForeColor = System.Drawing.Color.White
        Me.btnRenovar.Location = New System.Drawing.Point(42, 557)
        Me.btnRenovar.Name = "btnRenovar"
        Me.btnRenovar.Size = New System.Drawing.Size(75, 48)
        Me.btnRenovar.TabIndex = 16
        Me.btnRenovar.Text = "Renovar Prestamo"
        Me.btnRenovar.UseVisualStyleBackColor = False
        '
        'frmRenovaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 611)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grpHistorial)
        Me.Controls.Add(Me.btnRenovar)
        Me.Controls.Add(Me.grpFechas)
        Me.Controls.Add(Me.grpBuscarPrestamo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimizeBox = False
        Me.Name = "frmRenovaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Renovación de Prestamo"
        Me.grpBuscarPrestamo.ResumeLayout(False)
        Me.grpBuscarPrestamo.PerformLayout()
        Me.grpFechas.ResumeLayout(False)
        Me.grpFechas.PerformLayout()
        CType(Me.nudPlazoAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHistorial.ResumeLayout(False)
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents grpBuscarPrestamo As GroupBox
    Friend WithEvents txtSaldoPendiente As TextBox
    Friend WithEvents lblSaldoTexto As Label
    Friend WithEvents txtMontoPrestamo As TextBox
    Friend WithEvents lblMontoTexto As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedulaTexto As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblClienteTexto As Label
    Friend WithEvents btnBuscarPrestamo As Button
    Friend WithEvents cmbPrestamo As ComboBox
    Friend WithEvents lblContrato As Label
    Friend WithEvents grpFechas As GroupBox
    Friend WithEvents dtpVencimientoActual As DateTimePicker
    Friend WithEvents lblMontoRenovacion As Label
    Friend WithEvents dtp_NuevoVencimiento As DateTimePicker
    Friend WithEvents lblNuevoVencimiento As Label
    Friend WithEvents lblPlazoAdicional As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblTotalRenovacion As Label
    Friend WithEvents lblVencimientoActual As Label
    Friend WithEvents nudPlazoAdicional As NumericUpDown
    Friend WithEvents txtMontoRenovacion As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents grpHistorial As GroupBox
    Friend WithEvents dgv_articulosPrestamo As DataGridView
    Friend WithEvents btnRenovar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents vencimientoAnterior As DataGridViewTextBoxColumn
    Friend WithEvents nuevoVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
End Class
