Imports System.Drawing.Drawing2D
Partial Class aaaa
    Inherits System.Web.UI.Page


    Public Class Form1

        Dim piezas As List(Of PiezaDental)
        Dim colorSeleccionado As Brush

        Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            piezas = New List(Of PiezaDental) From {
                New PiezaDental(20, 20, 60, 60), New PiezaDental(100, 20, 60, 60),
                New PiezaDental(20, 100, 60, 60), New PiezaDental(100, 100, 100, 100)}

            RadioButton1.Tag = Brushes.Red
            RadioButton2.Tag = Brushes.Blue
            RadioButton3.Tag = Brushes.Green

            Me.DoubleBuffered = True
        End Sub

        Private Sub Form1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
            For Each p As PiezaDental In piezas
                p.Dibuja(e.Graphics)
            Next
        End Sub

        ' Detecta la parte de la pieza dental donde ocurre el mouse down.
        ' Asigna el color a la parte según la herramienta seleccionada (radiobuttons).
        ' Actualiza la vista.
        Private Sub Form1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
            For Each p As PiezaDental In piezas
                Dim ppd As PartesPiezaDental = p.DetectaPartePiezaDental(e.Location)

                If ppd = PartesPiezaDental.Desconocida Then Continue For

                Dim br As Brush = If(e.Button = Windows.Forms.MouseButtons.Left, colorSeleccionado, Brushes.White)
                p.ColoreaParte(br, ppd)
                Invalidate(p.RectPartePiezaDental(ppd))
                Exit For
            Next
        End Sub

        Private Sub HerramientaSeleccionColor(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
            colorSeleccionado = CType(Controls.OfType(Of RadioButton).Where(Function(rb) rb.Checked).First.Tag, Brush)
        End Sub
    End Class

    Enum PartesPiezaDental
        Superior
        Inferior
        Derecha
        Izquierda
        Centro
        Desconocida
    End Enum

    Class PiezaDental
        Private partes(4) As GraphicsPath
        Private colores(4) As Brush

        Public Sub New(x As Integer, y As Integer, cx As Integer, cy As Integer)

            Dim pt1 As Point = New Point(x, y)
            Dim pt2 As Point = New Point(x + cx, y)
            Dim pt3 As Point = New Point(x, y + cy)
            Dim pt4 As Point = New Point(x + cx, y + cy)
            Dim pt5 As Point = New Point(x + cx \ 3, y + cy \ 3)
            Dim pt6 As Point = New Point(x + 2 * cx \ 3, y + cy \ 3)
            Dim pt7 As Point = New Point(x + cx \ 3, y + 2 * cy \ 3)
            Dim pt8 As Point = New Point(x + 2 * cx \ 3, y + 2 * cy \ 3)

            partes(PartesPiezaDental.Superior) = New GraphicsPath()
            partes(PartesPiezaDental.Superior).AddPolygon(New Point() {pt1, pt2, pt6, pt5})
            colores(PartesPiezaDental.Superior) = Brushes.White

            partes(PartesPiezaDental.Izquierda) = New GraphicsPath()
            partes(PartesPiezaDental.Izquierda).AddPolygon(New Point() {pt1, pt3, pt7, pt5})
            colores(PartesPiezaDental.Izquierda) = Brushes.White

            partes(PartesPiezaDental.Inferior) = New GraphicsPath()
            partes(PartesPiezaDental.Inferior).AddPolygon(New Point() {pt3, pt4, pt8, pt7})
            colores(PartesPiezaDental.Inferior) = Brushes.White

            partes(PartesPiezaDental.Derecha) = New GraphicsPath()
            partes(PartesPiezaDental.Derecha).AddPolygon(New Point() {pt4, pt2, pt6, pt8})
            colores(PartesPiezaDental.Derecha) = Brushes.White

            partes(PartesPiezaDental.Centro) = New GraphicsPath()
            partes(PartesPiezaDental.Centro).AddPolygon(New Point() {pt5, pt6, pt8, pt7})
            colores(PartesPiezaDental.Centro) = Brushes.White

        End Sub

        Public Sub Dibuja(g As Graphics)
            For Each p As GraphicsPath In partes
                g.FillPath(colores(Array.IndexOf(partes, p)), p)
                g.DrawPath(Pens.Black, p)
            Next
        End Sub

        Public Function DetectaPartePiezaDental(pt As Point) As PartesPiezaDental
            For Each p As GraphicsPath In partes
                If p.IsVisible(pt) Then
                    Return CType(Array.IndexOf(partes, p), PartesPiezaDental)
                End If
            Next

            Return PartesPiezaDental.Desconocida
        End Function

        Public Sub ColoreaParte(b As Brush, p As PartesPiezaDental)
            colores(p) = b
        End Sub

        Public Function RectPartePiezaDental(p As PartesPiezaDental) As Rectangle
            Return Rectangle.Truncate(partes(p).GetBounds())
        End Function
    End Class
End Class
