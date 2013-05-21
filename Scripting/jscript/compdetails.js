// JScript source code

var strcomputer = "."
var objWMIService = new GetOject("winmgmts:{imporsonationLevel=impersonate}!\\"+strcomputer+"\root\cimv2");

var colitems = objWMIService.ExecQuery("Select * from Win32_PnPEntity");

for(var myvar in colitems)
{
Wscript.Echo(myvar.Description);
}
