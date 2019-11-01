Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class piezaDental

    Enum PartesPiezaDental
        superior
        inferior
        derecha
        izquierda
        centro
        desconocida
    End Enum

    Private partes(4) As GraphicsPath
    Private colores(4) As Brush

    Public Sub New(x As Integer, y As Integer, cx As Integer, cy As Integer)

        Dim pt1 As Point = New Point(x, y)
        Dim pt2 As Point = New Point(x + cx, y)
        Dim pt3 As Point = New Point(x, y + cy)
        Dim pt4 As Point = New Point(x + cx, y + cy)
        Dim pt5 As Point = New Point(x + cx / 3, y + cy / 3)
        Dim pt6 As Point = New Point(x + 2 * cx / 3, y + cy / 3)
        Dim pt7 As Point = New Point(x + cx / 3, y + 2 * cy / 3)
        Dim pt8 As Point = New Point(x + 2 * cx / 3, y + 2 * cy / 3)

        partes(PartesPiezaDental.superior) = New GraphicsPath()
        partes(PartesPiezaDental.superior).AddPolygon(New Point() {pt1, pt2, pt6, pt5})
        colores(PartesPiezaDental.superior) = Brushes.White

        partes(PartesPiezaDental.izquierda) = New GraphicsPath()
        partes(PartesPiezaDental.izquierda).AddPolygon(New Point() {pt1, pt3, pt7, pt5})
        colores(PartesPiezaDental.izquierda) = Brushes.White

        partes(PartesPiezaDental.inferior) = New GraphicsPath()
        partes(PartesPiezaDental.inferior).AddPolygon(New Point() {pt3, pt7, pt8, pt4})
        colores(PartesPiezaDental.inferior) = Brushes.White

        partes(PartesPiezaDental.derecha) = New GraphicsPath()
        partes(PartesPiezaDental.derecha).AddPolygon(New Point() {pt2, pt4, pt8, pt6})
        colores(PartesPiezaDental.derecha) = Brushes.White

        partes(PartesPiezaDental.centro) = New GraphicsPath()
        partes(PartesPiezaDental.centro).AddPolygon(New Point() {pt7, pt5, pt6, pt8})
        colores(PartesPiezaDental.centro) = Brushes.White


    End Sub

    Public Sub dibuja(g As Graphics)
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

        Return PartesPiezaDental.desconocida

    End Function

    Public Sub ColoreaParte(b As Brush, p As PartesPiezaDental)
        colores(p) = b
    End Sub

    Public Function RectPartePiezaDental(p As PartesPiezaDental) As Rectangle
        Return Rectangle.Truncate(partes(p).GetBounds())
    End Function

End Class
