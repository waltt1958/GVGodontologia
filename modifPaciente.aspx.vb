
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Imports System.InvalidCastException

Partial Class modifPaciente
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init


        Dim dt As DateTime

        aYnombre.Focus()
        aYnombre.Text = Session("aYnombre").ToString
        direccion.Text = Session("direccion").ToString
        CP.Text = Session("cp").ToString
        localidad.Text = Session("localidad").ToString
        telediscado.Text = Session("telediscado").ToString
        celular.Text = Session("celular").ToString
        fijo.Text = Session("fijo").ToString
        sexo.Text = Session("sexo").ToString
        'FecNac.Text = Session("fechaNacimiento")

        dt = Session("fechaNacimiento")
        FecNac.Text = dt.ToString("yyyy-MM-dd")

        dni.Text = Session("dni").ToString
        mail.Text = Session("mail").ToString
        categoria.Text = Session("categoria").ToString
        obra.Text = Session("obraSocial").ToString
        histClinica.Text = Session("historiaClinica").ToString

    End Sub


    Protected Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click

        aYnombre.Text = ""
        direccion.Text = ""
        CP.Text = ""
        localidad.Text = ""
        telediscado.Text = ""
        celular.Text = ""
        fijo.Text = ""
        sexo.Text = ""
        FecNac.Text = ""
        dni.Text = ""
        mail.Text = ""
        categoria.Text = ""
        obra.Text = ""
        histClinica.Text = ""
        Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")

    End Sub

    Protected Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click

        Dim con As New OleDbConnection
        Dim sql As String
        Dim actualizar As String

        sql = "Select * from pacientes where dni= ?"

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("/bbdd/gvg.accdb")

        con.Open()
        Dim oDataReader As OleDbDataReader

        Dim cmd As New OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDbParameter("dni", OleDbType.VarChar, 10))
        cmd.Parameters("dni").Value = dni.Text
        oDataReader = cmd.ExecuteReader()

        If oDataReader.Read() = True Then

            actualizar = "UPDATE pacientes SET aYnombre= '" & aYnombre.Text & "', direccion= '" & direccion.Text & "', cp= '" & CP.Text & "', localidad= '" & localidad.Text & "'," _
            & "telediscado='" & telediscado.Text & "', celular = '" & celular.Text & "',fijo= '" & fijo.Text & "',sexo= '" & sexo.Text & "',fechaNacimiento='" & FecNac.Text & "',mail= '" & mail.Text & "',categoria= '" & categoria.Text & "'," _
            & "obraSocial= '" & obra.Text & "', historiaClinica= '" & histClinica.Text & "' where dni = '" & dni.Text.ToString & "'"
            Dim cmd1 As New OleDbCommand(actualizar, con)
            cmd1.ExecuteNonQuery()
            con.Close()


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
            histClinica.Text = ""

            Session("altaExit") = "si"
            Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")

        Else

            Session("baja") = "no"
            Response.Write("<script>window.setTimeout(location.href='pacientes.aspx', 2000);</script>")

        End If

        oDataReader.Close()
        con.Close()

    End Sub
End Class
