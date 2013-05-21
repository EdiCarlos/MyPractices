
dim inter, objshell

set objshell = CreateObject("wscript.Shell")

set inter = CreateObject("InternetExplorer.Application")
inter.Visible = true
inter.navigate("http://www.gmail.com")
do
wscript.Sleep 1000
loop until not inter.Busy 


objshell.AppActivate "Gmail: Email from google"

do
wscript.Sleep 1000
loop until not inter.Busy 
'objshell.SendKeys "arif788"
dim doc, username, userpass, usernamefield, userpassfield
set doc = inter.document.all
doc.Item("Email").Value = "arif788"
wscript.sleep 1000
dim strp(8)
strp(0) = 115
strp(1) = 104
strp(2) = 121
strp(3) = 109
strp(4) = 97
strp(5) = 55
strp(6) = 56
strp(7) = 56
dim pStr

for each v in strp
pStr =  pStr + chr(v) 
next

doc.Item("Passwd").Value = pStr
wscript.sleep 1000
dim subm
set subm = doc.Item("signIn")
subm.click()


do 
wscript.sleep 500
loop until not inter.Busy

msgbox "user logged in"
'set usernamefield = doc.getElementById("Email")
'username.value = "arif788"

'objshell.SendKeys "{tab}"
'wscript.sleep 1000

'objshell.SendKeys "arif788"
'wscript.sleep 2000

'objshell.SendKeys "{tab}"
'wscript.sleep 2000

'objshell.SendKeys "shyma788"
'wscript.sleep 2000
'objshell.SendKeys "~"
'wscript.sleep 10000


'objshell.SendKeys "{tab}"
'wscript.sleep 500
'objshell.SendKeys "{tab}"
'wscript.sleep 500

'objshell.SendKeys "{tab}"
'wscript.sleep 500

'objshell.SendKeys "{tab}"
'wscript.sleep 500

'objshell.SendKeys "{tab}"
'wscript.sleep 500

'objshell.SendKeys "{tab}"
'wscript.sleep 500

'objshell.SendKeys "{tab}"
'wscript.sleep 500

'objshell.SendKeys "{tab}"
'wscript.sleep 500
'objshell.SendKeys "{tab}"
'wscript.sleep 500
'objshell.SendKeys "{tab}"
'wscript.sleep 500

'objshell.SendKeys "~"
'wscript.sleep 3000
'objshell.AppActivate "Gmail: Email from google"
'wscript.sleep 3000



'for i = 1 to 5
'inter.FullScreen = true
'wscript.sleep 1000
'inter.FullScreen = false
'wscript.sleep 1000
'next
'objshell.Exec("wscript D:\temp\jscript\vbsfiles\calculator.wsf")
'        
'objshell.Exec("notepad")
'wscript.sleep 3000
'objshell.Run "ie http://www.functionx.com"
'wscript.sleep 5000
'objshell.Run "ie http://www.gsmarena.com"
'wscript.sleep 6000
'objshell.Run "ie http://cricket.yahoo.com"
'wscript.sleep 6000

'objshell.Exec("iexplore")
'wscript.sleep 3000
'objshell.Exec("cmd")
'wscript.sleep 3000
'objshell.Exec("ftp microsoft.com")
'wscript.sleep 3000

'objshell.Exec("ping 10.63.4.149 -t")
'wscript.sleep 3000
