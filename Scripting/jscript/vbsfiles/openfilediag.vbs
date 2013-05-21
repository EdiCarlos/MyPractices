
Const msoFileDialogOpen = 1

Set objWord = CreateObject("Word.Application")

objWord.ChangeFileOpenDirectory("d:\documents and settings\axkhan2\desktop")

objWord.FileDialog(msoFileDialogOpen).Title = "Select the files to be deleted"
objWord.FileDialog(msoFileDialogOpen).AllowMultiSelect = True

If objWord.FileDialog(msoFileDialogOpen).Show = -1 Then
    objWord.WindowState = 2
    For Each objFile in objWord.FileDialog(msoFileDialogOpen).SelectedItems
        Wscript.Echo objFile
    Next 
    
End If

objWord.Quit