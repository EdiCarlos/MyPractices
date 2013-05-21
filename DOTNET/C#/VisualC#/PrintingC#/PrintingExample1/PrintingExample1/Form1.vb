Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing


Public Class Form1
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top
        
        Dim brush As Brush = New SolidBrush(Color.Red)

        'e.Graphics.DrawLine(Pens.Red, 1, 1, 2000, 2000)
        'e.Graphics.DrawRectangle(Pens.Red, New Rectangle(100, 100, 100, 100))

        Dim fnt As Font = New Font("Arial", 10, FontStyle.Bold)
        'For i As Integer = 20 To 820 Step 20
        '    e.Graphics.DrawString("x 0 y " & i.ToString(), fnt, Brushes.Red, New PointF(0, i))
        '    ' e.Graphics.DrawString("x " & i.ToString() & " y 0", fnt, Brushes.Red, New PointF(i + 10, 20))

        'Next i
        e.Graphics.DrawString("Resume", fnt, Brushes.Blue, New PointF(420, 10))

        e.Graphics.DrawString("Address: Sadabahar, Gilbert Hill Rd,", fnt, Brushes.Blue, New PointF(840, 20))
        e.Graphics.DrawString(Space(17) & "Farooqia Masjid,", fnt, Brushes.Blue, New PointF(840, 40))
        e.Graphics.DrawString(Space(17) & "Anderi(west),", fnt, Brushes.Blue, New PointF(840, 60))
        e.Graphics.DrawString(Space(17) & "Mumbai 40058", fnt, Brushes.Blue, New PointF(840, 80))
        e.Graphics.DrawString("Mobile NO: 9768836054", fnt, Brushes.Blue, New PointF(840, 100))
        e.Graphics.DrawString("Tel NO: 022-32014285", fnt, Brushes.Blue, New PointF(840, 120))

        'e.Graphics.DrawString("x 600 y 600", fnt, Brushes.Red, New PointF(600, 600))

        'e.Graphics.DrawString("x 500 y 500", fnt, Brushes.Red, New PointF(500, 500))
        'e.Graphics.DrawString("x 400 y 400", fnt, Brushes.Red, New PointF(400, 400))
        'e.Graphics.DrawString("x 300, y 300", fnt, Brushes.Red, New PointF(300, 300))
        'e.Graphics.DrawString("x 200 y 200", fnt, Brushes.Red, New PointF(200, 200))
        'e.Graphics.DrawString("x 100 y 100", fnt, Brushes.Red, New PointF(100, 100))
        'e.Graphics.DrawString("x 0 y 100", fnt, Brushes.Red, New PointF(0, 100))
        'e.Graphics.DrawString("x 0 y 200", fnt, Brushes.Red, New PointF(0, 200))

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PrintDocument1.DefaultPageSettings.Landscape = True

        Dim printerSetting As PrinterSettings = New PrinterSettings()
        printerSetting.DefaultPageSettings.Landscape = True
        printerSetting.DefaultPageSettings.Margins = New Margins(300, 300, 300, 300)

        Dim pagesetting As PageSettings = New PageSettings(printerSetting)
        pagesetting.Margins = New Margins(100, 100, 200, 200)
        PrintDocument1.PrinterSettings = printerSetting
        PrintPreviewControl1.Document = PrintDocument1

    End Sub
End Class
