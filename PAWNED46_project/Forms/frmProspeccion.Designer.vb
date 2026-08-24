<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProspeccion
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
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.btncerrarSesion = New System.Windows.Forms.Button()
        Me.btnAuditoria = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnGastos = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnRenovaciones = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTituloModulo = New System.Windows.Forms.Label()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPagosDia = New System.Windows.Forms.Label()
        Me.lblTituloPagos = New System.Windows.Forms.Label()
        Me.grpProximosVencer = New System.Windows.Forms.GroupBox()
        Me.dgv_articulosPrestamo = New System.Windows.Forms.DataGridView()
        Me.Contrato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCantidadVencidos = New System.Windows.Forms.Label()
        Me.lblTituloVencidos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCapitalPrestado = New System.Windows.Forms.Label()
        Me.pnlPrestamosActivos = New System.Windows.Forms.Panel()
        Me.lblCantidadPrestamos = New System.Windows.Forms.Label()
        Me.lblTituloPrestamosActivos = New System.Windows.Forms.Label()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.pnl_menu.SuspendLayout()
        Me.pnlBotones.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenido.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.grpProximosVencer.SuspendLayout()
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlPrestamosActivos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnl_menu.Controls.Add(Me.lblSubtitulo)
        Me.pnl_menu.Controls.Add(Me.lblLogo)
        Me.pnl_menu.Controls.Add(Me.pnlBotones)
        Me.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_menu.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(220, 691)
        Me.pnl_menu.TabIndex = 0
        '
        'lblSubtitulo
        '
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.White
        Me.lblSubtitulo.Location = New System.Drawing.Point(1, 27)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        Me.lblSubtitulo.Size = New System.Drawing.Size(222, 30)
        Me.lblSubtitulo.TabIndex = 1
        Me.lblSubtitulo.Text = "SISTEMA DE GESTION"
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(3, 0)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(129, 30)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "PAWNED 46"
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.btncerrarSesion)
        Me.pnlBotones.Controls.Add(Me.btnAuditoria)
        Me.pnlBotones.Controls.Add(Me.btnUsuarios)
        Me.pnlBotones.Controls.Add(Me.btnReportes)
        Me.pnlBotones.Controls.Add(Me.btnGastos)
        Me.pnlBotones.Controls.Add(Me.btnVentas)
        Me.pnlBotones.Controls.Add(Me.btnRenovaciones)
        Me.pnlBotones.Controls.Add(Me.btnPagos)
        Me.pnlBotones.Controls.Add(Me.btnPrestamos)
        Me.pnlBotones.Controls.Add(Me.btnArticulos)
        Me.pnlBotones.Controls.Add(Me.btnClientes)
        Me.pnlBotones.Controls.Add(Me.btnDashboard)
        Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBotones.Location = New System.Drawing.Point(0, 0)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(220, 691)
        Me.pnlBotones.TabIndex = 0
        '
        'btncerrarSesion
        '
        Me.btncerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btncerrarSesion.FlatAppearance.BorderSize = 0
        Me.btncerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btncerrarSesion.Location = New System.Drawing.Point(0, 668)
        Me.btncerrarSesion.Name = "btncerrarSesion"
        Me.btncerrarSesion.Size = New System.Drawing.Size(220, 23)
        Me.btncerrarSesion.TabIndex = 11
        Me.btncerrarSesion.Text = "Cerrar Sesion"
        Me.btncerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncerrarSesion.UseVisualStyleBackColor = True
        '
        'btnAuditoria
        '
        Me.btnAuditoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAuditoria.FlatAppearance.BorderSize = 0
        Me.btnAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditoria.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAuditoria.ForeColor = System.Drawing.Color.White
        Me.btnAuditoria.Location = New System.Drawing.Point(0, 465)
        Me.btnAuditoria.Name = "btnAuditoria"
        Me.btnAuditoria.Size = New System.Drawing.Size(220, 45)
        Me.btnAuditoria.TabIndex = 10
        Me.btnAuditoria.Text = "Auditoria"
        Me.btnAuditoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuditoria.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 420)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(220, 45)
        Me.btnUsuarios.TabIndex = 9
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Location = New System.Drawing.Point(0, 375)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(220, 45)
        Me.btnReportes.TabIndex = 8
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnGastos
        '
        Me.btnGastos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGastos.FlatAppearance.BorderSize = 0
        Me.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGastos.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGastos.ForeColor = System.Drawing.Color.White
        Me.btnGastos.Location = New System.Drawing.Point(0, 330)
        Me.btnGastos.Name = "btnGastos"
        Me.btnGastos.Size = New System.Drawing.Size(220, 45)
        Me.btnGastos.TabIndex = 7
        Me.btnGastos.Text = "Gastos"
        Me.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGastos.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Location = New System.Drawing.Point(0, 285)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(220, 45)
        Me.btnVentas.TabIndex = 6
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnRenovaciones
        '
        Me.btnRenovaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRenovaciones.FlatAppearance.BorderSize = 0
        Me.btnRenovaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRenovaciones.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenovaciones.ForeColor = System.Drawing.Color.White
        Me.btnRenovaciones.Location = New System.Drawing.Point(0, 240)
        Me.btnRenovaciones.Name = "btnRenovaciones"
        Me.btnRenovaciones.Size = New System.Drawing.Size(220, 45)
        Me.btnRenovaciones.TabIndex = 5
        Me.btnRenovaciones.Text = "Renovaciones"
        Me.btnRenovaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRenovaciones.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPagos.FlatAppearance.BorderSize = 0
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagos.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagos.ForeColor = System.Drawing.Color.White
        Me.btnPagos.Location = New System.Drawing.Point(0, 195)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(220, 45)
        Me.btnPagos.TabIndex = 4
        Me.btnPagos.Text = "Pagos"
        Me.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'btnPrestamos
        '
        Me.btnPrestamos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPrestamos.FlatAppearance.BorderSize = 0
        Me.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrestamos.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrestamos.ForeColor = System.Drawing.Color.White
        Me.btnPrestamos.Location = New System.Drawing.Point(0, 150)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(220, 45)
        Me.btnPrestamos.TabIndex = 3
        Me.btnPrestamos.Text = "Prestamos"
        Me.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrestamos.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArticulos.FlatAppearance.BorderSize = 0
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.ForeColor = System.Drawing.Color.White
        Me.btnArticulos.Location = New System.Drawing.Point(0, 105)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(220, 45)
        Me.btnArticulos.TabIndex = 2
        Me.btnArticulos.Text = "Artículos"
        Me.btnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Location = New System.Drawing.Point(0, 60)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(220, 45)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Controls.Add(Me.PictureBox1)
        Me.pnlHeader.Controls.Add(Me.lblTituloModulo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(964, 60)
        Me.pnlHeader.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(806, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USUARIO: Admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.PAWNED46_project.My.Resources.Resources.user_account_person_avatar_icon_131248
        Me.PictureBox1.Location = New System.Drawing.Point(906, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblTituloModulo
        '
        Me.lblTituloModulo.AutoSize = True
        Me.lblTituloModulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloModulo.Location = New System.Drawing.Point(25, 21)
        Me.lblTituloModulo.Name = "lblTituloModulo"
        Me.lblTituloModulo.Size = New System.Drawing.Size(105, 25)
        Me.lblTituloModulo.TabIndex = 1
        Me.lblTituloModulo.Text = "Dashboard"
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlContenido.Controls.Add(Me.Panel3)
        Me.pnlContenido.Controls.Add(Me.grpProximosVencer)
        Me.pnlContenido.Controls.Add(Me.Panel2)
        Me.pnlContenido.Controls.Add(Me.Panel1)
        Me.pnlContenido.Controls.Add(Me.pnlPrestamosActivos)
        Me.pnlContenido.Controls.Add(Me.lblResumen)
        Me.pnlContenido.Controls.Add(Me.lblBienvenida)
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlContenido.Location = New System.Drawing.Point(220, 60)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(964, 631)
        Me.pnlContenido.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblPagosDia)
        Me.Panel3.Controls.Add(Me.lblTituloPagos)
        Me.Panel3.Location = New System.Drawing.Point(456, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(107, 55)
        Me.Panel3.TabIndex = 6
        '
        'lblPagosDia
        '
        Me.lblPagosDia.AutoSize = True
        Me.lblPagosDia.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagosDia.Location = New System.Drawing.Point(21, 29)
        Me.lblPagosDia.Name = "lblPagosDia"
        Me.lblPagosDia.Size = New System.Drawing.Size(54, 15)
        Me.lblPagosDia.TabIndex = 2
        Me.lblPagosDia.Text = "RD$0.00"
        '
        'lblTituloPagos
        '
        Me.lblTituloPagos.AutoSize = True
        Me.lblTituloPagos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPagos.Location = New System.Drawing.Point(3, 5)
        Me.lblTituloPagos.Name = "lblTituloPagos"
        Me.lblTituloPagos.Size = New System.Drawing.Size(93, 15)
        Me.lblTituloPagos.TabIndex = 1
        Me.lblTituloPagos.Text = "PAGOS DEL DIA"
        '
        'grpProximosVencer
        '
        Me.grpProximosVencer.BackColor = System.Drawing.Color.White
        Me.grpProximosVencer.Controls.Add(Me.dgv_articulosPrestamo)
        Me.grpProximosVencer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProximosVencer.Location = New System.Drawing.Point(109, 167)
        Me.grpProximosVencer.Name = "grpProximosVencer"
        Me.grpProximosVencer.Size = New System.Drawing.Size(647, 275)
        Me.grpProximosVencer.TabIndex = 19
        Me.grpProximosVencer.TabStop = False
        Me.grpProximosVencer.Text = "PRESTAMOS PROXIMOS A VENCER"
        '
        'dgv_articulosPrestamo
        '
        Me.dgv_articulosPrestamo.AllowUserToAddRows = False
        Me.dgv_articulosPrestamo.AllowUserToDeleteRows = False
        Me.dgv_articulosPrestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_articulosPrestamo.BackgroundColor = System.Drawing.Color.White
        Me.dgv_articulosPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_articulosPrestamo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Contrato, Me.Cliente, Me.Vencimiento, Me.Saldo})
        Me.dgv_articulosPrestamo.Location = New System.Drawing.Point(36, 24)
        Me.dgv_articulosPrestamo.MultiSelect = False
        Me.dgv_articulosPrestamo.Name = "dgv_articulosPrestamo"
        Me.dgv_articulosPrestamo.ReadOnly = True
        Me.dgv_articulosPrestamo.RowHeadersVisible = False
        Me.dgv_articulosPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_articulosPrestamo.Size = New System.Drawing.Size(596, 245)
        Me.dgv_articulosPrestamo.TabIndex = 8
        '
        'Contrato
        '
        Me.Contrato.HeaderText = "Contrato"
        Me.Contrato.Name = "Contrato"
        Me.Contrato.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Vencimiento
        '
        Me.Vencimiento.HeaderText = "Vencimiento"
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblCantidadVencidos)
        Me.Panel2.Controls.Add(Me.lblTituloVencidos)
        Me.Panel2.Location = New System.Drawing.Point(613, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(143, 55)
        Me.Panel2.TabIndex = 6
        '
        'lblCantidadVencidos
        '
        Me.lblCantidadVencidos.AutoSize = True
        Me.lblCantidadVencidos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadVencidos.Location = New System.Drawing.Point(63, 29)
        Me.lblCantidadVencidos.Name = "lblCantidadVencidos"
        Me.lblCantidadVencidos.Size = New System.Drawing.Size(14, 15)
        Me.lblCantidadVencidos.TabIndex = 2
        Me.lblCantidadVencidos.Text = "0"
        '
        'lblTituloVencidos
        '
        Me.lblTituloVencidos.AutoSize = True
        Me.lblTituloVencidos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVencidos.Location = New System.Drawing.Point(3, 5)
        Me.lblTituloVencidos.Name = "lblTituloVencidos"
        Me.lblTituloVencidos.Size = New System.Drawing.Size(137, 15)
        Me.lblTituloVencidos.TabIndex = 1
        Me.lblTituloVencidos.Text = "PRÉSTAMOS VENCIDOS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCapitalPrestado)
        Me.Panel1.Location = New System.Drawing.Point(278, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 55)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RD$0.00"
        '
        'lblCapitalPrestado
        '
        Me.lblCapitalPrestado.AutoSize = True
        Me.lblCapitalPrestado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapitalPrestado.Location = New System.Drawing.Point(3, 5)
        Me.lblCapitalPrestado.Name = "lblCapitalPrestado"
        Me.lblCapitalPrestado.Size = New System.Drawing.Size(115, 15)
        Me.lblCapitalPrestado.TabIndex = 1
        Me.lblCapitalPrestado.Text = "CAPITAL PRESTADO"
        '
        'pnlPrestamosActivos
        '
        Me.pnlPrestamosActivos.BackColor = System.Drawing.Color.White
        Me.pnlPrestamosActivos.Controls.Add(Me.lblCantidadPrestamos)
        Me.pnlPrestamosActivos.Controls.Add(Me.lblTituloPrestamosActivos)
        Me.pnlPrestamosActivos.Location = New System.Drawing.Point(105, 95)
        Me.pnlPrestamosActivos.Name = "pnlPrestamosActivos"
        Me.pnlPrestamosActivos.Size = New System.Drawing.Size(113, 55)
        Me.pnlPrestamosActivos.TabIndex = 4
        '
        'lblCantidadPrestamos
        '
        Me.lblCantidadPrestamos.AutoSize = True
        Me.lblCantidadPrestamos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadPrestamos.Location = New System.Drawing.Point(47, 29)
        Me.lblCantidadPrestamos.Name = "lblCantidadPrestamos"
        Me.lblCantidadPrestamos.Size = New System.Drawing.Size(14, 15)
        Me.lblCantidadPrestamos.TabIndex = 2
        Me.lblCantidadPrestamos.Text = "0"
        '
        'lblTituloPrestamosActivos
        '
        Me.lblTituloPrestamosActivos.AutoSize = True
        Me.lblTituloPrestamosActivos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPrestamosActivos.Location = New System.Drawing.Point(3, 5)
        Me.lblTituloPrestamosActivos.Name = "lblTituloPrestamosActivos"
        Me.lblTituloPrestamosActivos.Size = New System.Drawing.Size(104, 15)
        Me.lblTituloPrestamosActivos.TabIndex = 1
        Me.lblTituloPrestamosActivos.Text = "Prestamos Activos"
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResumen.Location = New System.Drawing.Point(3, 30)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(194, 19)
        Me.lblResumen.TabIndex = 3
        Me.lblResumen.Text = "Resumen General del Sistema"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(-7, -3)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(330, 37)
        Me.lblBienvenida.TabIndex = 2
        Me.lblBienvenida.Text = "Bienvenido a PAWNED 46"
        '
        'frmProspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 691)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnl_menu)
        Me.Name = "frmProspeccion"
        Me.Text = "frmProspeccion"
        Me.pnl_menu.ResumeLayout(False)
        Me.pnl_menu.PerformLayout()
        Me.pnlBotones.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.grpProximosVencer.ResumeLayout(False)
        CType(Me.dgv_articulosPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlPrestamosActivos.ResumeLayout(False)
        Me.pnlPrestamosActivos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_menu As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents pnlBotones As Panel
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents btnPagos As Button
    Friend WithEvents btnPrestamos As Button
    Friend WithEvents btnArticulos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btncerrarSesion As Button
    Friend WithEvents btnAuditoria As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnGastos As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnRenovaciones As Button
    Friend WithEvents lblTituloModulo As Label
    Friend WithEvents lblResumen As Label
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents pnlPrestamosActivos As Panel
    Friend WithEvents lblTituloPrestamosActivos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCantidadVencidos As Label
    Friend WithEvents lblTituloVencidos As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCapitalPrestado As Label
    Friend WithEvents lblCantidadPrestamos As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPagosDia As Label
    Friend WithEvents lblTituloPagos As Label
    Friend WithEvents grpProximosVencer As GroupBox
    Friend WithEvents dgv_articulosPrestamo As DataGridView
    Friend WithEvents Contrato As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Vencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
