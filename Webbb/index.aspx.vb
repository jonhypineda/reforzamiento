
Partial Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        LblUsuario.Text = Session("usuario")
    End Sub
End Class
