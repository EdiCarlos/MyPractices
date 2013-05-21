Public Class ReportEditor
    Private intPageWidth As Single
    Private intPageHeight As Single
    Private intTopMargin As Single
    Private intBottomMargin As Single
    Private intLeftMargin As Single
    Private intRightMargin As Single

    Private lPageFooter As Boolean = True

    Public XMLReport As New Xml.XmlDocument()
    Dim ns As New Xml.XmlNamespaceManager(XMLReport.NameTable)
    Dim strRoot As String = "//ns:Report"
    Dim strReportTag As String = "<Report xmlns=""http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition"" xmlns:rd=""http://schemas.microsoft.com/SQLServer/reporting/reportdesigner"">"


    Public Enum PAPER_TYPE
        _Letter
        _Legal
        _A4
        _8X13
        _8X5
        _8X8
    End Enum

    Public Sub SetPaper(ByVal tipo As PAPER_TYPE)
        Select Case tipo
            Case PAPER_TYPE._Letter
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(27.94)
            Case PAPER_TYPE._A4
                Me.SetPageWidth(21)
                Me.SetPageHeight(29.7)
            Case PAPER_TYPE._8X5
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(13.97)
            Case PAPER_TYPE._8X8
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(20.96)
            Case PAPER_TYPE._Legal
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(35.56)
            Case PAPER_TYPE._8X13
                Me.SetPageWidth(21.59)
                Me.SetPageHeight(33.02)
        End Select
    End Sub
    Sub New(ByVal strRDLCReport As String)
        XMLReport.LoadXml(strRDLCReport)

        ns.AddNamespace("ns", _
        "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")
        ns.AddNamespace("rd", _
        "http://schemas.microsoft.com/SQLServer/reporting/reportdesigner")

        intPageWidth = InchCmToSingle(GetInnerText(strRoot, "ns:PageWidth"))
        intPageHeight = InchCmToSingle(GetInnerText(strRoot, "ns:PageHeight"))
        intTopMargin = InchCmToSingle(GetInnerText(strRoot, "ns:TopMargin"))
        intBottomMargin = InchCmToSingle(GetInnerText(strRoot, "ns:BottomMargin"))
        intLeftMargin = InchCmToSingle(GetInnerText(strRoot, "ns:LeftMargin"))
        intRightMargin = InchCmToSingle(GetInnerText(strRoot, "ns:RightMargin"))
    End Sub

    Sub New()

    End Sub

    ReadOnly Property PageWidthCM() As Single
        Get
            Return intPageWidth
        End Get
    End Property
    ReadOnly Property PageHeightCM() As Single
        Get
            Return intPageHeight
        End Get
    End Property

    ReadOnly Property PageWidthInch() As Single
        Get
            Return intPageWidth / 2.54
        End Get
    End Property
    ReadOnly Property PageHeightInch() As Single
        Get
            Return intPageHeight / 2.54
        End Get
    End Property

    Public Sub SetPageWidth(ByVal value As Single)
        SetInnerText(strRoot, "ns:PageWidth", toCm(value))
        intPageWidth = InchCmToSingle(GetInnerText(strRoot, "ns:PageWidth"))
    End Sub
    ReadOnly Property PageWidth() As String
        Get
            Return toCm(intPageWidth)
        End Get
    End Property

    Public Sub SetPageHeight(ByVal value As Single)
        SetInnerText(strRoot, "ns:PageHeight", toCm(value))
        intPageHeight = InchCmToSingle(GetInnerText(strRoot, "ns:PageHeight"))
    End Sub
    ReadOnly Property PageHeight() As String
        Get
            Return toCm(intPageHeight)
        End Get
    End Property

    Public Sub SetTopMargin(ByVal value As Single)
        SetInnerText(strRoot, "ns:TopMargin", toCm(value))
        intTopMargin = InchCmToSingle(GetInnerText(strRoot, "ns:TopMargin"))
    End Sub
    ReadOnly Property TopMargin() As String
        Get
            Return toCm(intTopMargin)
        End Get
    End Property

    Public Sub SetBottomMargin(ByVal value As Single)
        SetInnerText(strRoot, "ns:BottomMargin", toCm(value))
        intBottomMargin = InchCmToSingle(GetInnerText(strRoot, "ns:BottomMargin"))
    End Sub
    ReadOnly Property BottomMargin() As String
        Get
            Return toCm(intBottomMargin)
        End Get
    End Property

    Public Sub SetLeftMargin(ByVal value As Single)
        SetInnerText(strRoot, "ns:LeftMargin", toCm(value))
        intLeftMargin = InchCmToSingle(GetInnerText(strRoot, "ns:LeftMargin"))
    End Sub
    ReadOnly Property LeftMargin() As String
        Get
            Return toCm(intLeftMargin)
        End Get
    End Property

    Public Sub SetRightMargin(ByVal value As Single)
        SetInnerText(strRoot, "ns:RightMargin", toCm(value))
        intRightMargin = InchCmToSingle(GetInnerText(strRoot, "ns:RightMargin"))
    End Sub
    ReadOnly Property RightMargin() As String
        Get
            Return toCm(intRightMargin)
        End Get
    End Property
#Region "Converters"
    Private Function toCm(ByVal intValue As Single) As String
        Return Format(intValue, "#.##").Replace(",", ".") & "cm"
    End Function

    Private Function InchCmToSingle(ByVal strValue As String) As Single
        Try
            If strValue.ToUpper.IndexOf("CM") > -1 Then
                Return Val(strValue.ToUpper.Replace("CM", ""))
            End If
            If strValue.ToUpper.IndexOf("IN") > -1 Then
                Return Val(strValue.ToUpper.Replace("IN", "")) * 2.54
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region
#Region "XML"
    'get an application setting by key value
    Private Function GetInnerText(ByVal section As String, ByVal key As String, Optional ByVal defaultvalue As String = "") As String
        Dim Node As Xml.XmlNode = XMLReport.DocumentElement.SelectSingleNode( _
                                   section & "/" & key, ns)
        'return the value or nothing if it doesn't exist
        If Not Node Is Nothing Then
            Return Node.InnerText
        Else
            Return defaultvalue
        End If
    End Function

    Private Sub SetInnerText(ByVal section As String, ByVal key As String, ByVal value As String)
        'get the value
        Dim Node As Xml.XmlElement = XMLReport.DocumentElement.SelectSingleNode( _
                                           section & "/" & _
                                          key, ns)
        If Not Node Is Nothing Then
            'key found, set the value
            Node.InnerXml = value
        Else
            'key not found, create it
            Node = XMLReport.CreateElement(key, "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")

            'Node = xd.CreateElement(key)
            Node.InnerXml = value


            'look for the appsettings node
            Dim Root As Xml.XmlNode = XMLReport.DocumentElement.SelectSingleNode(section, ns)

            'add the new child node (this key)
            If Not Root Is Nothing Then
                Root.AppendChild(Node)
            End If
        End If
    End Sub

    'delete an application setting, takes a key and a value
    Private Sub DeleteInnerText(ByVal section As String, ByVal key As String)

        'get the value
        Dim Node As Xml.XmlElement = CType(XMLReport.DocumentElement.SelectSingleNode( _
                                            section & "/" & _
                                           key, ns), Xml.XmlElement)
        If Not Node Is Nothing Then
            'key found, delete the value
            'look for the appsettings node
            Dim Root As Xml.XmlNode = XMLReport.DocumentElement.SelectSingleNode(section, ns)
            If Not Root Is Nothing Then
                Root.RemoveChild(Node)
            End If
        Else
            'key not found, ignore            
        End If
    End Sub

#End Region

End Class