
Partial Class cumpleanosDefault
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Session("mesActual") = Month(Now).ToString

    End Sub


    Protected Sub conexCumpleanos_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles conexCumpleanos.Selecting

    End Sub
End Class
