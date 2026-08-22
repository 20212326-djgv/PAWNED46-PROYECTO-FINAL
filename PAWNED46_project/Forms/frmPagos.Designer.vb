<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.cmbPrestamo = New System.Windows.Forms.ComboBox()
        Me.btnBuscarPrestamo = New System.Windows.Forms.Button()
        Me.lblClienteTexto = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblCedulaTexto = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPrestamoTexto = New System.Windows.Forms.Label()
        Me.txtSaldoPendiente = New System.Windows.Forms.TextBox()
        Me.lblSaldoTexto = New System.Windows.Forms.Label()
        Me.grpDetallePago = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTotalPago = New System.Windows.Forms.Label()
        Me.txtMora = New System.Windows.Forms.TextBox()
        Me.lblTotalTexto = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.lblMora = New System.Windows.Forms.Label()
        Me.ttxInteres = New System.Windows.Forms.TextBox()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.lblMetodoPago = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dtp_FechaPago = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.grpHistorial = New System.Windows.Forms.GroupBox()
        Me.dgv_articulosPrestamo = New System.Windows.Forms.DataGridView()
        Me.recibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegistrarPago = New System.Windows.Forms.Button()
        Me.btnImprimirRecibo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.grpBuscarPrestamo.SuspendLayout()
        Me.grpDetallePago.SuspendLayout()
        Me.grpHistorial.SuspendLayout()
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(198, 32)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registro de Pago"
        '
        'grpBuscarPrestamo
        '
        Me.grpBuscarPrestamo.BackColor = System.Drawing.Color.White
        Me.grpBuscarPrestamo.Controls.Add(Me.txtSaldoPendiente)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblSaldoTexto)
        Me.grpBuscarPrestamo.Controls.Add(Me.TextBox1)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblPrestamoTexto)
        Me.grpBuscarPrestamo.Controls.Add(Me.txtCedula)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblCedulaTexto)
        Me.grpBuscarPrestamo.Controls.Add(Me.txtCliente)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblClienteTexto)
        Me.grpBuscarPrestamo.Controls.Add(Me.btnBuscarPrestamo)
        Me.grpBuscarPrestamo.Controls.Add(Me.cmbPrestamo)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblContrato)
        Me.grpBuscarPrestamo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBuscarPrestamo.Location = New System.Drawing.Point(21, 35)
        Me.grpBuscarPrestamo.Name = "grpBuscarPrestamo"
        Me.grpBuscarPrestamo.Size = New System.Drawing.Size(941, 150)
        Me.grpBuscarPrestamo.TabIndex = 1
        Me.grpBuscarPrestamo.TabStop = False
        Me.grpBuscarPrestamo.Text = "Datos del Prestamo"
        '
        'lblContrato
        '
        Me.lblContrato.AutoSize = True
        Me.lblContrato.Location = New System.Drawing.Point(46, 38)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(90, 17)
        Me.lblContrato.TabIndex = 0
        Me.lblContrato.Text = "No. Contrato:"
        '
        'cmbPrestamo
        '
        Me.cmbPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrestamo.FormattingEnabled = True
        Me.cmbPrestamo.Location = New System.Drawing.Point(142, 35)
        Me.cmbPrestamo.Name = "cmbPrestamo"
        Me.cmbPrestamo.Size = New System.Drawing.Size(143, 25)
        Me.cmbPrestamo.TabIndex = 1
        '
        'btnBuscarPrestamo
        '
        Me.btnBuscarPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBuscarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPrestamo.ForeColor = System.Drawing.Color.White
        Me.btnBuscarPrestamo.Location = New System.Drawing.Point(289, 33)
        Me.btnBuscarPrestamo.Name = "btnBuscarPrestamo"
        Me.btnBuscarPrestamo.Size = New System.Drawing.Size(76, 28)
        Me.btnBuscarPrestamo.TabIndex = 2
        Me.btnBuscarPrestamo.Text = "Buscar"
        Me.btnBuscarPrestamo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarPrestamo.UseVisualStyleBackColor = False
        '
        'lblClienteTexto
        '
        Me.lblClienteTexto.AutoSize = True
        Me.lblClienteTexto.Location = New System.Drawing.Point(82, 75)
        Me.lblClienteTexto.Name = "lblClienteTexto"
        Me.lblClienteTexto.Size = New System.Drawing.Size(52, 17)
        Me.lblClienteTexto.TabIndex = 3
        Me.lblClienteTexto.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(140, 72)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(254, 25)
        Me.txtCliente.TabIndex = 4
        '
        'lblCedulaTexto
        '
        Me.lblCedulaTexto.AutoSize = True
        Me.lblCedulaTexto.Location = New System.Drawing.Point(403, 75)
        Me.lblCedulaTexto.Name = "lblCedulaTexto"
        Me.lblCedulaTexto.Size = New System.Drawing.Size(52, 17)
        Me.lblCedulaTexto.TabIndex = 5
        Me.lblCedulaTexto.Text = "Cedula:"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(461, 72)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(146, 25)
        Me.txtCedula.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(721, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(146, 25)
        Me.TextBox1.TabIndex = 8
        '
        'lblPrestamoTexto
        '
        Me.lblPrestamoTexto.AutoSize = True
        Me.lblPrestamoTexto.Location = New System.Drawing.Point(612, 77)
        Me.lblPrestamoTexto.Name = "lblPrestamoTexto"
        Me.lblPrestamoTexto.Size = New System.Drawing.Size(103, 17)
        Me.lblPrestamoTexto.TabIndex = 7
        Me.lblPrestamoTexto.Text = "Monto Original:"
        '
        'txtSaldoPendiente
        '
        Me.txtSaldoPendiente.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoPendiente.Location = New System.Drawing.Point(721, 105)
        Me.txtSaldoPendiente.Name = "txtSaldoPendiente"
        Me.txtSaldoPendiente.ReadOnly = True
        Me.txtSaldoPendiente.Size = New System.Drawing.Size(146, 36)
        Me.txtSaldoPendiente.TabIndex = 10
        '
        'lblSaldoTexto
        '
        Me.lblSaldoTexto.AutoSize = True
        Me.lblSaldoTexto.Location = New System.Drawing.Point(606, 118)
        Me.lblSaldoTexto.Name = "lblSaldoTexto"
        Me.lblSaldoTexto.Size = New System.Drawing.Size(109, 17)
        Me.lblSaldoTexto.TabIndex = 9
        Me.lblSaldoTexto.Text = "Saldo Pendiente:"
        '
        'grpDetallePago
        '
        Me.grpDetallePago.BackColor = System.Drawing.Color.White
        Me.grpDetallePago.Controls.Add(Me.lblObservaciones)
        Me.grpDetallePago.Controls.Add(Me.dtp_FechaPago)
        Me.grpDetallePago.Controls.Add(Me.lblFechaPago)
        Me.grpDetallePago.Controls.Add(Me.ComboBox1)
        Me.grpDetallePago.Controls.Add(Me.lblMetodoPago)
        Me.grpDetallePago.Controls.Add(Me.TextBox2)
        Me.grpDetallePago.Controls.Add(Me.lblTotalPago)
        Me.grpDetallePago.Controls.Add(Me.txtMora)
        Me.grpDetallePago.Controls.Add(Me.lblTotalTexto)
        Me.grpDetallePago.Controls.Add(Me.txtCapital)
        Me.grpDetallePago.Controls.Add(Me.lblMora)
        Me.grpDetallePago.Controls.Add(Me.ttxInteres)
        Me.grpDetallePago.Controls.Add(Me.lblInteres)
        Me.grpDetallePago.Controls.Add(Me.lblCapital)
        Me.grpDetallePago.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetallePago.Location = New System.Drawing.Point(21, 191)
        Me.grpDetallePago.Name = "grpDetallePago"
        Me.grpDetallePago.Size = New System.Drawing.Size(941, 167)
        Me.grpDetallePago.TabIndex = 11
        Me.grpDetallePago.TabStop = False
        Me.grpDetallePago.Text = "DETALLE DEL PAGO"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(571, 84)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(272, 69)
        Me.TextBox2.TabIndex = 10
        '
        'lblTotalPago
        '
        Me.lblTotalPago.AutoSize = True
        Me.lblTotalPago.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.lblTotalPago.Location = New System.Drawing.Point(803, 30)
        Me.lblTotalPago.Name = "lblTotalPago"
        Me.lblTotalPago.Size = New System.Drawing.Size(102, 30)
        Me.lblTotalPago.TabIndex = 9
        Me.lblTotalPago.Text = "RD$ 0.00"
        '
        'txtMora
        '
        Me.txtMora.Location = New System.Drawing.Point(307, 35)
        Me.txtMora.Name = "txtMora"
        Me.txtMora.ReadOnly = True
        Me.txtMora.Size = New System.Drawing.Size(146, 25)
        Me.txtMora.TabIndex = 8
        '
        'lblTotalTexto
        '
        Me.lblTotalTexto.AutoSize = True
        Me.lblTotalTexto.Location = New System.Drawing.Point(691, 38)
        Me.lblTotalTexto.Name = "lblTotalTexto"
        Me.lblTotalTexto.Size = New System.Drawing.Size(106, 17)
        Me.lblTotalTexto.TabIndex = 7
        Me.lblTotalTexto.Text = "TOTAL A PAGAR:"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(104, 35)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.ReadOnly = True
        Me.txtCapital.Size = New System.Drawing.Size(146, 25)
        Me.txtCapital.TabIndex = 6
        '
        'lblMora
        '
        Me.lblMora.AutoSize = True
        Me.lblMora.Location = New System.Drawing.Point(259, 38)
        Me.lblMora.Name = "lblMora"
        Me.lblMora.Size = New System.Drawing.Size(43, 17)
        Me.lblMora.TabIndex = 5
        Me.lblMora.Text = "Mora:"
        '
        'ttxInteres
        '
        Me.ttxInteres.Location = New System.Drawing.Point(522, 35)
        Me.ttxInteres.Name = "ttxInteres"
        Me.ttxInteres.ReadOnly = True
        Me.ttxInteres.Size = New System.Drawing.Size(146, 25)
        Me.ttxInteres.TabIndex = 4
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(465, 38)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(53, 17)
        Me.lblInteres.TabIndex = 3
        Me.lblInteres.Text = "Interés:"
        '
        'lblCapital
        '
        Me.lblCapital.AutoSize = True
        Me.lblCapital.Location = New System.Drawing.Point(46, 38)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(52, 17)
        Me.lblCapital.TabIndex = 0
        Me.lblCapital.Text = "Capital:"
        '
        'lblMetodoPago
        '
        Me.lblMetodoPago.AutoSize = True
        Me.lblMetodoPago.Location = New System.Drawing.Point(9, 81)
        Me.lblMetodoPago.Name = "lblMetodoPago"
        Me.lblMetodoPago.Size = New System.Drawing.Size(113, 17)
        Me.lblMetodoPago.TabIndex = 11
        Me.lblMetodoPago.Text = "Metodo de Pago:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Efectivo", "", "Tarjeta", "", "Transferencia"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 25)
        Me.ComboBox1.TabIndex = 12
        '
        'dtp_FechaPago
        '
        Me.dtp_FechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaPago.Location = New System.Drawing.Point(318, 81)
        Me.dtp_FechaPago.Name = "dtp_FechaPago"
        Me.dtp_FechaPago.Size = New System.Drawing.Size(137, 25)
        Me.dtp_FechaPago.TabIndex = 14
        '
        'lblFechaPago
        '
        Me.lblFechaPago.AutoSize = True
        Me.lblFechaPago.Location = New System.Drawing.Point(268, 84)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(46, 17)
        Me.lblFechaPago.TabIndex = 13
        Me.lblFechaPago.Text = "Fecha:"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(465, 87)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(100, 17)
        Me.lblObservaciones.TabIndex = 15
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'grpHistorial
        '
        Me.grpHistorial.BackColor = System.Drawing.Color.White
        Me.grpHistorial.Controls.Add(Me.dgv_articulosPrestamo)
        Me.grpHistorial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistorial.Location = New System.Drawing.Point(21, 364)
        Me.grpHistorial.Name = "grpHistorial"
        Me.grpHistorial.Size = New System.Drawing.Size(941, 199)
        Me.grpHistorial.TabIndex = 12
        Me.grpHistorial.TabStop = False
        Me.grpHistorial.Text = "HISTORIAL DE PAGOS"
        '
        'dgv_articulosPrestamo
        '
        Me.dgv_articulosPrestamo.AllowUserToAddRows = False
        Me.dgv_articulosPrestamo.AllowUserToDeleteRows = False
        Me.dgv_articulosPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_articulosPrestamo.BackgroundColor = System.Drawing.Color.White
        Me.dgv_articulosPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulosPrestamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.recibo, Me.fecha, Me.capital, Me.interes, Me.mora, Me.Total})
        Me.dgv_articulosPrestamo.Location = New System.Drawing.Point(39, 24)
        Me.dgv_articulosPrestamo.MultiSelect = False
        Me.dgv_articulosPrestamo.Name = "dgv_articulosPrestamo"
        Me.dgv_articulosPrestamo.ReadOnly = True
        Me.dgv_articulosPrestamo.RowHeadersVisible = False
        Me.dgv_articulosPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulosPrestamo.Size = New System.Drawing.Size(853, 169)
        Me.dgv_articulosPrestamo.TabIndex = 11
        '
        'recibo
        '
        Me.recibo.HeaderText = "Recibo"
        Me.recibo.Name = "recibo"
        Me.recibo.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'capital
        '
        Me.capital.HeaderText = "Capital"
        Me.capital.Name = "capital"
        Me.capital.ReadOnly = True
        '
        'interes
        '
        Me.interes.HeaderText = "Interes"
        Me.interes.Name = "interes"
        Me.interes.ReadOnly = True
        '
        'mora
        '
        Me.mora.HeaderText = "Mora"
        Me.mora.Name = "mora"
        Me.mora.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'btnRegistrarPago
        '
        Me.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarPago.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarPago.Location = New System.Drawing.Point(60, 587)
        Me.btnRegistrarPago.Name = "btnRegistrarPago"
        Me.btnRegistrarPago.Size = New System.Drawing.Size(89, 48)
        Me.btnRegistrarPago.TabIndex = 12
        Me.btnRegistrarPago.Text = "Registrar Pago"
        Me.btnRegistrarPago.UseVisualStyleBackColor = False
        '
        'btnImprimirRecibo
        '
        Me.btnImprimirRecibo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnImprimirRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirRecibo.ForeColor = System.Drawing.Color.White
        Me.btnImprimirRecibo.Location = New System.Drawing.Point(153, 587)
        Me.btnImprimirRecibo.Name = "btnImprimirRecibo"
        Me.btnImprimirRecibo.Size = New System.Drawing.Size(89, 48)
        Me.btnImprimirRecibo.TabIndex = 13
        Me.btnImprimirRecibo.Text = "Imprimir Recibo"
        Me.btnImprimirRecibo.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(246, 587)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(89, 48)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnImprimirRecibo)
        Me.Controls.Add(Me.grpHistorial)
        Me.Controls.Add(Me.btnRegistrarPago)
        Me.Controls.Add(Me.grpDetallePago)
        Me.Controls.Add(Me.grpBuscarPrestamo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Pagos"
        Me.grpBuscarPrestamo.ResumeLayout(False)
        Me.grpBuscarPrestamo.PerformLayout()
        Me.grpDetallePago.ResumeLayout(False)
        Me.grpDetallePago.PerformLayout()
        Me.grpHistorial.ResumeLayout(False)
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents grpBuscarPrestamo As GroupBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblClienteTexto As Label
    Friend WithEvents btnBuscarPrestamo As Button
    Friend WithEvents cmbPrestamo As ComboBox
    Friend WithEvents lblContrato As Label
    Friend WithEvents txtSaldoPendiente As TextBox
    Friend WithEvents lblSaldoTexto As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPrestamoTexto As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedulaTexto As Label
    Friend WithEvents grpDetallePago As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblTotalPago As Label
    Friend WithEvents txtMora As TextBox
    Friend WithEvents lblTotalTexto As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents lblMora As Label
    Friend WithEvents ttxInteres As TextBox
    Friend WithEvents lblInteres As Label
    Friend WithEvents lblCapital As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblMetodoPago As Label
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents dtp_FechaPago As DateTimePicker
    Friend WithEvents lblFechaPago As Label
    Friend WithEvents grpHistorial As GroupBox
    Friend WithEvents dgv_articulosPrestamo As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnImprimirRecibo As Button
    Friend WithEvents btnRegistrarPago As Button
    Friend WithEvents recibo As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents capital As DataGridViewTextBoxColumn
    Friend WithEvents interes As DataGridViewTextBoxColumn
    Friend WithEvents mora As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
