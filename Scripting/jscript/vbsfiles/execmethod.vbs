dim objshell, execfnc
set objshell = CreateObject("wscript.shell")
set execfnc = objshell.Exec("calc")

while execfnc.status = 0
WScript.sleep 100

wend
wscript.echo execfnc.status
objshell.AppActivate "execmethod.vbs"
objshell.SendKeys {arif}
objshell.SendKeys {khan}
objshell.SendKeys {hasan}

