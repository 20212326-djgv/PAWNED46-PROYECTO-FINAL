Public Class frmProspeccion

    Private Sub CargarDashboard()

        'Aquí posteriormente cargaremos los datos reales
        'de préstamos, pagos, vencimientos, etc.

    End Sub

    Private Sub AbrirFormulario(formulario As Form)


        For Each control As Control In pnlContenido.Controls
            If TypeOf control Is Form Then
                control.Dispose()
            End If
        Next

        pnlContenido.Controls.Clear()


        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill


        pnlContenido.Controls.Add(formulario)

        formulario.Show()

    End Sub


    Private Sub lblTituloPrestamosActivos_Click(sender As Object, e As EventArgs) Handles lblTituloPrestamosActivos.Click

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        lblTituloModulo.Text = "Clientes"

        AbrirFormulario(New frmClientes())

    End Sub
    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click

        lblTituloModulo.Text = "Artículos"

        AbrirFormulario(New frmArticulos())

    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click

        lblTituloModulo.Text = "Préstamos"

        AbrirFormulario(New frmPrestamos())

    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click

        lblTituloModulo.Text = "Pagos"

        AbrirFormulario(New frmPagos())

    End Sub

    Private Sub btnRenovaciones_Click(sender As Object, e As EventArgs) Handles btnRenovaciones.Click

        lblTituloModulo.Text = "Renovaciones"

        AbrirFormulario(New frmRenovaciones())

    End Sub
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click

        lblTituloModulo.Text = "Ventas"

        AbrirFormulario(New frmVentas())

    End Sub
    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click

        lblTituloModulo.Text = "Gastos"

        AbrirFormulario(New frmGastos())

    End Sub
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click

        lblTituloModulo.Text = "Reportes"

        AbrirFormulario(New frmReportes())

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        lblTituloModulo.Text = "Usuarios"

        AbrirFormulario(New frmUsuarios())

    End Sub

    Private Sub btnAuditoria_Click(sender As Object, e As EventArgs) Handles btnAuditoria.Click

        lblTituloModulo.Text = "Auditoría"

        AbrirFormulario(New frmAuditoria())

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        pnlContenido.Controls.Clear()

        lblTituloModulo.Text = "Dashboard"

        CargarDashboard()

    End Sub

    Private Sub frmProspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTituloModulo.Text = "Dashboard"
    End Sub
End Class