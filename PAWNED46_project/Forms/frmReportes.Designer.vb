<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.grpTipoReporte = New System.Windows.Forms.GroupBox()
        Me.cmbTipoReporte = New System.Windows.Forms.ComboBox()
        Me.lblTipoReporte = New System.Windows.Forms.Label()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.lblContrato = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.cmbContrato = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.pnlVistaPrevia = New System.Windows.Forms.Panel()
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grpTipoReporte.SuspendLayout()
        Me.grpFiltros.SuspendLayout()
        Me.pnlVistaPrevia.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(-1, -2)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(243, 32)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Reportes del Sistema"
        '
        'grpTipoReporte
        '
        Me.grpTipoReporte.BackColor = System.Drawing.Color.White
        Me.grpTipoReporte.Controls.Add(Me.cmbTipoReporte)
        Me.grpTipoReporte.Controls.Add(Me.lblTipoReporte)
        Me.grpTipoReporte.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTipoReporte.Location = New System.Drawing.Point(12, 33)
        Me.grpTipoReporte.Name = "grpTipoReporte"
        Me.grpTipoReporte.Size = New System.Drawing.Size(941, 82)
        Me.grpTipoReporte.TabIndex = 2
        Me.grpTipoReporte.TabStop = False
        Me.grpTipoReporte.Text = "SELECCIONAR REPORTE"
        '
        'cmbTipoReporte
        '
        Me.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoReporte.FormattingEnabled = True
        Me.cmbTipoReporte.Items.AddRange(New Object() {"Préstamos activos", "Préstamos vencidos", "Historial de pagos", "Ingresos por período", "Artículos empeñados", "Artículos vendidos", "Clientes registrados", "Gastos", "Movimientos de caja"})
        Me.cmbTipoReporte.Location = New System.Drawing.Point(160, 35)
        Me.cmbTipoReporte.Name = "cmbTipoReporte"
        Me.cmbTipoReporte.Size = New System.Drawing.Size(143, 25)
        Me.cmbTipoReporte.TabIndex = 1
        '
        'lblTipoReporte
        '
        Me.lblTipoReporte.AutoSize = True
        Me.lblTipoReporte.Location = New System.Drawing.Point(46, 38)
        Me.lblTipoReporte.Name = "lblTipoReporte"
        Me.lblTipoReporte.Size = New System.Drawing.Size(108, 17)
        Me.lblTipoReporte.TabIndex = 0
        Me.lblTipoReporte.Text = "Tipo de Reporte:"
        '
        'grpFiltros
        '
        Me.grpFiltros.BackColor = System.Drawing.Color.White
        Me.grpFiltros.Controls.Add(Me.cmbContrato)
        Me.grpFiltros.Controls.Add(Me.cmbCliente)
        Me.grpFiltros.Controls.Add(Me.dtpFechaFin)
        Me.grpFiltros.Controls.Add(Me.dtpFechaInicio)
        Me.grpFiltros.Controls.Add(Me.lblContrato)
        Me.grpFiltros.Controls.Add(Me.lblCliente)
        Me.grpFiltros.Controls.Add(Me.lblFechaFin)
        Me.grpFiltros.Controls.Add(Me.lblFechaInicio)
        Me.grpFiltros.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltros.Location = New System.Drawing.Point(12, 121)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(368, 344)
        Me.grpFiltros.TabIndex = 11
        Me.grpFiltros.TabStop = False
        Me.grpFiltros.Text = "FILTROS"
        '
        'lblContrato
        '
        Me.lblContrato.AutoSize = True
        Me.lblContrato.Location = New System.Drawing.Point(40, 100)
        Me.lblContrato.Name = "lblContrato"
        Me.lblContrato.Size = New System.Drawing.Size(90, 17)
        Me.lblContrato.TabIndex = 7
        Me.lblContrato.Text = "No. Contrato:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(78, 131)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(52, 17)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Cliente:"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(52, 66)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(78, 17)
        Me.lblFechaFin.TabIndex = 3
        Me.lblFechaFin.Text = "Fecha Final:"
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarReporte.ForeColor = System.Drawing.Color.White
        Me.btnGenerarReporte.Location = New System.Drawing.Point(93, 493)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(108, 57)
        Me.btnGenerarReporte.TabIndex = 2
        Me.btnGenerarReporte.Text = "Generar Reporte"
        Me.btnGenerarReporte.UseVisualStyleBackColor = False
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(46, 38)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(84, 17)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Fecha Inicial:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(136, 35)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(137, 25)
        Me.dtpFechaInicio.TabIndex = 15
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(136, 66)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(137, 25)
        Me.dtpFechaFin.TabIndex = 16
        '
        'cmbCliente
        '
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Items.AddRange(New Object() {"TODOS"})
        Me.cmbCliente.Location = New System.Drawing.Point(136, 128)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(143, 25)
        Me.cmbCliente.TabIndex = 3
        '
        'cmbContrato
        '
        Me.cmbContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContrato.FormattingEnabled = True
        Me.cmbContrato.Items.AddRange(New Object() {"TODOS"})
        Me.cmbContrato.Location = New System.Drawing.Point(136, 97)
        Me.cmbContrato.Name = "cmbContrato"
        Me.cmbContrato.Size = New System.Drawing.Size(143, 25)
        Me.cmbContrato.TabIndex = 17
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(207, 493)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(108, 57)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'pnlVistaPrevia
        '
        Me.pnlVistaPrevia.Controls.Add(Me.crvReporte)
        Me.pnlVistaPrevia.Location = New System.Drawing.Point(572, 135)
        Me.pnlVistaPrevia.Name = "pnlVistaPrevia"
        Me.pnlVistaPrevia.Size = New System.Drawing.Size(381, 495)
        Me.pnlVistaPrevia.TabIndex = 13
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporte.Location = New System.Drawing.Point(0, 0)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.Size = New System.Drawing.Size(381, 495)
        Me.crvReporte.TabIndex = 0
        Me.crvReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 705)
        Me.Controls.Add(Me.pnlVistaPrevia)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.grpFiltros)
        Me.Controls.Add(Me.grpTipoReporte)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmReportes"
        Me.Text = "frmReportes"
        Me.grpTipoReporte.ResumeLayout(False)
        Me.grpTipoReporte.PerformLayout()
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        Me.pnlVistaPrevia.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents grpTipoReporte As GroupBox
    Friend WithEvents grpFiltros As GroupBox
    Friend WithEvents lblContrato As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents cmbTipoReporte As ComboBox
    Friend WithEvents lblTipoReporte As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbContrato As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents pnlVistaPrevia As Panel
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
