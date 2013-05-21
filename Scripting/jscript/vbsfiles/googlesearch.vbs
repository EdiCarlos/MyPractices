dim objshell, ie

set objshell = CreateObject("WScript.Shell")
set ie = CreateObject("InternetExplorer.Application")
ie.Visible = true
ie.navigate("http://www.google.com")

wscript.sleep 5000
'objshell.AppActivate "Google"
wscript.sleep 2000
objshell.SendKeys "msdn"        

wscript.sleep 1000

objshell.SendKeys "~"
'ie.FullScreen = True
for i = 1 to 20
objshell.SendKeys "{tab}"
wscript.sleep 500
next

objshell.SendKeys "~"
wscript.sleep 4000
ie.Visible = false
objshell.exec("wscript D:\temp\jscript\vbsfiles\shellobject\logintogoogle.vbs")

