<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoria
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
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.cmbTabla = New System.Windows.Forms.ComboBox()
        Me.cmbAccion = New System.Windows.Forms.ComboBox()
        Me.lblTabla = New System.Windows.Forms.Label()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.btnBuscarPrestamo = New System.Windows.Forms.Button()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.grpHistorial = New System.Windows.Forms.GroupBox()
        Me.dgvAuditoria = New System.Windows.Forms.DataGridView()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tabla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.grpFiltros.SuspendLayout()
        Me.grpHistorial.SuspendLayout()
        CType(Me.dgvAuditoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(-1, -1)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(247, 32)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Auditoria del Sistema"
        '
        'grpFiltros
        '
        Me.grpFiltros.BackColor = System.Drawing.Color.White
        Me.grpFiltros.Controls.Add(Me.btnLimpiar)
        Me.grpFiltros.Controls.Add(Me.dtpFechaFin)
        Me.grpFiltros.Controls.Add(Me.dtpFechaInicio)
        Me.grpFiltros.Controls.Add(Me.lblFechaFin)
        Me.grpFiltros.Controls.Add(Me.lblFechaInicio)
        Me.grpFiltros.Controls.Add(Me.cmbTabla)
        Me.grpFiltros.Controls.Add(Me.cmbAccion)
        Me.grpFiltros.Controls.Add(Me.lblTabla)
        Me.grpFiltros.Controls.Add(Me.lblAccion)
        Me.grpFiltros.Controls.Add(Me.btnBuscarPrestamo)
        Me.grpFiltros.Controls.Add(Me.cmbUsuario)
        Me.grpFiltros.Controls.Add(Me.lblUsuario)
        Me.grpFiltros.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltros.Location = New System.Drawing.Point(12, 34)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(1060, 150)
        Me.grpFiltros.TabIndex = 3
        Me.grpFiltros.TabStop = False
        Me.grpFiltros.Text = "Filtros de Auditoria"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Silver
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(787, 108)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(76, 28)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(657, 66)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(137, 25)
        Me.dtpFechaFin.TabIndex = 20
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(657, 35)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(137, 25)
        Me.dtpFechaInicio.TabIndex = 19
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(573, 66)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(78, 17)
        Me.lblFechaFin.TabIndex = 18
        Me.lblFechaFin.Text = "Fecha Final:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(567, 38)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(84, 17)
        Me.lblFechaInicio.TabIndex = 17
        Me.lblFechaInicio.Text = "Fecha Inicial:"
        '
        'cmbTabla
        '
        Me.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTabla.FormattingEnabled = True
        Me.cmbTabla.Items.AddRange(New Object() {"Todas", "Clientes", "Articulos", "Prestamos", "Pagos", "Renovaciones", "Ventas", "Gastos", "Usuarios"})
        Me.cmbTabla.Location = New System.Drawing.Point(379, 35)
        Me.cmbTabla.Name = "cmbTabla"
        Me.cmbTabla.Size = New System.Drawing.Size(143, 25)
        Me.cmbTabla.TabIndex = 12
        '
        'cmbAccion
        '
        Me.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccion.FormattingEnabled = True
        Me.cmbAccion.Items.AddRange(New Object() {"Todas", "INSERTAR", "ACTUALIZAR", "ELIMINAR", "INICIAR SESIÓN", "CERRAR SESIÓN", "PAGO", "PRÉSTAMO", "RENOVACIÓN", "VENTA"})
        Me.cmbAccion.Location = New System.Drawing.Point(142, 74)
        Me.cmbAccion.Name = "cmbAccion"
        Me.cmbAccion.Size = New System.Drawing.Size(143, 25)
        Me.cmbAccion.TabIndex = 11
        '
        'lblTabla
        '
        Me.lblTabla.AutoSize = True
        Me.lblTabla.Location = New System.Drawing.Point(328, 38)
        Me.lblTabla.Name = "lblTabla"
        Me.lblTabla.Size = New System.Drawing.Size(42, 17)
        Me.lblTabla.TabIndex = 5
        Me.lblTabla.Text = "Tabla:"
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(82, 75)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(51, 17)
        Me.lblAccion.TabIndex = 3
        Me.lblAccion.Text = "Acción:"
        '
        'btnBuscarPrestamo
        '
        Me.btnBuscarPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnBuscarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPrestamo.ForeColor = System.Drawing.Color.White
        Me.btnBuscarPrestamo.Location = New System.Drawing.Point(705, 108)
        Me.btnBuscarPrestamo.Name = "btnBuscarPrestamo"
        Me.btnBuscarPrestamo.Size = New System.Drawing.Size(76, 28)
        Me.btnBuscarPrestamo.TabIndex = 2
        Me.btnBuscarPrestamo.Text = "Buscar"
        Me.btnBuscarPrestamo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscarPrestamo.UseVisualStyleBackColor = False
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Items.AddRange(New Object() {"Todos", "Admin", "Empleado", "Cajero", "..."})
        Me.cmbUsuario.Location = New System.Drawing.Point(142, 35)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(143, 25)
        Me.cmbUsuario.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(76, 38)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'grpHistorial
        '
        Me.grpHistorial.BackColor = System.Drawing.Color.White
        Me.grpHistorial.Controls.Add(Me.dgvAuditoria)
        Me.grpHistorial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistorial.Location = New System.Drawing.Point(12, 190)
        Me.grpHistorial.Name = "grpHistorial"
        Me.grpHistorial.Size = New System.Drawing.Size(1060, 373)
        Me.grpHistorial.TabIndex = 13
        Me.grpHistorial.TabStop = False
        Me.grpHistorial.Text = "HISTORIAL DE AUDITORIA"
        '
        'dgvAuditoria
        '
        Me.dgvAuditoria.AllowUserToAddRows = False
        Me.dgvAuditoria.AllowUserToDeleteRows = False
        Me.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAuditoria.BackgroundColor = System.Drawing.Color.White
        Me.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAuditoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usuario, Me.Accion, Me.Tabla, Me.Registro, Me.FechaHora, Me.Equipo, Me.Descripcion})
        Me.dgvAuditoria.Location = New System.Drawing.Point(94, 24)
        Me.dgvAuditoria.MultiSelect = False
        Me.dgvAuditoria.Name = "dgvAuditoria"
        Me.dgvAuditoria.ReadOnly = True
        Me.dgvAuditoria.RowHeadersVisible = False
        Me.dgvAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAuditoria.Size = New System.Drawing.Size(853, 343)
        Me.dgvAuditoria.TabIndex = 11
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'Accion
        '
        Me.Accion.HeaderText = "Accion"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        '
        'Tabla
        '
        Me.Tabla.HeaderText = "Tabla"
        Me.Tabla.Name = "Tabla"
        Me.Tabla.ReadOnly = True
        '
        'Registro
        '
        Me.Registro.HeaderText = "Registro"
        Me.Registro.Name = "Registro"
        Me.Registro.ReadOnly = True
        '
        'FechaHora
        '
        Me.FechaHora.HeaderText = "Fecha y Hora"
        Me.FechaHora.Name = "FechaHora"
        Me.FechaHora.ReadOnly = True
        '
        'Equipo
        '
        Me.Equipo.HeaderText = "Equipo"
        Me.Equipo.Name = "Equipo"
        Me.Equipo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.ForeColor = System.Drawing.Color.Transparent
        Me.btnExportar.Location = New System.Drawing.Point(962, 569)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(110, 37)
        Me.btnExportar.TabIndex = 22
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'frmAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.grpHistorial)
        Me.Controls.Add(Me.grpFiltros)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmAuditoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditoria del Sistema"
        Me.grpFiltros.ResumeLayout(False)
        Me.grpFiltros.PerformLayout()
        Me.grpHistorial.ResumeLayout(False)
        CType(Me.dgvAuditoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents grpFiltros As GroupBox
    Friend WithEvents lblTabla As Label
    Friend WithEvents lblAccion As Label
    Friend WithEvents btnBuscarPrestamo As Button
    Friend WithEvents cmbUsuario As ComboBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents cmbAccion As ComboBox
    Friend WithEvents cmbTabla As ComboBox
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents grpHistorial As GroupBox
    Friend WithEvents dgvAuditoria As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewTextBoxColumn
    Friend WithEvents Tabla As DataGridViewTextBoxColumn
    Friend WithEvents Registro As DataGridViewTextBoxColumn
    Friend WithEvents FechaHora As DataGridViewTextBoxColumn
    Friend WithEvents Equipo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As Button
End Class
