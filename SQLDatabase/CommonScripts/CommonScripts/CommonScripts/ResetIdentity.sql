-- =============================================
-- Script Template
-- =============================================
USE HRDB
GO
IF OBJECT_ID(N'GBL_SP_DeleteTableAndResetIdentity', N'P') IS NOT NULL
DROP PROCEDURE GBL_SP_DeleteTableAndResetIdentity
GO
CREATE PROCEDURE GBL_SP_DeleteTableAndResetIdentity
@tableName nvarchar(50),
@ident int
AS
BEGIN
EXEC('DELETE '+@tableName);
EXEC('DBCC CHECKIDENT('''+@tableName+''', RESEED, '+@ident+')')
END
