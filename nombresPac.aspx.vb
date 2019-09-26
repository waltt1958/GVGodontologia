Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Partial Class nombresPac
    Inherits System.Web.UI.Page

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged


        Session("aYnombre") = GridView1.Rows(GridView1.SelectedIndex).Cells(1).Text
        Session("direccion") = GridView1.Rows(GridView1.SelectedIndex).Cells(2).Text
        Session("cp") = GridView1.Rows(GridView1.SelectedIndex).Cells(3).Text
        Session("localidad") = GridView1.Rows(GridView1.SelectedIndex).Cells(4).Text
        Session("telediscado") = GridView1.Rows(GridView1.SelectedIndex).Cells(5).Text
        Session("celular") = GridView1.Rows(GridView1.SelectedIndex).Cells(6).Text
        Session("fijo") = GridView1.Rows(GridView1.SelectedIndex).Cells(7).Text
        Session("sexo") = GridView1.Rows(GridView1.SelectedIndex).Cells(8).Text
        Session("fechaNacimiento") = GridView1.Rows(GridView1.SelectedIndex).Cells(9).Text
        Session("dni") = GridView1.Rows(GridView1.SelectedIndex).Cells(10).Text
        Session("mail") = GridView1.Rows(GridView1.SelectedIndex).Cells(11).Text
        Session("categoria") = GridView1.Rows(GridView1.SelectedIndex).Cells(12).Text
        Session("obraSocial") = GridView1.Rows(GridView1.SelectedIndex).Cells(13).Text
        Session("historiaClinica") = GridView1.Rows(GridView1.SelectedIndex).Cells(14).Text
        Response.Write("<script>window.setTimeout(location.href='modifPaciente.aspx', 2000);</script>")

    End Sub

End Class
