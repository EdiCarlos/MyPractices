Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text

Module Module1


Sub Main()
Dim query$ = "select * from d:\temp\prac.dbf"
Dim con As OleDbConnection = new OleDbConnection("Provider=VFPOLEDB.1;Data Source=D:\\")
Try
con.Open()
Dim cmd as OleDbCommand = new OleDbCommand(query, con)
Dim read as OleDbDataReader = cmd.ExecuteReader()
While read.Read()
msgbox(read(2).ToString())
End While
Catch  ex as OleDbException
msgbox(ex.Message)
Finally
con.Close()
End Try
End Sub
End Module