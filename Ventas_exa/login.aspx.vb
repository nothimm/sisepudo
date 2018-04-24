Imports System.Data
Imports System.Data.SqlClient

Partial Class login
    Inherits System.Web.UI.Page
    Dim ds As New DataSet
    Dim usuarios As New Class1
    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        ds = usuarios.seleciona_usuario(Login1.UserName, Login1.Password)
        If ds.Tables(0).Rows.Count = 0 Then Exit Sub
        System.Web.Security.FormsAuthentication.RedirectFromLoginPage(Login1.UserName, False)
        Response.Redirect("index.aspx")
    End Sub
End Class
