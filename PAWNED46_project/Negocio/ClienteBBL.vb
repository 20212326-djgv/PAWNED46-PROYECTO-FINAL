Imports System.Data
Public Class ClienteBLL

    Private clienteDAL As New ClienteDAL()

    Public Function ObtenerClientes() As DataTable

        Return clienteDAL.ObtenerClientes()

    End Function

    Public Function InsertarCliente(cliente As Cliente) As Boolean

        Return clienteDAL.InsertarCliente(cliente)

    End Function

End Class