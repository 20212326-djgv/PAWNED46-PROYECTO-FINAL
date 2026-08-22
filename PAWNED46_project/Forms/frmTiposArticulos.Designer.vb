<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiposArticulos
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
        Me.grpTipoArticulo = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreTipo = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombreTipo = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.grpTipos = New System.Windows.Forms.GroupBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpTipoArticulo.SuspendLayout()
        Me.grpTipos.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(246, 32)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "TIPOS DE ARTÍCULOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpTipoArticulo
        '
        Me.grpTipoArticulo.BackColor = System.Drawing.Color.White
        Me.grpTipoArticulo.Controls.Add(Me.chkEstado)
        Me.grpTipoArticulo.Controls.Add(Me.lblEstado)
        Me.grpTipoArticulo.Controls.Add(Me.txtdescripcion)
        Me.grpTipoArticulo.Controls.Add(Me.txtNombreTipo)
        Me.grpTipoArticulo.Controls.Add(Me.lblDescripcion)
        Me.grpTipoArticulo.Controls.Add(Me.lblNombreTipo)
        Me.grpTipoArticulo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTipoArticulo.Location = New System.Drawing.Point(6, 35)
        Me.grpTipoArticulo.Name = "grpTipoArticulo"
        Me.grpTipoArticulo.Size = New System.Drawing.Size(766, 159)
        Me.grpTipoArticulo.TabIndex = 12
        Me.grpTipoArticulo.TabStop = False
        Me.grpTipoArticulo.Text = "INFORMACION DEL TIPO"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(80, 71)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(52, 17)
        Me.lblEstado.TabIndex = 11
        Me.lblEstado.Text = "Estado:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(389, 40)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ReadOnly = True
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(285, 84)
        Me.txtdescripcion.TabIndex = 8
        '
        'txtNombreTipo
        '
        Me.txtNombreTipo.Location = New System.Drawing.Point(139, 40)
        Me.txtNombreTipo.Name = "txtNombreTipo"
        Me.txtNombreTipo.ReadOnly = True
        Me.txtNombreTipo.Size = New System.Drawing.Size(149, 25)
        Me.txtNombreTipo.TabIndex = 4
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(303, 43)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 17)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblNombreTipo
        '
        Me.lblNombreTipo.AutoSize = True
        Me.lblNombreTipo.Location = New System.Drawing.Point(19, 43)
        Me.lblNombreTipo.Name = "lblNombreTipo"
        Me.lblNombreTipo.Size = New System.Drawing.Size(113, 17)
        Me.lblNombreTipo.TabIndex = 3
        Me.lblNombreTipo.Text = "Nombre del Tipo:"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Location = New System.Drawing.Point(138, 71)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(95, 21)
        Me.chkEstado.TabIndex = 17
        Me.chkEstado.Text = "Tipo Activo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'grpTipos
        '
        Me.grpTipos.BackColor = System.Drawing.Color.White
        Me.grpTipos.Controls.Add(Me.dgvUsuarios)
        Me.grpTipos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTipos.Location = New System.Drawing.Point(6, 200)
        Me.grpTipos.Name = "grpTipos"
        Me.grpTipos.Size = New System.Drawing.Size(766, 229)
        Me.grpTipos.TabIndex = 30
        Me.grpTipos.TabStop = False
        Me.grpTipos.Text = "TIPOS REGISTRADOS"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Descripcion, Me.Estado})
        Me.dgvUsuarios.Location = New System.Drawing.Point(36, 24)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(724, 183)
        Me.dgvUsuarios.TabIndex = 8
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(346, 446)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(95, 39)
        Me.btnLimpiar.TabIndex = 37
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnDesactivar
        '
        Me.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesactivar.ForeColor = System.Drawing.Color.White
        Me.btnDesactivar.Location = New System.Drawing.Point(245, 446)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(95, 39)
        Me.btnDesactivar.TabIndex = 36
        Me.btnDesactivar.Text = "Desactivar"
        Me.btnDesactivar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(144, 446)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 39)
        Me.btnEditar.TabIndex = 35
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(43, 446)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 39)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmTiposArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnDesactivar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpTipos)
        Me.Controls.Add(Me.grpTipoArticulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmTiposArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Artículos"
        Me.grpTipoArticulo.ResumeLayout(False)
        Me.grpTipoArticulo.PerformLayout()
        Me.grpTipos.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents grpTipoArticulo As GroupBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtNombreTipo As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombreTipo As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents grpTipos As GroupBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
End Class
