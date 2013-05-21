' VBScript source code
option explicit
'on error resume next
dim ie, doc

set ie = CreateObject("InternetExplorer.Application")
ie.visible = true
ie.navigate("http://ip-address.domaintools.com/myip.xml")
do
wscript.sleep 500
loop until not ie.Busy
set doc = ie.document.all

wscript.echo ie.document.all.tags("ip_address").innertext

