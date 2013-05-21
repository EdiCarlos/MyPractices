﻿CREATE NONCLUSTERED INDEX [IX_FK_HR_LKP_SalaryGradeDetailsHR_LKP_SalaryGrades] ON [dbo].[HR_LKP_SalaryGradeDetails] 
(
	[SalaryGradeCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)


