Public Class Form1
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'PrintPreviewControl1.Document.DocumentName = "D:\\documents and settings\\axkhan2\\Desktop\\Our_Project.xls"

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class
