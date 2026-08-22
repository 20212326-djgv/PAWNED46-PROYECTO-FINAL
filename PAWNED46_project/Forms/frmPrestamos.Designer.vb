<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_agregarArticulo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grp_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.cb_cliente = New System.Windows.Forms.ComboBox()
        Me.grp_prestamo = New System.Windows.Forms.GroupBox()
        Me.dtp_fechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nud_plazo = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_tasaInteres = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_montoPrestado = New System.Windows.Forms.TextBox()
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_contrato = New System.Windows.Forms.TextBox()
        Me.grp_garantia = New System.Windows.Forms.GroupBox()
        Me.dgv_articulosPrestamo = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor_Prestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_resumen = New System.Windows.Forms.GroupBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_totalTexto = New System.Windows.Forms.Label()
        Me.lbl_interesGenerado = New System.Windows.Forms.Label()
        Me.lbl_interesGeneradoTexto = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.grp_cliente.SuspendLayout()
        Me.grp_prestamo.SuspendLayout()
        CType(Me.nud_plazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_garantia.SuspendLayout()
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_resumen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NUEVO PRESTAMO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. Contrato:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cliente:"
        '
        'btn_agregarArticulo
        '
        Me.btn_agregarArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_agregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregarArticulo.ForeColor = System.Drawing.Color.White
        Me.btn_agregarArticulo.Location = New System.Drawing.Point(34, 35)
        Me.btn_agregarArticulo.Name = "btn_agregarArticulo"
        Me.btn_agregarArticulo.Size = New System.Drawing.Size(166, 29)
        Me.btn_agregarArticulo.TabIndex = 6
        Me.btn_agregarArticulo.Text = "+ Agregar Artículo"
        Me.btn_agregarArticulo.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Monto Prestado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(445, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cédula:"
        '
        'grp_cliente
        '
        Me.grp_cliente.BackColor = System.Drawing.Color.White
        Me.grp_cliente.Controls.Add(Me.txt_cedula)
        Me.grp_cliente.Controls.Add(Me.cb_cliente)
        Me.grp_cliente.Controls.Add(Me.Label6)
        Me.grp_cliente.Controls.Add(Me.Label4)
        Me.grp_cliente.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_cliente.Location = New System.Drawing.Point(34, 35)
        Me.grp_cliente.Name = "grp_cliente"
        Me.grp_cliente.Size = New System.Drawing.Size(920, 84)
        Me.grp_cliente.TabIndex = 9
        Me.grp_cliente.TabStop = False
        Me.grp_cliente.Text = "DATOS DEL CLIENTE"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(505, 36)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.ReadOnly = True
        Me.txt_cedula.Size = New System.Drawing.Size(203, 25)
        Me.txt_cedula.TabIndex = 9
        '
        'cb_cliente
        '
        Me.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cliente.FormattingEnabled = True
        Me.cb_cliente.Location = New System.Drawing.Point(139, 36)
        Me.cb_cliente.Name = "cb_cliente"
        Me.cb_cliente.Size = New System.Drawing.Size(233, 25)
        Me.cb_cliente.TabIndex = 6
        '
        'grp_prestamo
        '
        Me.grp_prestamo.BackColor = System.Drawing.Color.White
        Me.grp_prestamo.Controls.Add(Me.dtp_fechaVencimiento)
        Me.grp_prestamo.Controls.Add(Me.Label9)
        Me.grp_prestamo.Controls.Add(Me.nud_plazo)
        Me.grp_prestamo.Controls.Add(Me.Label8)
        Me.grp_prestamo.Controls.Add(Me.txt_tasaInteres)
        Me.grp_prestamo.Controls.Add(Me.Label7)
        Me.grp_prestamo.Controls.Add(Me.txt_montoPrestado)
        Me.grp_prestamo.Controls.Add(Me.dtp_Fecha)
        Me.grp_prestamo.Controls.Add(Me.txt_contrato)
        Me.grp_prestamo.Controls.Add(Me.Label5)
        Me.grp_prestamo.Controls.Add(Me.Label2)
        Me.grp_prestamo.Controls.Add(Me.Label3)
        Me.grp_prestamo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_prestamo.Location = New System.Drawing.Point(34, 125)
        Me.grp_prestamo.Name = "grp_prestamo"
        Me.grp_prestamo.Size = New System.Drawing.Size(920, 132)
        Me.grp_prestamo.TabIndex = 10
        Me.grp_prestamo.TabStop = False
        Me.grp_prestamo.Text = "DATOS DEL PRESTAMO"
        '
        'dtp_fechaVencimiento
        '
        Me.dtp_fechaVencimiento.Enabled = False
        Me.dtp_fechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaVencimiento.Location = New System.Drawing.Point(621, 40)
        Me.dtp_fechaVencimiento.Name = "dtp_fechaVencimiento"
        Me.dtp_fechaVencimiento.Size = New System.Drawing.Size(117, 25)
        Me.dtp_fechaVencimiento.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(478, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Fecha de Vencimiento:"
        '
        'nud_plazo
        '
        Me.nud_plazo.Location = New System.Drawing.Point(655, 79)
        Me.nud_plazo.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nud_plazo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_plazo.Name = "nud_plazo"
        Me.nud_plazo.Size = New System.Drawing.Size(120, 25)
        Me.nud_plazo.TabIndex = 12
        Me.nud_plazo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(558, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Plazo (meses):"
        '
        'txt_tasaInteres
        '
        Me.txt_tasaInteres.Location = New System.Drawing.Point(399, 79)
        Me.txt_tasaInteres.Name = "txt_tasaInteres"
        Me.txt_tasaInteres.ReadOnly = True
        Me.txt_tasaInteres.Size = New System.Drawing.Size(149, 25)
        Me.txt_tasaInteres.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(294, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tasa de Interés:"
        '
        'txt_montoPrestado
        '
        Me.txt_montoPrestado.Location = New System.Drawing.Point(139, 79)
        Me.txt_montoPrestado.Name = "txt_montoPrestado"
        Me.txt_montoPrestado.ReadOnly = True
        Me.txt_montoPrestado.Size = New System.Drawing.Size(149, 25)
        Me.txt_montoPrestado.TabIndex = 8
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(344, 40)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(117, 25)
        Me.dtp_Fecha.TabIndex = 5
        '
        'txt_contrato
        '
        Me.txt_contrato.Location = New System.Drawing.Point(139, 40)
        Me.txt_contrato.Name = "txt_contrato"
        Me.txt_contrato.ReadOnly = True
        Me.txt_contrato.Size = New System.Drawing.Size(149, 25)
        Me.txt_contrato.TabIndex = 4
        '
        'grp_garantia
        '
        Me.grp_garantia.BackColor = System.Drawing.Color.White
        Me.grp_garantia.Controls.Add(Me.dgv_articulosPrestamo)
        Me.grp_garantia.Controls.Add(Me.btn_agregarArticulo)
        Me.grp_garantia.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_garantia.Location = New System.Drawing.Point(34, 263)
        Me.grp_garantia.Name = "grp_garantia"
        Me.grp_garantia.Size = New System.Drawing.Size(920, 179)
        Me.grp_garantia.TabIndex = 10
        Me.grp_garantia.TabStop = False
        Me.grp_garantia.Text = "ARTICULO EN GARANTIA"
        '
        'dgv_articulosPrestamo
        '
        Me.dgv_articulosPrestamo.AllowUserToAddRows = False
        Me.dgv_articulosPrestamo.AllowUserToDeleteRows = False
        Me.dgv_articulosPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_articulosPrestamo.BackgroundColor = System.Drawing.Color.White
        Me.dgv_articulosPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulosPrestamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Tipo, Me.Descripción, Me.Valor, Me.Valor_Prestamo})
        Me.dgv_articulosPrestamo.Location = New System.Drawing.Point(34, 70)
        Me.dgv_articulosPrestamo.MultiSelect = False
        Me.dgv_articulosPrestamo.Name = "dgv_articulosPrestamo"
        Me.dgv_articulosPrestamo.ReadOnly = True
        Me.dgv_articulosPrestamo.RowHeadersVisible = False
        Me.dgv_articulosPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulosPrestamo.Size = New System.Drawing.Size(853, 91)
        Me.dgv_articulosPrestamo.TabIndex = 7
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'Valor_Prestamo
        '
        Me.Valor_Prestamo.HeaderText = "Valor Prestamo"
        Me.Valor_Prestamo.Name = "Valor_Prestamo"
        Me.Valor_Prestamo.ReadOnly = True
        '
        'grp_resumen
        '
        Me.grp_resumen.BackColor = System.Drawing.Color.White
        Me.grp_resumen.Controls.Add(Me.lbl_total)
        Me.grp_resumen.Controls.Add(Me.lbl_totalTexto)
        Me.grp_resumen.Controls.Add(Me.lbl_interesGenerado)
        Me.grp_resumen.Controls.Add(Me.lbl_interesGeneradoTexto)
        Me.grp_resumen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_resumen.Location = New System.Drawing.Point(34, 448)
        Me.grp_resumen.Name = "grp_resumen"
        Me.grp_resumen.Size = New System.Drawing.Size(920, 106)
        Me.grp_resumen.TabIndex = 10
        Me.grp_resumen.TabStop = False
        Me.grp_resumen.Text = "RESUMEN"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.lbl_total.Location = New System.Drawing.Point(205, 56)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(92, 25)
        Me.lbl_total.TabIndex = 10
        Me.lbl_total.Text = "RD$ 0.00"
        '
        'lbl_totalTexto
        '
        Me.lbl_totalTexto.AutoSize = True
        Me.lbl_totalTexto.Location = New System.Drawing.Point(111, 62)
        Me.lbl_totalTexto.Name = "lbl_totalTexto"
        Me.lbl_totalTexto.Size = New System.Drawing.Size(91, 17)
        Me.lbl_totalTexto.TabIndex = 9
        Me.lbl_totalTexto.Text = "Total a Pagar:"
        '
        'lbl_interesGenerado
        '
        Me.lbl_interesGenerado.AutoSize = True
        Me.lbl_interesGenerado.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_interesGenerado.Location = New System.Drawing.Point(206, 21)
        Me.lbl_interesGenerado.Name = "lbl_interesGenerado"
        Me.lbl_interesGenerado.Size = New System.Drawing.Size(69, 20)
        Me.lbl_interesGenerado.TabIndex = 8
        Me.lbl_interesGenerado.Text = "RD$ 0.00"
        '
        'lbl_interesGeneradoTexto
        '
        Me.lbl_interesGeneradoTexto.AutoSize = True
        Me.lbl_interesGeneradoTexto.Location = New System.Drawing.Point(88, 21)
        Me.lbl_interesGeneradoTexto.Name = "lbl_interesGeneradoTexto"
        Me.lbl_interesGeneradoTexto.Size = New System.Drawing.Size(116, 17)
        Me.lbl_interesGeneradoTexto.TabIndex = 5
        Me.lbl_interesGeneradoTexto.Text = "Interés Generado:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(34, 585)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(95, 39)
        Me.btn_guardar.TabIndex = 11
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_limpiar.Location = New System.Drawing.Point(135, 585)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(95, 39)
        Me.btn_limpiar.TabIndex = 12
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(236, 585)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(95, 39)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'frmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.grp_resumen)
        Me.Controls.Add(Me.grp_garantia)
        Me.Controls.Add(Me.grp_prestamo)
        Me.Controls.Add(Me.grp_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmPrestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrestamos"
        Me.grp_cliente.ResumeLayout(False)
        Me.grp_cliente.PerformLayout()
        Me.grp_prestamo.ResumeLayout(False)
        Me.grp_prestamo.PerformLayout()
        CType(Me.nud_plazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_garantia.ResumeLayout(False)
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_resumen.ResumeLayout(False)
        Me.grp_resumen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_agregarArticulo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grp_cliente As GroupBox
    Friend WithEvents cb_cliente As ComboBox
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents grp_prestamo As GroupBox
    Friend WithEvents txt_contrato As TextBox
    Friend WithEvents dtp_Fecha As DateTimePicker
    Friend WithEvents txt_montoPrestado As TextBox
    Friend WithEvents nud_plazo As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_tasaInteres As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_fechaVencimiento As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents grp_garantia As GroupBox
    Friend WithEvents dgv_articulosPrestamo As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Valor_Prestamo As DataGridViewTextBoxColumn
    Friend WithEvents grp_resumen As GroupBox
    Friend WithEvents lbl_interesGenerado As Label
    Friend WithEvents lbl_interesGeneradoTexto As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_totalTexto As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_cancelar As Button
End Class
