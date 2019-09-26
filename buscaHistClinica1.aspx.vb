Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Imports System.Web.UI.WebControls
Partial Class nombresPac
    Inherits System.Web.UI.Page

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

        ' Session("aYnombre") = GridView1.Rows(GridView1.SelectedIndex).Cells(1).Text
        Session("apellido") = GridView1.Rows(GridView1.SelectedIndex).Cells(2).Text
        'Session("direccion") = GridView1.Rows(GridView1.SelectedIndex).Cells(3).Text
        Response.Write("<script>window.setTimeout(location.href='historiaClinica.aspx', 2000);</script>")

    End Sub

End Class
