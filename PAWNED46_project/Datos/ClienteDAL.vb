Imports System.Data.SqlClient


Public Class ClienteDAL

    Public Function ObtenerClientes() As DataTable

        Dim tabla As New DataTable()

        Using conexion As SqlConnection = ConexionDB.ObtenerConexion()

            Dim consulta As String =
                "SELECT " &
                "IdCliente, " &
                "CLI_Cedula, " &
                "CLI_Nombre, " &
                "CLI_Apellido, " &
                "CLI_Telefono, " &
                "CLI_Celular, " &
                "CLI_Correo, " &
                "CLI_Direccion, " &
                "CLI_FechaNacimiento, " &
                "CLI_Estado " &
                "FROM Clientes " &
                "ORDER BY CLI_Apellido, CLI_Nombre"

            Using comando As New SqlCommand(consulta, conexion)

                Using adaptador As New SqlDataAdapter(comando)

                    adaptador.Fill(tabla)

                End Using

            End Using

        End Using

        Return tabla

    End Function

    Public Function InsertarCliente(cliente As Cliente) As Boolean

        Using conexion As SqlConnection = ConexionDB.ObtenerConexion()

            Dim consulta As String =
                "INSERT INTO Clientes " &
                "(" &
                "CLI_Cedula, " &
                "CLI_Nombre, " &
                "CLI_Apellido, " &
                "CLI_Telefono, " &
                "CLI_Celular, " &
                "CLI_Correo, " &
                "CLI_Direccion, " &
                "CLI_FechaNacimiento, " &
                "CLI_Estado" &
                ") " &
                "VALUES " &
                "(" &
                "@Cedula, " &
                "@Nombre, " &
                "@Apellido, " &
                "@Telefono, " &
                "@Celular, " &
                "@Correo, " &
                "@Direccion, " &
                "@FechaNacimiento, " &
                "@Estado" &
                ")"

            Using comando As New SqlCommand(consulta, conexion)

                comando.Parameters.AddWithValue("@Cedula", cliente.CLI_Cedula)
                comando.Parameters.AddWithValue("@Nombre", cliente.CLI_Nombre)
                comando.Parameters.AddWithValue("@Apellido", cliente.CLI_Apellido)
                comando.Parameters.AddWithValue("@Telefono", cliente.CLI_Telefono)
                comando.Parameters.AddWithValue("@Celular", cliente.CLI_Celular)
                comando.Parameters.AddWithValue("@Correo", cliente.CLI_Correo)
                comando.Parameters.AddWithValue("@Direccion", cliente.CLI_Direccion)

                If cliente.CLI_FechaNacimiento.HasValue Then
                    comando.Parameters.AddWithValue(
                        "@FechaNacimiento",
                        cliente.CLI_FechaNacimiento.Value
                    )
                Else
                    comando.Parameters.AddWithValue(
                        "@FechaNacimiento",
                        DBNull.Value
                    )
                End If

                comando.Parameters.AddWithValue("@Estado", cliente.CLI_Estado)

                conexion.Open()

                Return comando.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function



End Class