Imports System.Data.SqlClient

Public Class ConexionDB

    Private Shared ReadOnly cadenaConexion As String =
        "Data Source=.\SQLEXPRESS;" &
        "Initial Catalog=Pawned46_project;" &
        "Integrated Security=True;" &
        "TrustServerCertificate=True;"

    Public Shared Function ObtenerConexion() As SqlConnection

        Return New SqlConnection(cadenaConexion)

    End Function

End Class