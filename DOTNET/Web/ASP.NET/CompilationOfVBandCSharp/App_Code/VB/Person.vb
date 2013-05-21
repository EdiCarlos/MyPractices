Imports Microsoft.VisualBasic

Public Class Person
    Private firstName As String = String.Empty
    Private lastName As String = String.Empty

    Public Sub New(ByVal firstname As String, ByVal lastName As String)
        Me.firstName = firstname
        Me.lastName = lastName

    End Sub
    Public Property FirstNameP() As String
        Get
            Return Me.firstName
        End Get
        Set(ByVal value As String)
            Me.firstName = value
        End Set
    End Property

    Public Property LastNameP() As String
        Get
            Return Me.lastName

        End Get
        Set(ByVal value As String)
            Me.lastName = value
        End Set
    End Property
End Class
