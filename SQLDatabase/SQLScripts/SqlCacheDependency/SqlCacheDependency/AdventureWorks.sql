use AdventureWorks

select * from Production.ProductInventory

update Production.ProductInventory set Quantity = 0 where ProductID = 882;

select * from sys.dm_qn_subscriptions

select is_broker_enabled from sys.databases where [name]  = 'PracDB'

exec sp_helprotect null, SyncadaUser1
