comp = "."

Set objWmiService = GetObject("winmgmts:{impersonationlevel=impersonate}!\\"&comp&"\root\cimv2")

set ipconfigset = objWmiService.ExecQuery("select * from win32_networkadapterconfiguration where ipenabled = true")

for each ip in ipconfigset

if not isnull(ip.IpAddress) then
for i = LBound(ip.IpAddress) to UBound(ip.IpAddress)
wscript.echo ip.IpAddress(i)
next 
end if

next
