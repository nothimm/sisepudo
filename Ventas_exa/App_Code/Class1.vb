Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class Class1
    Public Function seleciona_usuario(usuario As String, contrasena As String) As DataSet
        Dim cadena As New StringBuilder
        Dim ds As New DataSet
        With cadena
            .Append("select * From Usuarios where usuario ='")
            .Append(usuario & "'and clave='")
            .Append(contrasena & "'")
        End With
        Using cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
            Using cmd As New SqlCommand(cadena.ToString, cn)
                Dim da As New SqlDataAdapter
                cn.Open()
                da.SelectCommand = cmd
                da.Fill(ds)
                cn.Close()
                Return ds
            End Using
        End Using


    End Function

End Class
