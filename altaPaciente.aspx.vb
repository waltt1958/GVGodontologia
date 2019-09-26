Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Imports System.IO

Partial Class altaPaciente
    Inherits System.Web.UI.Page
    Protected Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        dni.Text = String.Empty
        aYnombre.Text = String.Empty
        direccion.Text = String.Empty
        CP.Text = String.Empty
        localidad.Text = String.Empty
        telediscado.Text = String.Empty
        celular.Text = String.Empty
        fijo.Text = String.Empty
        'sexo.Text = String.Empty
        FecNac.Text = String.Empty
        mail.Text = String.Empty
        obra.Text = String.Empty
        categoria.Text = String.Empty
        Session("altaExit") = "no"
        dni.Focus()
        Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")

    End Sub

    Protected Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click

        Dim con As New OleDbConnection
        Dim sql As String
        Dim insertar As String

        sql = "Select * from pacientes where dni= ?"

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")

        con.Open()
        Dim oDataReader As OleDbDataReader

        Dim cmd As New OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDbParameter("dni", OleDbType.VarChar, 10))
        cmd.Parameters("dni").Value = dni.Text
        oDataReader = cmd.ExecuteReader()

        If oDataReader.Read() = True Then
            Session("alta") = "existeLeg"
            Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")

        Else

            Select Case sexo.SelectedValue
                Case "Femenino"
                    sexo.Text = "Femenino"
                Case "Masculino"
                    sexo.Text = "Masculino"
                Case "Otro"
                    sexo.Text = "Otro"
            End Select
            insertar = "INSERT INTO pacientes VALUES ('" & aYnombre.Text & "','" & direccion.Text & "','" & CP.Text & "','" & localidad.Text & "','" & telediscado.Text & "','" & celular.Text & "','" & fijo.Text & "','" & sexo.Text & "','" & FecNac.Text & "','" & dni.Text & "','" & mail.Text & "','" & categoria.Text & "','" & obra.Text & "','" & histClinica.Text & "')"
            Dim cmd1 As New OleDbCommand(insertar, con)
            cmd1.ExecuteNonQuery()

            dni.Text = String.Empty
            aYnombre.Text = String.Empty
            direccion.Text = String.Empty
            CP.Text = String.Empty
            localidad.Text = String.Empty
            telediscado.Text = String.Empty
            celular.Text = String.Empty
            fijo.Text = String.Empty
            FecNac.Text = String.Empty
            mail.Text = String.Empty
            obra.Text = String.Empty
            categoria.Text = String.Empty
            dni.Focus()

            Session("altaExit") = "si"
            Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")

        End If

        oDataReader.Close()
        con.Close()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        aYnombre.Focus()
        dni.Text = Session("guardaDNI")
        Session("altaExit") = "no"

    End Sub
End Class
