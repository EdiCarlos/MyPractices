use mydb;

select * from sys.tables

select * from MyPriority
select * from tb_tasklist

update tb_tasklist set [description] = 'description5' where taskid = 6

alter database mydb set enable_broker

select is_broker_enabled from sys.databases where [name] = 'mydb'

select * from sys.dm_qn_subscriptions;

exec sp_helprotect null, axkhan2

select * from sys.databases where database_id = 16


declare @p3 uniqueidentifier
set @p3='0BCD02C2-0D6D-E111-A445-0026B9800C79'
exec sp_executesql N'IF OBJECT_ID(''SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35'') IS NULL BEGIN CREATE QUEUE [SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35] WITH ACTIVATION (PROCEDURE_NAME=[SqlQueryNotificationStoredProcedure-904ac426-3b34-4e79-bdfa-d6c226c20b35], MAX_QUEUE_READERS=1, EXECUTE AS OWNER); END; IF (SELECT COUNT(*) FROM sys.services WHERE NAME=''SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35'') = 0 BEGIN CREATE SERVICE [SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35] ON QUEUE [SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35] ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]); IF (SELECT COUNT(*) FROM sys.database_principals WHERE name=''sql_dependency_subscriber'' AND type=''R'') <> 0 BEGIN GRANT SEND ON SERVICE::[SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35] TO sql_dependency_subscriber; END;  END; BEGIN DIALOG @dialog_handle FROM SERVICE [SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35] TO SERVICE ''SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35''',N'@dialog_handle uniqueidentifier output',@dialog_handle=@p3 output
select @p3

exec sp_executesql N'BEGIN CONVERSATION TIMER (''0bcd02c2-0d6d-e111-a445-0026b9800c79'') TIMEOUT = 120; WAITFOR(RECEIVE TOP (1) message_type_name, conversation_handle, cast(message_body AS XML) as message_body from [SqlQueryNotificationService-904ac426-3b34-4e79-bdfa-d6c226c20b35]), TIMEOUT @p2;',N'@p2 int',@p2=0