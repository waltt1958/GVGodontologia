Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Imports System.IO


Partial Class cumpleanosDefault
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Session("mesActual") = Month(Now).ToString

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

        Dim mensaje, saludo, saludoFinal, direccion As String

        mensaje = "GVG Odongologia le desea que pase un muy feliz cumpleaños."
        saludo = "Afectuoso saludo de"
        saludoFinal = " Dra. Guadalupe Vicente Galan"
        direccion = "España xxx - Rosario // Telefono: 4251589"




    End Sub

End Class
