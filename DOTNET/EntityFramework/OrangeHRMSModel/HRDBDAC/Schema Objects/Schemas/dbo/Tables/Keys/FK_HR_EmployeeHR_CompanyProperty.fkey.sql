ALTER TABLE [dbo].[HR_Emp_Property]
    ADD CONSTRAINT [FK_HR_EmployeeHR_CompanyProperty] FOREIGN KEY ([EmployeeNumber]) REFERENCES [dbo].[HR_Employee] ([EmployeeNumber]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
ALTER TABLE [dbo].[HR_Emp_Property] NOCHECK CONSTRAINT [FK_HR_EmployeeHR_CompanyProperty];

