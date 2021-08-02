Imports CapaDatos, CapaEntidad
Public Class CajaNegocio
    Function cargar_combo_caja() As DataTable
        Try
            Dim dt As New DataTable
            Dim obj As New CajaDatos
            dt = obj.cargar_combo_caja()
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


End Class
