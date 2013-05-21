' VBScript source code


Set objShell = WScript.CreateObject("WScript.Shell")
objShell.Run "winword"
wscript.sleep 5000
for i = 1 to 50
objShell.SendKeys CStr(i)
wscript.sleep 100
next
wscript.sleep 1000
objShell.Sendkeys "%f"
wscript.sleep 500
objShell.Sendkeys "A"
wscript.sleep 500
objShell.Sendkeys "%S"
wscript.sleep 500

