<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.grpGasto = New System.Windows.Forms.GroupBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblConfirmarContrasena = New System.Windows.Forms.Label()
        Me.txtConfirmarContrasena = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.grpSeguridad = New System.Windows.Forms.GroupBox()
        Me.chkAccesoSistema = New System.Windows.Forms.CheckBox()
        Me.chkCambioCOntrasena = New System.Windows.Forms.CheckBox()
        Me.grpUsuarios = New System.Windows.Forms.GroupBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btnDesactivar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpGasto.SuspendLayout()
        Me.grpSeguridad.SuspendLayout()
        Me.grpUsuarios.SuspendLayout()
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
        Me.lblTitulo.Size = New System.Drawing.Size(374, 32)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "ADMINISTRACION DE USUARIOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpGasto
        '
        Me.grpGasto.BackColor = System.Drawing.Color.White
        Me.grpGasto.Controls.Add(Me.chkEstado)
        Me.grpGasto.Controls.Add(Me.lblRol)
        Me.grpGasto.Controls.Add(Me.txtTelefono)
        Me.grpGasto.Controls.Add(Me.lblTelefono)
        Me.grpGasto.Controls.Add(Me.txtCorreo)
        Me.grpGasto.Controls.Add(Me.lblCorreo)
        Me.grpGasto.Controls.Add(Me.txtConfirmarContrasena)
        Me.grpGasto.Controls.Add(Me.lblConfirmarContrasena)
        Me.grpGasto.Controls.Add(Me.txtNombreUsuario)
        Me.grpGasto.Controls.Add(Me.lblNombreUsuario)
        Me.grpGasto.Controls.Add(Me.cmbCategoria)
        Me.grpGasto.Controls.Add(Me.txtContrasena)
        Me.grpGasto.Controls.Add(Me.lblContrasena)
        Me.grpGasto.Controls.Add(Me.txtApellido)
        Me.grpGasto.Controls.Add(Me.txtNombre)
        Me.grpGasto.Controls.Add(Me.lblApellido)
        Me.grpGasto.Controls.Add(Me.lblNombre)
        Me.grpGasto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGasto.Location = New System.Drawing.Point(6, 35)
        Me.grpGasto.Name = "grpGasto"
        Me.grpGasto.Size = New System.Drawing.Size(962, 159)
        Me.grpGasto.TabIndex = 12
        Me.grpGasto.TabStop = False
        Me.grpGasto.Text = "INFORMACION DEL USUARIO"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(3, 109)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(130, 17)
        Me.lblNombreUsuario.TabIndex = 16
        Me.lblNombreUsuario.Text = "Nombre de Usuario:"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Items.AddRange(New Object() {"Administrador", "Empleado", "Cajero"})
        Me.cmbCategoria.Location = New System.Drawing.Point(689, 70)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(149, 25)
        Me.cmbCategoria.TabIndex = 15
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(441, 40)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(160, 25)
        Me.txtContrasena.TabIndex = 10
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(357, 44)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(80, 17)
        Me.lblContrasena.TabIndex = 9
        Me.lblContrasena.Text = "Contraseña:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(139, 73)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(149, 25)
        Me.txtApellido.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(139, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(149, 25)
        Me.txtNombre.TabIndex = 4
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(73, 76)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(60, 17)
        Me.lblApellido.TabIndex = 7
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(72, 44)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(61, 17)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(140, 105)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(149, 25)
        Me.txtNombreUsuario.TabIndex = 18
        '
        'lblConfirmarContrasena
        '
        Me.lblConfirmarContrasena.AutoSize = True
        Me.lblConfirmarContrasena.Location = New System.Drawing.Point(293, 74)
        Me.lblConfirmarContrasena.Name = "lblConfirmarContrasena"
        Me.lblConfirmarContrasena.Size = New System.Drawing.Size(144, 17)
        Me.lblConfirmarContrasena.TabIndex = 19
        Me.lblConfirmarContrasena.Text = "Confirmar Contraseña:"
        '
        'txtConfirmarContrasena
        '
        Me.txtConfirmarContrasena.Location = New System.Drawing.Point(441, 70)
        Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        Me.txtConfirmarContrasena.Size = New System.Drawing.Size(160, 25)
        Me.txtConfirmarContrasena.TabIndex = 20
        Me.txtConfirmarContrasena.UseSystemPasswordChar = True
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(442, 105)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(160, 25)
        Me.txtCorreo.TabIndex = 22
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(385, 109)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(52, 17)
        Me.lblCorreo.TabIndex = 21
        Me.lblCorreo.Text = "Correo:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(689, 40)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(149, 25)
        Me.txtTelefono.TabIndex = 24
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(622, 44)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(62, 17)
        Me.lblTelefono.TabIndex = 23
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(654, 73)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(30, 17)
        Me.lblRol.TabIndex = 25
        Me.lblRol.Text = "Rol:"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Location = New System.Drawing.Point(689, 107)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(115, 21)
        Me.chkEstado.TabIndex = 27
        Me.chkEstado.Text = "Usuario Activo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'grpSeguridad
        '
        Me.grpSeguridad.BackColor = System.Drawing.Color.White
        Me.grpSeguridad.Controls.Add(Me.chkCambioCOntrasena)
        Me.grpSeguridad.Controls.Add(Me.chkAccesoSistema)
        Me.grpSeguridad.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSeguridad.Location = New System.Drawing.Point(6, 200)
        Me.grpSeguridad.Name = "grpSeguridad"
        Me.grpSeguridad.Size = New System.Drawing.Size(962, 82)
        Me.grpSeguridad.TabIndex = 28
        Me.grpSeguridad.TabStop = False
        Me.grpSeguridad.Text = "SEGURIDAD Y ACCESO"
        '
        'chkAccesoSistema
        '
        Me.chkAccesoSistema.AutoSize = True
        Me.chkAccesoSistema.Checked = True
        Me.chkAccesoSistema.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAccesoSistema.Location = New System.Drawing.Point(75, 24)
        Me.chkAccesoSistema.Name = "chkAccesoSistema"
        Me.chkAccesoSistema.Size = New System.Drawing.Size(186, 21)
        Me.chkAccesoSistema.TabIndex = 27
        Me.chkAccesoSistema.Text = "Permitir Acceso al Sistema"
        Me.chkAccesoSistema.UseVisualStyleBackColor = True
        '
        'chkCambioCOntrasena
        '
        Me.chkCambioCOntrasena.AutoSize = True
        Me.chkCambioCOntrasena.Location = New System.Drawing.Point(75, 51)
        Me.chkCambioCOntrasena.Name = "chkCambioCOntrasena"
        Me.chkCambioCOntrasena.Size = New System.Drawing.Size(216, 21)
        Me.chkCambioCOntrasena.TabIndex = 28
        Me.chkCambioCOntrasena.Text = "Solicitar Cambio de Contraseña"
        Me.chkCambioCOntrasena.UseVisualStyleBackColor = True
        '
        'grpUsuarios
        '
        Me.grpUsuarios.BackColor = System.Drawing.Color.White
        Me.grpUsuarios.Controls.Add(Me.dgvUsuarios)
        Me.grpUsuarios.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUsuarios.Location = New System.Drawing.Point(6, 288)
        Me.grpUsuarios.Name = "grpUsuarios"
        Me.grpUsuarios.Size = New System.Drawing.Size(962, 229)
        Me.grpUsuarios.TabIndex = 29
        Me.grpUsuarios.TabStop = False
        Me.grpUsuarios.Text = "USUARIOS REGISTRADOS"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Usuario, Me.Rol, Me.Correo, Me.Telefono, Me.Estado})
        Me.dgvUsuarios.Location = New System.Drawing.Point(36, 24)
        Me.dgvUsuarios.MultiSelect = False
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(881, 183)
        Me.dgvUsuarios.TabIndex = 8
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Rol
        '
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.ReadOnly = True
        '
        'Correo
        '
        Me.Correo.HeaderText = "Correo"
        Me.Correo.Name = "Correo"
        Me.Correo.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_limpiar.Location = New System.Drawing.Point(345, 562)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(95, 39)
        Me.btn_limpiar.TabIndex = 33
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btnDesactivar
        '
        Me.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesactivar.ForeColor = System.Drawing.Color.White
        Me.btnDesactivar.Location = New System.Drawing.Point(244, 562)
        Me.btnDesactivar.Name = "btnDesactivar"
        Me.btnDesactivar.Size = New System.Drawing.Size(95, 39)
        Me.btnDesactivar.TabIndex = 32
        Me.btnDesactivar.Text = "Desactivar"
        Me.btnDesactivar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(143, 562)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 39)
        Me.btnEditar.TabIndex = 31
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(42, 562)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(95, 39)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(975, 740)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btnDesactivar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpUsuarios)
        Me.Controls.Add(Me.grpSeguridad)
        Me.Controls.Add(Me.grpGasto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Usuarios"
        Me.grpGasto.ResumeLayout(False)
        Me.grpGasto.PerformLayout()
        Me.grpSeguridad.ResumeLayout(False)
        Me.grpSeguridad.PerformLayout()
        Me.grpUsuarios.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents grpGasto As GroupBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtConfirmarContrasena As TextBox
    Friend WithEvents lblConfirmarContrasena As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents lblRol As Label
    Friend WithEvents grpSeguridad As GroupBox
    Friend WithEvents chkAccesoSistema As CheckBox
    Friend WithEvents chkCambioCOntrasena As CheckBox
    Friend WithEvents grpUsuarios As GroupBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Rol As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
End Class
