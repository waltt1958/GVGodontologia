Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Imports System.Web.UI.WebControls.GridViewRowCollection
Imports System.IO

Partial Class historiaClinica
    Inherits System.Web.UI.Page

    Protected Sub Subir_Click(sender As Object, e As EventArgs) Handles Subir.Click
        If cargArchivo.HasFile Then
            If File.Exists(Server.MapPath("fotosPac/") + cargArchivo.FileName) Then
                Dim message As String = "El archivo existe. Cambie el nombre y vuelva a cargarlo"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            Else

                cargArchivo.SaveAs("c:\inetpub\wwwroot\GVGodontologia\fotosPac\" & cargArchivo.FileName)
                Dim insertar As String
                Dim con As New OleDbConnection
                Dim ruta1 As String = "/fotosPac/"
                Dim ruta2 As String = cargArchivo.FileName
                Dim ruta As String = ruta1 & Trim(ruta2)
                insertar = "INSERT INTO fotos (dni, link) VALUES ('" & Session("apellido") & "', '" & ruta & "')"
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")
                con.Open()
                Try

                    Dim cmdInsertar As New OleDbCommand(insertar, con)
                    cmdInsertar.ExecuteNonQuery()

                Catch ex As Exception

                    Dim message As String = "Expiró la sesión. Vuelva a ingresar"
                    Dim sb As New System.Text.StringBuilder()
                    sb.Append("<script type = 'text/javascript'>")
                    sb.Append("window.onload=function(){")
                    sb.Append("alert('")
                    sb.Append(message)
                    sb.Append("')};")
                    sb.Append("</script>")
                    ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                    Response.Write("<script>window.setTimeout(location.href='buscaHistClinica.aspx', 2000);</script>")

                End Try

                con.Close()
            End If
        Else

            Dim message As String = "No seleccionó ningún archivo"
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())

        End If
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

        Dim con As New OleDbConnection
        Dim sql As String

        sql = "DELETE * from fotos where link= ?"

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")

        con.Open()


        Dim odatareader As Integer
        Dim cmd As New OleDbCommand(sql, con)

        cmd.Parameters.Add(New OleDbParameter("link", OleDbType.VarChar, 50))
        cmd.Parameters("link").Value = GridView1.Rows(GridView1.SelectedIndex).Cells(0).Text
        odatareader = cmd.ExecuteNonQuery()

        Dim borraArchivo As String
        borraArchivo = GridView1.Rows(GridView1.SelectedIndex).Cells(0).Text
        If File.Exists(Server.MapPath(borraArchivo)) Then
            File.Delete(Server.MapPath(borraArchivo))

        End If

        con.Close()

        GridView1.DataBind()



    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnGrabar.Visible = True
        historia.ReadOnly = False
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        Dim con As New OleDbConnection
        Dim sql As String
        Dim actualizar As String

        sql = "Select * from pacientes where dni= ?"

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")

        con.Open()
        Dim oDataReader As OleDbDataReader

        Dim cmd As New OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDbParameter("dni", OleDbType.VarChar, 10))
        cmd.Parameters("dni").Value = Session("apellido")
        oDataReader = cmd.ExecuteReader()

        If oDataReader.Read() = True Then

            actualizar = "UPDATE pacientes SET historiaClinica= '" & historia.Text & "' where dni = '" & Session("apellido").ToString & "'"
            Dim cmd1 As New OleDbCommand(actualizar, con)
            cmd1.ExecuteNonQuery()
            con.Close()

        End If

        oDataReader.Close()
        con.Close()

        btnGrabar.Visible = False
        historia.ReadOnly = True

    End Sub

    Protected Sub historia_Load(sender As Object, e As EventArgs) Handles historia.Load
        If Not IsPostBack Then


            Dim con1 As New OleDbConnection
            Dim sql1 As String

            con1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")

            con1.Open()
            Dim oDataReader1 As OleDbDataReader

            sql1 = "Select * from verHistFot where dni= ?"
            Dim cmd1 As New OleDbCommand(sql1, con1)
            cmd1.Parameters.Add(New OleDbParameter("dni", OleDbType.VarChar, 10))
            cmd1.Parameters("dni").Value = Session("apellido")
            oDataReader1 = cmd1.ExecuteReader()

            While oDataReader1.Read

                historia.Text = oDataReader1("historiaClinica").ToString()
            End While


            oDataReader1.Close()
            con1.Close()
            btnGrabar.Visible = False
            historia.ReadOnly = True
        End If
    End Sub

End Class
