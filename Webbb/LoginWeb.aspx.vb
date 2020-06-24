Imports System.Data



Partial Class LoginWeb
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DvQuery As DataView = DirectCast(SqlDataSource1.Select(DataSourceSelectArguments.Empty), DataView)

        If TxtUsuario.Text <> "" And TxtClave.Text <> "" Then
            If DvQuery.Count > 0 Then
                Session("usuario") = DvQuery(0).Item(0)
                Response.Redirect("index.aspx")
            Else
                Response.Write("credenciales incorrectas")
            End If
        Else
            Response.Write("rellenar campos vacios")
        End If

    End Sub
End Class
