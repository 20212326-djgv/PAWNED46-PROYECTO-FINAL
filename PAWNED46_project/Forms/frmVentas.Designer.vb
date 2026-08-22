<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.grpComprador = New System.Windows.Forms.GroupBox()
        Me.txtNombreComprador = New System.Windows.Forms.TextBox()
        Me.txtCedulaComprador = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombreComprador = New System.Windows.Forms.Label()
        Me.grpArticulos = New System.Windows.Forms.GroupBox()
        Me.dgv_articulosPrestamo = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregarArticulo = New System.Windows.Forms.Button()
        Me.cmbArticulo = New System.Windows.Forms.ComboBox()
        Me.lblBuscarArticulo = New System.Windows.Forms.Label()
        Me.grpResumen = New System.Windows.Forms.GroupBox()
        Me.cmbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.lblMetodoPago = New System.Windows.Forms.Label()
        Me.lblTotalTexto = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lblDescuentoTexto = New System.Windows.Forms.Label()
        Me.lbl_interesGenerado = New System.Windows.Forms.Label()
        Me.lblSubtotalTexto = New System.Windows.Forms.Label()
        Me.btnImprimirFactura = New System.Windows.Forms.Button()
        Me.btnRegistrarVenta = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.grpBuscarPrestamo.SuspendLayout()
        Me.grpComprador.SuspendLayout()
        Me.grpArticulos.SuspendLayout()
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResumen.SuspendLayout()
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
        Me.lblTitulo.Size = New System.Drawing.Size(253, 32)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "VENTA DE ARTÍCULOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpBuscarPrestamo
        '
        Me.grpBuscarPrestamo.BackColor = System.Drawing.Color.White
        Me.grpBuscarPrestamo.Controls.Add(Me.dtpFechaVenta)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblFecha)
        Me.grpBuscarPrestamo.Controls.Add(Me.txtNumeroFactura)
        Me.grpBuscarPrestamo.Controls.Add(Me.txtUsuario)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblUsuario)
        Me.grpBuscarPrestamo.Controls.Add(Me.lblFactura)
        Me.grpBuscarPrestamo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBuscarPrestamo.Location = New System.Drawing.Point(6, 35)
        Me.grpBuscarPrestamo.Name = "grpBuscarPrestamo"
        Me.grpBuscarPrestamo.Size = New System.Drawing.Size(973, 85)
        Me.grpBuscarPrestamo.TabIndex = 5
        Me.grpBuscarPrestamo.TabStop = False
        Me.grpBuscarPrestamo.Text = "DATOS DE LA VENTA"
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenta.Location = New System.Drawing.Point(449, 24)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(137, 25)
        Me.dtpFechaVenta.TabIndex = 16
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(397, 27)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 17)
        Me.lblFecha.TabIndex = 15
        Me.lblFecha.Text = "Fecha:"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(167, 24)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.ReadOnly = True
        Me.txtNumeroFactura.Size = New System.Drawing.Size(146, 25)
        Me.txtNumeroFactura.TabIndex = 11
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(735, 24)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(172, 25)
        Me.txtUsuario.TabIndex = 4
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(677, 27)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(80, 27)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(81, 17)
        Me.lblFactura.TabIndex = 0
        Me.lblFactura.Text = "No. Factura:"
        '
        'grpComprador
        '
        Me.grpComprador.BackColor = System.Drawing.Color.White
        Me.grpComprador.Controls.Add(Me.txtNombreComprador)
        Me.grpComprador.Controls.Add(Me.txtCedulaComprador)
        Me.grpComprador.Controls.Add(Me.lblCedula)
        Me.grpComprador.Controls.Add(Me.lblNombreComprador)
        Me.grpComprador.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpComprador.Location = New System.Drawing.Point(6, 126)
        Me.grpComprador.Name = "grpComprador"
        Me.grpComprador.Size = New System.Drawing.Size(973, 85)
        Me.grpComprador.TabIndex = 6
        Me.grpComprador.TabStop = False
        Me.grpComprador.Text = "DATOS DEL COMPRADOR"
        '
        'txtNombreComprador
        '
        Me.txtNombreComprador.Location = New System.Drawing.Point(167, 24)
        Me.txtNombreComprador.Name = "txtNombreComprador"
        Me.txtNombreComprador.ReadOnly = True
        Me.txtNombreComprador.Size = New System.Drawing.Size(228, 25)
        Me.txtNombreComprador.TabIndex = 11
        '
        'txtCedulaComprador
        '
        Me.txtCedulaComprador.Location = New System.Drawing.Point(514, 24)
        Me.txtCedulaComprador.Name = "txtCedulaComprador"
        Me.txtCedulaComprador.ReadOnly = True
        Me.txtCedulaComprador.Size = New System.Drawing.Size(172, 25)
        Me.txtCedulaComprador.TabIndex = 4
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(456, 27)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(52, 17)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Cédula:"
        '
        'lblNombreComprador
        '
        Me.lblNombreComprador.AutoSize = True
        Me.lblNombreComprador.Location = New System.Drawing.Point(100, 27)
        Me.lblNombreComprador.Name = "lblNombreComprador"
        Me.lblNombreComprador.Size = New System.Drawing.Size(61, 17)
        Me.lblNombreComprador.TabIndex = 0
        Me.lblNombreComprador.Text = "Nombre:"
        '
        'grpArticulos
        '
        Me.grpArticulos.BackColor = System.Drawing.Color.White
        Me.grpArticulos.Controls.Add(Me.dgv_articulosPrestamo)
        Me.grpArticulos.Controls.Add(Me.btn_agregarArticulo)
        Me.grpArticulos.Controls.Add(Me.cmbArticulo)
        Me.grpArticulos.Controls.Add(Me.lblBuscarArticulo)
        Me.grpArticulos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpArticulos.Location = New System.Drawing.Point(6, 217)
        Me.grpArticulos.Name = "grpArticulos"
        Me.grpArticulos.Size = New System.Drawing.Size(973, 174)
        Me.grpArticulos.TabIndex = 12
        Me.grpArticulos.TabStop = False
        Me.grpArticulos.Text = "ARTÍCULOS DISPONIBLES PARA VENTA"
        '
        'dgv_articulosPrestamo
        '
        Me.dgv_articulosPrestamo.AllowUserToAddRows = False
        Me.dgv_articulosPrestamo.AllowUserToDeleteRows = False
        Me.dgv_articulosPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_articulosPrestamo.BackgroundColor = System.Drawing.Color.White
        Me.dgv_articulosPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulosPrestamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Articulo, Me.Precio, Me.Descuento, Me.total})
        Me.dgv_articulosPrestamo.Location = New System.Drawing.Point(54, 59)
        Me.dgv_articulosPrestamo.MultiSelect = False
        Me.dgv_articulosPrestamo.Name = "dgv_articulosPrestamo"
        Me.dgv_articulosPrestamo.ReadOnly = True
        Me.dgv_articulosPrestamo.RowHeadersVisible = False
        Me.dgv_articulosPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulosPrestamo.Size = New System.Drawing.Size(853, 108)
        Me.dgv_articulosPrestamo.TabIndex = 8
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Artículo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'btn_agregarArticulo
        '
        Me.btn_agregarArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_agregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregarArticulo.ForeColor = System.Drawing.Color.White
        Me.btn_agregarArticulo.Location = New System.Drawing.Point(319, 21)
        Me.btn_agregarArticulo.Name = "btn_agregarArticulo"
        Me.btn_agregarArticulo.Size = New System.Drawing.Size(88, 29)
        Me.btn_agregarArticulo.TabIndex = 7
        Me.btn_agregarArticulo.Text = "+ Agregar"
        Me.btn_agregarArticulo.UseVisualStyleBackColor = False
        '
        'cmbArticulo
        '
        Me.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArticulo.FormattingEnabled = True
        Me.cmbArticulo.Location = New System.Drawing.Point(167, 24)
        Me.cmbArticulo.Name = "cmbArticulo"
        Me.cmbArticulo.Size = New System.Drawing.Size(146, 25)
        Me.cmbArticulo.TabIndex = 5
        '
        'lblBuscarArticulo
        '
        Me.lblBuscarArticulo.AutoSize = True
        Me.lblBuscarArticulo.Location = New System.Drawing.Point(59, 27)
        Me.lblBuscarArticulo.Name = "lblBuscarArticulo"
        Me.lblBuscarArticulo.Size = New System.Drawing.Size(102, 17)
        Me.lblBuscarArticulo.TabIndex = 0
        Me.lblBuscarArticulo.Text = "Buscar Articulo:"
        '
        'grpResumen
        '
        Me.grpResumen.BackColor = System.Drawing.Color.White
        Me.grpResumen.Controls.Add(Me.cmbMetodoPago)
        Me.grpResumen.Controls.Add(Me.lblMetodoPago)
        Me.grpResumen.Controls.Add(Me.lblTotalTexto)
        Me.grpResumen.Controls.Add(Me.txtDescuento)
        Me.grpResumen.Controls.Add(Me.lbl_total)
        Me.grpResumen.Controls.Add(Me.lblDescuentoTexto)
        Me.grpResumen.Controls.Add(Me.lbl_interesGenerado)
        Me.grpResumen.Controls.Add(Me.lblSubtotalTexto)
        Me.grpResumen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResumen.Location = New System.Drawing.Point(6, 397)
        Me.grpResumen.Name = "grpResumen"
        Me.grpResumen.Size = New System.Drawing.Size(973, 98)
        Me.grpResumen.TabIndex = 13
        Me.grpResumen.TabStop = False
        Me.grpResumen.Text = "RESUMEN DE LA VENTA"
        '
        'cmbMetodoPago
        '
        Me.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMetodoPago.FormattingEnabled = True
        Me.cmbMetodoPago.Items.AddRange(New Object() {"Efectivo", "", "Tarjeta", "", "Transferencia"})
        Me.cmbMetodoPago.Location = New System.Drawing.Point(516, 29)
        Me.cmbMetodoPago.Name = "cmbMetodoPago"
        Me.cmbMetodoPago.Size = New System.Drawing.Size(121, 25)
        Me.cmbMetodoPago.TabIndex = 15
        '
        'lblMetodoPago
        '
        Me.lblMetodoPago.AutoSize = True
        Me.lblMetodoPago.Location = New System.Drawing.Point(397, 32)
        Me.lblMetodoPago.Name = "lblMetodoPago"
        Me.lblMetodoPago.Size = New System.Drawing.Size(113, 17)
        Me.lblMetodoPago.TabIndex = 14
        Me.lblMetodoPago.Text = "Método de Pago:"
        '
        'lblTotalTexto
        '
        Me.lblTotalTexto.AutoSize = True
        Me.lblTotalTexto.Location = New System.Drawing.Point(458, 69)
        Me.lblTotalTexto.Name = "lblTotalTexto"
        Me.lblTotalTexto.Size = New System.Drawing.Size(47, 17)
        Me.lblTotalTexto.TabIndex = 13
        Me.lblTotalTexto.Text = "TOTAL:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(250, 65)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(117, 25)
        Me.txtDescuento.TabIndex = 12
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.lbl_total.Location = New System.Drawing.Point(511, 65)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(92, 25)
        Me.lbl_total.TabIndex = 10
        Me.lbl_total.Text = "RD$ 0.00"
        '
        'lblDescuentoTexto
        '
        Me.lblDescuentoTexto.AutoSize = True
        Me.lblDescuentoTexto.Location = New System.Drawing.Point(169, 69)
        Me.lblDescuentoTexto.Name = "lblDescuentoTexto"
        Me.lblDescuentoTexto.Size = New System.Drawing.Size(75, 17)
        Me.lblDescuentoTexto.TabIndex = 9
        Me.lblDescuentoTexto.Text = "Descuento:"
        '
        'lbl_interesGenerado
        '
        Me.lbl_interesGenerado.AutoSize = True
        Me.lbl_interesGenerado.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_interesGenerado.Location = New System.Drawing.Point(246, 32)
        Me.lbl_interesGenerado.Name = "lbl_interesGenerado"
        Me.lbl_interesGenerado.Size = New System.Drawing.Size(69, 20)
        Me.lbl_interesGenerado.TabIndex = 8
        Me.lbl_interesGenerado.Text = "RD$ 0.00"
        '
        'lblSubtotalTexto
        '
        Me.lblSubtotalTexto.AutoSize = True
        Me.lblSubtotalTexto.Location = New System.Drawing.Point(178, 34)
        Me.lblSubtotalTexto.Name = "lblSubtotalTexto"
        Me.lblSubtotalTexto.Size = New System.Drawing.Size(62, 17)
        Me.lblSubtotalTexto.TabIndex = 5
        Me.lblSubtotalTexto.Text = "Subtotal:"
        '
        'btnImprimirFactura
        '
        Me.btnImprimirFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirFactura.ForeColor = System.Drawing.Color.White
        Me.btnImprimirFactura.Location = New System.Drawing.Point(144, 515)
        Me.btnImprimirFactura.Name = "btnImprimirFactura"
        Me.btnImprimirFactura.Size = New System.Drawing.Size(89, 48)
        Me.btnImprimirFactura.TabIndex = 18
        Me.btnImprimirFactura.Text = "Imprimir Factura"
        Me.btnImprimirFactura.UseVisualStyleBackColor = False
        '
        'btnRegistrarVenta
        '
        Me.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarVenta.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarVenta.Location = New System.Drawing.Point(49, 515)
        Me.btnRegistrarVenta.Name = "btnRegistrarVenta"
        Me.btnRegistrarVenta.Size = New System.Drawing.Size(89, 48)
        Me.btnRegistrarVenta.TabIndex = 14
        Me.btnRegistrarVenta.Text = "Registrar Venta"
        Me.btnRegistrarVenta.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(239, 515)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(89, 48)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btnImprimirFactura)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegistrarVenta)
        Me.Controls.Add(Me.grpResumen)
        Me.Controls.Add(Me.grpArticulos)
        Me.Controls.Add(Me.grpComprador)
        Me.Controls.Add(Me.grpBuscarPrestamo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta de Artículos"
        Me.grpBuscarPrestamo.ResumeLayout(False)
        Me.grpBuscarPrestamo.PerformLayout()
        Me.grpComprador.ResumeLayout(False)
        Me.grpComprador.PerformLayout()
        Me.grpArticulos.ResumeLayout(False)
        Me.grpArticulos.PerformLayout()
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResumen.ResumeLayout(False)
        Me.grpResumen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents grpBuscarPrestamo As GroupBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblFactura As Label
    Friend WithEvents txtNumeroFactura As TextBox
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents grpComprador As GroupBox
    Friend WithEvents txtNombreComprador As TextBox
    Friend WithEvents txtCedulaComprador As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombreComprador As Label
    Friend WithEvents grpArticulos As GroupBox
    Friend WithEvents cmbArticulo As ComboBox
    Friend WithEvents lblBuscarArticulo As Label
    Friend WithEvents btn_agregarArticulo As Button
    Friend WithEvents dgv_articulosPrestamo As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents grpResumen As GroupBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents lblDescuentoTexto As Label
    Friend WithEvents lbl_interesGenerado As Label
    Friend WithEvents lblSubtotalTexto As Label
    Friend WithEvents lblTotalTexto As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents lblMetodoPago As Label
    Friend WithEvents cmbMetodoPago As ComboBox
    Friend WithEvents btnImprimirFactura As Button
    Friend WithEvents btnRegistrarVenta As Button
    Friend WithEvents btnLimpiar As Button
End Class
