Dim shellcmd
set shellcmd = CreateObject("wscript.shell")
for i =  1 to 10
set png = shellcmd.exec("ping  " & "10.63.2.149")

strPing = lcase(png.stdout.readall)

wscript.echo(strPing)
next