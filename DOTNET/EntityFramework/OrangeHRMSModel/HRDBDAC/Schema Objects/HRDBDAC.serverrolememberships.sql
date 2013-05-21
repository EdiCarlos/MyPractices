EXECUTE sp_addsrvrolemember @loginame = N'axkhan', @rolename = N'bulkadmin';
GO
EXECUTE sp_addsrvrolemember @loginame = N'ppmaster', @rolename = N'sysadmin';
GO
EXECUTE sp_addsrvrolemember @loginame = N'NT AUTHORITY\NETWORK SERVICE', @rolename = N'sysadmin';


