ALTER TABLE [dbo].[HR_Employee]
    ADD CONSTRAINT [FK_HR_EmployeeHR_LKP_Departments] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[HR_LKP_Departments] ([DepartmentID]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
ALTER TABLE [dbo].[HR_Employee] NOCHECK CONSTRAINT [FK_HR_EmployeeHR_LKP_Departments];

