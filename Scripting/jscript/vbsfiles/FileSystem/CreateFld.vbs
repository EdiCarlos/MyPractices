
Set objfso = CreateObject("scripting.FileSystemObject")
Set path = 'd:\temp\myvbfolder'
If not objfso.FolderExists(path) Then
	Set oldfolder = objfso.CreateFolder(path)
	wscript.echo "folder created"
Else
MsgBox "folder already exists"
End If

