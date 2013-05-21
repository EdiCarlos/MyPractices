' VBScript source code

function showfolder(foldername)
dim fso, fs, f, fc
set fso = CreateObject("Scripting.FileSystemObject")
set fs = fso.GetFolder(foldername)
set f = fs.Files
for each file in f
wscript.echo file.Name
next
end function

function getfolders(drive)
dim fso, fl, fn
set fso = CreateObject("Scripting.FileSystemObject")
set fl = fso.GetFolder(drive)
set fn = fl.FolderName
for each folders in fn
wscript.echo folders.Name
next
end function

showfolder("d:\temp\csc")
