
Set objwmiservice = GetObject("winmgmts:\\.\root\cimv2")
Set query = objwmiservice.ExecQuery("select * from Win32_LocalTime")

For each q in query

Next
