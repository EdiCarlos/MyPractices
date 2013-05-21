
ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [HRDB], FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\HRDB.mdf', SIZE = 2304 KB, FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];



GO

ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [HRDB_log], FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\HRDB_log.LDF', SIZE = 832 KB, MAXSIZE = 2097152 MB, FILEGROWTH = 10 %);



GO

ALTER INDEX [IX_FK_HR_CompanyHR_Employee]
    ON [dbo].[HR_Employee] DISABLE;
GO
ALTER INDEX [IX_FK_HR_EmployeeHR_LKP_Departments]
    ON [dbo].[HR_Employee] DISABLE;
GO
ALTER INDEX [IX_FK_HR_GLB_LKP_NameTitleHR_Employee]
    ON [dbo].[HR_Employee] DISABLE;
GO
ALTER INDEX [IX_FK_HR_SalaryGradesHR_Employee]
    ON [dbo].[HR_Employee] DISABLE;

GO
