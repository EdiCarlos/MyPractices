' VBScript source code
'get ascii code

Dim myvar(4)
myvar(0) = "a"
myvar(1) = "a"
myvar(2) = "a"

for each name in myvar
wscript.echo Asc(name)
next
