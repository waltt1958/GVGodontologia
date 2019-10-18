Imports System.Drawing

Partial Class ab
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim image As New System.Drawing.Bitmap(33, 24)
        Dim g As System.Drawing.Graphics
        g = System.Drawing.Graphics.FromImage(image)
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.Clear(Drawing.Color.White)

        Dim pen As New Pen(Color.Black, 1)

        ' Dim pts() As Point = {New Point(1, 1), New Point(1, 51), New Point(10, 33), New Point(10, 17)}
        'g.DrawPolygon(pen, pts)
        Dim x As Integer
        Dim y As Integer
        Dim cx As Integer
        Dim cy As Integer
        x = 1
        y = 1
        cx = 30
        cy = 20
        Dim pt1 As Point = New Point(x, y)
        Dim pt2 As Point = New Point(x + cx, y)
        Dim pt3 As Point = New Point(x, y + cy)
        Dim pt4 As Point = New Point(x + cx, y + cy)
        Dim pt5 As Point = New Point(x + cx / 3, y + cy / 3)
        Dim pt6 As Point = New Point(x + 2 * cx / 3, y + cy / 3)
        Dim pt7 As Point = New Point(x + cx / 3, y + 2 * cy / 3)
        Dim pt8 As Point = New Point(x + 2 * cx / 3, y + 2 * cy / 3)

            'lateral inferior
            g.DrawPolygon(pen, New Point() {pt3, pt7, pt8, pt4})
            'lateral superior
            g.DrawPolygon(pen, New Point() {pt1, pt2, pt6, pt5})
            'lateral izquierdo
            g.DrawPolygon(pen, New Point() {pt1, pt3, pt7, pt5})
            'lateral derecho
            g.DrawPolygon(pen, New Point() {pt2, pt4, pt8, pt6})

            Page.Response.ContentType = "image/png"
            image.Save(Page.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Png)

    End Sub

End Class
