﻿Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Imports System.Web.UI.WebControls
Partial Class altaPaciente1
    Inherits System.Web.UI.Page

    Protected Sub btVERIFICA_Click(sender As Object, e As EventArgs) Handles btVERIFICA.Click
        Dim con As New OleDbConnection
        Dim sql As String

        sql = "Select * from pacientes where dni= ?"

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")

        con.Open()
        Dim oDataReader As OleDbDataReader

        Dim cmd As New OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDbParameter("dni", OleDbType.VarChar, 10))
        cmd.Parameters("dni").Value = VERIFdni.Text
        oDataReader = cmd.ExecuteReader()

        If oDataReader.Read() = True Then
            Session("alta") = "existeLeg"
            Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")
        Else
            Session("guardaDNI") = VERIFdni.Text
            Response.Write("<script>window.setTimeout(location.href='altaPaciente.aspx', 2000);</script>")

        End If

        oDataReader.Close()
        con.Close()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        VERIFdni.Focus()
    End Sub


End Class
