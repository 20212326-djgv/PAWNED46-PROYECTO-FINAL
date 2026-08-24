Imports System.Data.SqlClient

Public Class frmClientes

    Private clienteBLL As New ClienteBLL()


    '===========================================================
    ' CARGAR FORMULARIO
    '===========================================================

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarClientes()

    End Sub


    '===========================================================
    ' CARGAR CLIENTES
    '===========================================================

    Private Sub CargarClientes()

        Try

            dgvClientes.DataSource = clienteBLL.ObtenerClientes()

            ConfigurarGrid()

        Catch ex As Exception

            MessageBox.Show(
                "No fue posible cargar los clientes." &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '===========================================================
    ' CONFIGURAR GRID
    '===========================================================

    Private Sub ConfigurarGrid()

        If dgvClientes.Columns.Count = 0 Then
            Return
        End If

        dgvClientes.Columns("IdCliente").Visible = False
        dgvClientes.Columns("CLI_Direccion").Visible = False
        dgvClientes.Columns("CLI_FechaNacimiento").Visible = False

        dgvClientes.Columns("CLI_Cedula").HeaderText = "Cédula"
        dgvClientes.Columns("CLI_Nombre").HeaderText = "Nombre"
        dgvClientes.Columns("CLI_Apellido").HeaderText = "Apellido"
        dgvClientes.Columns("CLI_Telefono").HeaderText = "Teléfono"
        dgvClientes.Columns("CLI_Celular").HeaderText = "Celular"
        dgvClientes.Columns("CLI_Correo").HeaderText = "Correo"
        dgvClientes.Columns("CLI_Estado").HeaderText = "Estado"

    End Sub


    '===========================================================
    ' VALIDAR CAMPOS
    '===========================================================

    Private Function ValidarCampos() As Boolean

        If String.IsNullOrWhiteSpace(txtCedula.Text) Then

            MessageBox.Show(
                "Debe introducir la cédula.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtCedula.Focus()
            Return False

        End If


        If String.IsNullOrWhiteSpace(txtNombre.Text) Then

            MessageBox.Show(
                "Debe introducir el nombre.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNombre.Focus()
            Return False

        End If


        If String.IsNullOrWhiteSpace(txtApellido.Text) Then

            MessageBox.Show(
                "Debe introducir el apellido.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtApellido.Focus()
            Return False

        End If


        If String.IsNullOrWhiteSpace(txtTelefono.Text) Then

            MessageBox.Show(
                "Debe introducir el teléfono.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtTelefono.Focus()
            Return False

        End If


        Return True

    End Function


    '===========================================================
    ' GUARDAR CLIENTE
    '===========================================================

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not ValidarCampos() Then
            Return
        End If

        Try

            Dim cliente As New Cliente()

            cliente.CLI_Cedula = txtCedula.Text.Trim()
            cliente.CLI_Nombre = txtNombre.Text.Trim()
            cliente.CLI_Apellido = txtApellido.Text.Trim()
            cliente.CLI_Telefono = txtTelefono.Text.Trim()
            cliente.CLI_Celular = txtCelular.Text.Trim()
            cliente.CLI_Correo = txtCorreo.Text.Trim()
            cliente.CLI_Direccion = txtDireccion.Text.Trim()

            cliente.CLI_FechaNacimiento = dtpFechaNacimiento.Value.Date

            cliente.CLI_Estado = chkEstado.Checked


            If clienteBLL.InsertarCliente(cliente) Then

                MessageBox.Show(
                    "Cliente registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                CargarClientes()

                LimpiarCampos()

            End If

        Catch ex As SqlException

            If ex.Number = 2627 OrElse ex.Number = 2601 Then

                MessageBox.Show(
                    "La cédula ingresada ya se encuentra registrada.",
                    "Cliente duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            Else

                MessageBox.Show(
                    "Ocurrió un error al guardar el cliente." &
                    Environment.NewLine &
                    ex.Message,
                    "Error de SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo registrar el cliente." &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '===========================================================
    ' LIMPIAR CAMPOS
    '===========================================================

    Private Sub LimpiarCampos()

        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        txtCelular.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()

        chkEstado.Checked = True

        dtpFechaNacimiento.Value = Date.Today

        dgvClientes.ClearSelection()

        txtCedula.Focus()

    End Sub


    '===========================================================
    ' BOTÓN LIMPIAR
    '===========================================================

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        LimpiarCampos()

    End Sub

End Class