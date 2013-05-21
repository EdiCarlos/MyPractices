use PracDB;

select * from EmployeeTable

exec ShowEmployee 1

select * from EmployeeTable where Employeeid = 1
for xml path('Elements'), root('DocumentElement')

update EmployeeTable set Title = 'PProduction Technician - WC60' where Employeeid = 1

select [Employeeid], [loginid], [title], [birthdate] from [PracDB].[dbo].[EmployeeTable]

select is_broker_enabled from sys.databases where [name] = 'PracDB'

alter database PracDB set enable_broker

GRANT SUBSCRIBE QUERY NOTIFICATIONS TO "SyncadaUser1"

grant create procedure to [SyncadaUser1]

grant create queue to [SyncadaUser1]

grant create Service to [SyncadaUser1]

grant select on object::dbo.EmployeeTable to [SyncadaUser1]

grant receive on QueryNotificationErrorsQueue to [SyncadaUser1]

exec sp_helprotect null, SyncadaUser1

select * from sys.dm_qn_subscriptions

if OBJECT_ID(N'ShowEmployee', N'P') is not null
drop procedure ShowEmployee
go
create procedure ShowEmployee
@empid int
as
begin
select [Employeeid], [loginid], [title], [birthdate] from [dbo].[EmployeeTable]
where [Employeeid] = @empid;
end

exec ShowEmployee 1

exec [dbo].[ShowEmployee] 1

exec sp_who2
