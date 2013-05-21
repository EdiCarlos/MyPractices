Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms
Imports System.Collections.ObjectModel

Public Class Form1
    Dim objReportEditor As New ReportEditor
    Dim ReportContent As ReportViewer
    Dim strReportName As String = "ReportEditor.Report1.rdlc"
    Public nPaperType As ReportEditor.PAPER_TYPE = ReportEditor.PAPER_TYPE._Letter
    Dim objDataSource As New Microsoft.Reporting.WinForms.ReportDataSource
    Private nPageWidth As Single = 21.59
    Private nPageHeight As Single = 27.94
    Private m_streams As IList(Of Stream)
    Private m_currentPageIndex As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PaperComboBox.SelectedIndex = 0
        ShowReport()
    End Sub


    Sub ShowReport()
        'Show the report
        Application.DoEvents()
        If Not ReportContent Is Nothing Then
            Me.Controls.Remove(ReportContent)
            ReportContent.Dispose()
        End If
        Dim objReportViewer As New Microsoft.Reporting.WinForms.ReportViewer

        objReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        objReportViewer.Location = New System.Drawing.Point(12, 12)
        objReportViewer.Size = New System.Drawing.Size(Me.Size.Width - 281, Me.Size.Height - 58)
        objReportViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        objReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        objReportViewer.Name = "ReportContent"
        objReportViewer.TabIndex = 16

        ReportContent = objReportViewer
        Me.Controls.Add(objReportViewer)

        'Edit the report using the report editor class
        'The report editor class works with a string
        'so we have to convert the report that is stored as stream to string
        'I made the function ResStreamToString(strNameOfTheResource) to do it
        'this function returns a string with the xml code of the report
        'and we send that string to the reporteditorclass

        Dim objReportEditor As New ReportEditor(ResStreamToString(strReportName))

        With objReportEditor
            'Change the paper
            .SetPaper(nPaperType)
            'set the margins
            .SetTopMargin(Me.TopMarginNumericUpDown.Value)
            .SetBottomMargin(Me.BottomMarginNumericUpDown.Value)
            .SetRightMargin(Me.RightMarginNumericUpDown.Value)
            .SetLeftMargin(Me.LeftMarginNumericUpDown.Value)
            'keep the pagewith and pageheight in centimeters to be able to print later
            'if you are going to print with the reportviewer bprint button then you dont need this
            nPageWidth = .PageWidthCM
            nPageHeight = .PageHeightCM
        End With

        'Load the report definition in the reportviewer
        'We have to convert the xml code back to stream to be loaded into the reportviewer
        'i made another little function StringToStream(strReportXML)
        'this function converts a string into a stream
        'so we can load the report definition
        ReportContent.LocalReport.LoadReportDefinition(StringToStream(objReportEditor.XMLReport.InnerXml))


        ReportContent.LocalReport.EnableExternalImages = True

        'DataSource
        'Probably you know what this is
        'loading the data for the report
        Dim objTableAdapter As New dataDataSetTableAdapters.countriesTableAdapter
        objDataSource.Name = "dataDataSet_countries"
        objDataSource.Value = objTableAdapter.GetData
        ReportContent.LocalReport.DataSources.Add(objDataSource)


        objReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Application.DoEvents()
        objReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        ReportContent.Visible = True
    End Sub

    'Returns a string from a resource that is stored as stream 
    Function ResStreamToString(ByVal strResourceName As String) As String
        Dim objStream As IO.Stream = System.Reflection.Assembly.GetEntryAssembly.GetManifestResourceStream(strResourceName)
        Dim objStreamReader As IO.StreamReader
        objStreamReader = New IO.StreamReader(objStream)
        ResStreamToString = objStreamReader.ReadToEnd
        objStreamReader.Close()
        objStreamReader = Nothing
        objStream = Nothing
    End Function
    'converts a string into a stream
    Function StringToStream(ByVal strResourceName As String) As IO.Stream
        Dim objStream As IO.Stream = New IO.MemoryStream(strResourceName.Length)
        Dim objStreamWriter As IO.StreamWriter = New IO.StreamWriter(objStream)

        objStreamWriter.Write(strResourceName)
        objStreamWriter.Flush()
        objStream.Position = 0
        Return objStream
    End Function


    Private Sub RefreshReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshReportButton.Click
        Select Case Me.PaperComboBox.SelectedIndex
            Case 0
                nPaperType = ReportEditor.PAPER_TYPE._Letter
            Case 1
                nPaperType = ReportEditor.PAPER_TYPE._Legal
            Case 2
                nPaperType = ReportEditor.PAPER_TYPE._A4
            Case 3
                nPaperType = ReportEditor.PAPER_TYPE._8X13
            Case 4
                nPaperType = ReportEditor.PAPER_TYPE._8X5
            Case 5
                nPaperType = ReportEditor.PAPER_TYPE._8X8
        End Select
        ShowReport()
    End Sub

    Private Sub PrintReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportButton.Click
        print()
    End Sub


    Sub print()
        SetPrintParameters()
        If Not PDPrintDocument.PrinterSettings.IsValid Then
            MsgBox("Can't find printer")
            Return
        End If
        Export()
        PDPrintDocument.Print()
        RemoveStreams()
    End Sub
    '
    Sub SetPrintParameters()
        'Set the parameters we need to be able to print
        Dim objPrinterSettings As New Printing.PageSettings
        PDPrintDocument.PrinterSettings.PrinterName = objPrinterSettings.PrinterSettings.PrinterName

        Dim objPaperKind As System.Drawing.Printing.PaperKind
        Select Case nPaperType
            Case ReportEditor.PAPER_TYPE._Letter
                objPaperKind = PaperKind.Letter
            Case ReportEditor.PAPER_TYPE._Legal
                objPaperKind = PaperKind.Legal
            Case ReportEditor.PAPER_TYPE._A4
                objPaperKind = PaperKind.A4
            Case ReportEditor.PAPER_TYPE._8X13
                objPaperKind = PaperKind.Folio
            Case Else
                'If the paper is custom then we have
                'to set it this way
                Dim objPaperSize As New System.Drawing.Printing.PaperSize
                objPaperSize.Height = (nPageHeight / 2.54) * 100
                objPaperSize.Width = (nPageWidth / 2.54) * 100
                objPaperSize.PaperName = "Custom"
                PDPrintDocument.DefaultPageSettings.PaperSize = objPaperSize
        End Select

        'With this 4 lines i solved the problem that when you print on different papers
        'always when you check the paper type in the print job you see the default paper
        For Each objPaperSize1 As PaperSize In PDPrintDocument.PrinterSettings.PaperSizes
            If objPaperSize1.Kind = objPaperKind Then
                PDPrintDocument.DefaultPageSettings.PaperSize = objPaperSize1
            End If
        Next

        'you will see this in the queue for the printer
        PDPrintDocument.DocumentName = My.Application.Info.ProductName & " - Countries list"
    End Sub


    'This function exports the report to EMF, create the streams and create files with
    'every page of the report
    'you need the Replace(",", ".") only if the decimal symbol is , for example.. in Venezuela.. my country ;)
    Public Sub Export()
        Dim deviceInfo As String = _
          "<DeviceInfo>" + _
          "  <OutputFormat>EMF</OutputFormat>" + _
          "  <PageWidth>" & Str(nPageWidth).Trim & "cm</PageWidth>" + _
          "  <PageHeight>" & Str(nPageHeight).Trim & "cm</PageHeight>" + _
          "  <MarginTop>" & Me.TopMarginNumericUpDown.Value.ToString.Trim.Replace(",", ".") & "cm</MarginTop>" + _
          "  <MarginLeft>" & Me.LeftMarginNumericUpDown.Value.ToString.Trim.Replace(",", ".") & "cm</MarginLeft>" + _
          "  <MarginRight>" & Me.RightMarginNumericUpDown.Value.ToString.Trim.Replace(",", ".") & "cm</MarginRight>" + _
          "  <MarginBottom>" & Me.BottomMarginNumericUpDown.Value.ToString.Trim.Replace(",", ".") & "cm</MarginBottom>" + _
          "</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        ReportContent.LocalReport.Render("Image", deviceInfo, _
              AddressOf CreateStream, warnings)
        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next
    End Sub

    Private Function CreateStream(ByVal name As String, _
    ByVal fileNameExtension As String, _
    ByVal encoding As Encoding, ByVal mimeType As String, _
    ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New FileStream(My.Application.Info.DirectoryPath & "\" & name + "." _
         + fileNameExtension, FileMode.Create)
        m_streams.Add(stream)
        Return stream
    End Function
    Public Sub RemoveStreams()
        'LIMPIAR EL ARRAY DE STREAMS
        If Not (m_streams Is Nothing) Then
            Dim stream As Stream
            For Each stream In m_streams
                stream.Close()
                stream = Nothing
            Next
            'm_streams = Nothing
        End If
        m_currentPageIndex = 0
        'BORRAR ARCHIVOS TEMPORALES
        Dim files As ReadOnlyCollection(Of String)
        Dim fileExists As Boolean
        files = My.Computer.FileSystem.GetFiles(My.Application.Info.DirectoryPath, FileIO.SearchOption.SearchTopLevelOnly, "*.emf")
        For Each file As String In files
            fileExists = My.Computer.FileSystem.FileExists(file)
            If fileExists Then
                System.IO.File.Delete(file)
            End If
        Next
    End Sub


    Private Sub PDPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDPrintDocument.PrintPage
        Try
            Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
            e.Graphics.DrawImage(pageImage, e.PageBounds)
            m_currentPageIndex += 1
            e.HasMorePages = (m_currentPageIndex < m_streams.Count)
        Catch ex As Exception
            MsgBox(m_currentPageIndex & " - PDPrintDocument_PrintPage -" & ex.Message)
        End Try

    End Sub
End Class
