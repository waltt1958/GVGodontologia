Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports System.Data.OleDb.OleDbCommand
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Imports System.Web.UI.WebControls
Imports System.IO


Partial Class bajaPaciente
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        dni.Text = Session("guardaDNI")
        aYnombre.Text = Session("guardaaYnombre")
    End Sub

    Protected Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        dni.Text = String.Empty
        aYnombre.Text = String.Empty
        Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")
        Session("guardaDNI") = ""
        Session("guardaaYnombre") = ""
        Session("baja") = "nada"

    End Sub

    Protected Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Session("guardaDNI") = ""
        Session("guardaaYnombre") = ""
        Session("baja") = "nada"
    End Sub

    Protected Sub btbaja_Click(sender As Object, e As EventArgs) Handles btbaja.Click

        Dim con As New OleDbConnection
        Dim sql As String

        sql = "DELETE * from pacientes where dni= ?"

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")

        con.Open()

        Dim odatareader As Integer
        Dim cmd As New OleDbCommand(sql, con)

        cmd.Parameters.Add(New OleDbParameter("dni", OleDbType.VarChar, 10))
        cmd.Parameters("dni").Value = dni.Text
        odatareader = cmd.ExecuteNonQuery()


        If odatareader = 1 Then

            Session("baja") = "si"
            Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")

        Else
            Session("baja") = "error"
            Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")
        End If

        con.Close()


    End Sub
End Class
