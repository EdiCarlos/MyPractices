ALTER TABLE [dbo].[HR_Employee]
    ADD CONSTRAINT [FK_HR_SalaryGradesHR_Employee] FOREIGN KEY ([SalaryGradeCode]) REFERENCES [dbo].[HR_LKP_SalaryGrades] ([SalaryGradeCode]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
ALTER TABLE [dbo].[HR_Employee] NOCHECK CONSTRAINT [FK_HR_SalaryGradesHR_Employee];

