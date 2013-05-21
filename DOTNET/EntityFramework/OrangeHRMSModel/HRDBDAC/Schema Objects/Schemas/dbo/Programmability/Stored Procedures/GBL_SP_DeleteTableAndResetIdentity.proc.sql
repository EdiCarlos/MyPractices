CREATE PROCEDURE [dbo].[GBL_SP_DeleteTableAndResetIdentity]
	@tableName [nvarchar](50),
	@ident [int]
WITH EXECUTE AS CALLER
AS
BEGIN
EXEC('DELETE '+@tableName);
EXEC('DBCC CHECKIDENT('''+@tableName+''', RESEED, '+@ident+')')
END


