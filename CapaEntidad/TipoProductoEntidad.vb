Imports System.Drawing

Public Class TipoProductoEntidad

    Private _CODIGO_PLATOS As Integer
    Public Property CODIGO_PLATOS() As Integer
        Get
            Return _CODIGO_PLATOS
        End Get
        Set(ByVal value As Integer)
            _CODIGO_PLATOS = value
        End Set
    End Property


    Private _STOCK As String
    Public Property STOCK() As String
        Get
            Return _STOCK
        End Get
        Set(ByVal value As String)
            _STOCK = value
        End Set
    End Property

    Private _NOMBRE As String
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property

    Private _FOTO_P As Array
    Public Property FOTO_P() As Array

        Get
            Return _FOTO_P
        End Get
        Set(ByVal value As Array)
            _FOTO_P = value
        End Set
    End Property

End Class
