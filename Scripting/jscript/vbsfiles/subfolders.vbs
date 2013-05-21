' VBScript source code

'option explicit

dim objfso
dim  curfolder
set objfso = CreateObject("Scripting.FileSystemObject")
set curfolder = objfso.GetFolder("d:\temp\")

for each subfolder in curfolder.SubFolders
wscript.echo subfolder.Name, subfolder.Size
next
