Imports System.Net.Mail
Imports System.Net
Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbDataReader
Imports Microsoft.VisualBasic
Imports System.Web.Services.Description
Imports System.IO
Imports System.Text

Partial Class cumpleanosDefault
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Session("mesActual") = Month(Now).ToString

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

        Dim saludo, texto, despedida, firma, especialidad, direccion As String

        Dim mensaje As New System.Net.Mail.MailMessage()
        Dim smtp As New System.Net.Mail.SmtpClient("127.0.0.1")

        'configuracion smtp

        smtp.Credentials = New System.Net.NetworkCredential("ovidiov1958@gmail.com", "corazones1958")
        smtp.Host = "smtp.gmail.com"
        smtp.Port = 587 '25 465
        smtp.EnableSsl = True

        'configuracion del mensaje

        saludo = "GVG Odongologia le desea que pase un muy feliz cumpleaños en compañía de sus afectos" & vbLf & vbLf
        texto = "Dado que la salud bucal es nuestra prioridad, lo invitamos a comunicarse al teléfono 4251589" _
        & "para obtener un turno a fin de que le realicemos un control de su salud bucal sin cargo. Lo esperamos" & vbLf & vbLf & vbLf & vbLf
        despedida = "Afectuoso saludo de" & vbLf & vbLf
        firma = " Dra. Guadalupe Vicente Galan"
        especialidad = " Odontóloga Especialista en Estética Dental" _
            & "Universidad de Rosario y Universidad de Buenos Aires"
        direccion = "España 505 - 1er Piso - Rosario" & vbLf & "Telefono: 4251589"

        'correo al que le envío el mail
        Dim mailPara As String
        mailPara = GridView1.Rows(GridView1.SelectedIndex).Cells(7).Text.ToString
        mensaje.To.Add(mailPara)

        'quien envía el correo
        mensaje.From = New System.Net.Mail.MailAddress("ovidiov1958@gmail.com", "Dra. Guadalupe Vicente Galan", System.Text.Encoding.UTF8)
        Dim nombre As String
        'a donde se responden los mails
        mensaje.ReplyToList.Add("ovidiov1958@gmail.com")
        nombre = GridView1.Rows(GridView1.SelectedIndex).Cells(0).Text.ToString

        'asunto del mail

        Dim asunto As String
        asunto = "SALUTACION POR SU CUMPLEAÑOS Sr/a  " & nombre
        mensaje.Subject = asunto ' "SALUTACION POR SU CUMPLEAÑOS"

        'codificacion
        mensaje.SubjectEncoding = System.Text.Encoding.UTF8

        'TODO ESTO ES PARA DARLE FORMA AL MENSAJE 
        'aca forma para texto plano


        Dim plano As String = "GVG Odongologia le desea que pase un muy feliz cumpleaños en compañía de sus afectos" & vbCrLf & vbCrLf _
         & "Dado que la salud bucal es nuestra prioridad, lo invitamos a comunicarse al teléfono 4251589" & vbCrLf _
         & "para obtener un turno a fin de que le realicemos un control de su salud bucal sin cargo. " & vbCrLf & vbCrLf _
         & "Afectuoso saludo de" & vbCrLf _
         & "Dra. Guadalupe Vicente Galan" & vbCrLf _
         & "Odontóloga Especialista en Estética Dental" & vbCrLf _
         & "Universidad de Rosario y Universidad de Buenos Aires" & vbCrLf _
         & "España 505 - 1er Piso - Rosario - Telefono 4251589"

        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(plano, Nothing, System.Net.Mime.MediaTypeNames.Text.Plain)

        'texto html
        Dim html As String = "<h2><B>GVGodontología le desea que pase un muy feliz cumpleaños en compañia de sus afectos</b></h2>" & vbCrLf _
         & "Dado que la salud bucal es nuestra prioridad, lo invitamos a comunicarse al teléfono 4251589<br>" _
         & "para obtener un turno a fin de que le realicemos un control de su salud bucal sin cargo.<br><br> " _
         & "Afectuoso saludo de<br>" _
         & "<b>Dra. Guadalupe Vicente Galan<br>" _
         & "<b>Odontóloga Especialista en Estética Dental - Mat. Nacional xxxxxx<br>" _
         & "<b>Universidad de Rosario y Universidad de Buenos Aires<br>" _
         & "<b>España 505 - 1er Piso - Rosario - Telefono 4251589img"

        Dim htmlview = AlternateView.CreateAlternateViewFromString(html, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)

        mensaje.AlternateViews.Add(plainView)
        mensaje.AlternateViews.Add(htmlview)
        'fin de darle forma al mensaje

        Try

            smtp.Send(mensaje)

            Dim message As String = "Correo electrónico enviado"
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())

        Catch ex As Exception

            Dim message As String = "No se pudo enviar el Correo electrónico"
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())

        End Try

    End Sub

End Class
