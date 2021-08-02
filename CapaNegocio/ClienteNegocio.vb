Imports CapaEntidad, CapaDatos
Public Class ClienteNegocio


    Dim clientes As New ClientesDatos
    Public Function buscarCliente(ByVal pDescripcion As String) As List(Of ClienteEntidad)
        Try
            Return clientes.buscarCliente(pDescripcion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function


    Public Function recuperarCliente(ByVal codigo As String) As List(Of ClienteEntidad)
        recuperarCliente = Nothing
        Try
            Dim lista As New List(Of ClienteEntidad)
            Dim obj As New ClientesDatos
            lista = obj.recuperarCliente(codigo)
            Return lista
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


End Class
