Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Partial Class buscaHistClinica
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        buscaApe.Focus()

    End Sub

    Protected Sub btVERIFICA_Click(sender As Object, e As EventArgs) Handles btVERIFICA.Click

        Dim con As New OleDbConnection
        Dim sql As String

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")

        con.Open()
        Dim oDataReader As OleDbDataReader
        Session("apellido") = ""
        Select Case radio2.SelectedValue

            Case "Documento"
                sql = "Select * from pacientes where dni= ?"
                Dim cmd As New OleDbCommand(sql, con)
                cmd.Parameters.Add(New OleDbParameter("dni", OleDbType.VarChar, 10))
                cmd.Parameters("dni").Value = buscaApe.Text
                oDataReader = cmd.ExecuteReader()

                If oDataReader.Read() = True Then
                    Session("apellido") = buscaApe.Text.ToString
                    oDataReader.Close()
                    con.Close()

                    Response.Write("<script>window.setTimeout(location.href='historiaClinica.aspx', 2000);</script>")

                Else
                    Dim message As String = "No se encuentra ese documento. Veririque los datos ingresados"
                    Dim sb As New System.Text.StringBuilder()
                    sb.Append("<script type = 'text/javascript'>")
                    sb.Append("window.onload=function(){")
                    sb.Append("alert('")
                    sb.Append(message)
                    sb.Append("')};")
                    sb.Append("</script>")
                    ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                    Session.Remove("alta")

                End If

                oDataReader.Close()
                con.Close()

            Case "Apellido"

                sql = "Select * from pacientes where aYnombre like ?"
                Dim cmd As New OleDbCommand(sql, con)
                cmd.Parameters.Add(New OleDbParameter("aYnombre", OleDbType.VarChar, 60))
                cmd.Parameters("aYnombre").Value = buscaApe.Text
                oDataReader = cmd.ExecuteReader()

                Session("apellido") = buscaApe.Text.ToString

                oDataReader.Close()
                con.Close()
                Response.Write("<script>window.setTimeout(location.href='buscaHistClinica1.aspx', 2000);</script>")

            Case Else

                Dim message As String = "Seleccione si la búsqueda es por APELLIDO o DOCUMENTO"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                Session.Remove("alta")
                Session("radio") = radio2.Text

                con.Close()

        End Select

    End Sub

End Class
