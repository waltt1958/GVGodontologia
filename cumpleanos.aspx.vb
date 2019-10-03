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

        Dim saludo, despedida, firma, especialidad, direccion As String

        Dim mensaje As New System.Net.Mail.MailMessage()
        Dim smtp As New System.Net.Mail.SmtpClient("127.0.0.1")


        'configuracion smtp

        smtp.Credentials = New System.Net.NetworkCredential("ovidiov1958@gmail.com", "corazones1958")

        smtp.Host = "smtp.gmail.com"
        smtp.Port = 587 '25 465
        smtp.EnableSsl = True

        'configuracion del mensaje

        saludo = "GVG Odongologia le desea que pase un muy feliz cumpleaños."
        ' despedida = "Afectuoso saludo de"
        'firma = " Dra. Guadalupe Vicente Galan"
        'especialidad = " Odontóloga Especialista en Estética Dental"
        'direccion = "España 505 - 1er Piso - Rosario // Telefono: 4251589"

        'correo al que le envío el mail
        Dim mailPara As String
        mailPara = GridView1.Rows(GridView1.SelectedIndex).Cells(7).Text.ToString
        mensaje.To.Add(mailPara)

        'quien envía el correo
        mensaje.From = New System.Net.Mail.MailAddress("ovidiov1958@gmail.com", "Dra. Guadalupe Vicente Galan", System.Text.Encoding.UTF8)

        'a donde se responden los mails
        mensaje.ReplyToList.Add("ovidiov1958@gmail.com")

        'asunto del mail
        mensaje.Subject = "SALUTACION POR SU CUMPLEAÑOS"

        'codificacion
        mensaje.SubjectEncoding = System.Text.Encoding.UTF8

        'contenido del mail
        mensaje.Body = saludo.ToString
        'mensaje.Body = despedida.ToString
        'mensaje.Body = firma.ToString
        'mensaje.Body = especialidad.ToString
        'mensaje.Body = direccion.ToString

        mensaje.BodyEncoding = System.Text.Encoding.UTF8
        mensaje.Priority = System.Net.Mail.MailPriority.Normal
        mensaje.IsBodyHtml = True

        smtp.Send(mensaje)


    End Sub

End Class
