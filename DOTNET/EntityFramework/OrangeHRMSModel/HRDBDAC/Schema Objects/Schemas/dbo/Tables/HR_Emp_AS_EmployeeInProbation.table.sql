CREATE TABLE [dbo].[HR_Emp_AS_EmployeeInProbation](
	[ProbationID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NULL,
	[ProbationStartDate] [datetime] NOT NULL,
	[ProbationEndDate] [datetime] NOT NULL,
 CONSTRAINT [PK_HR_Emp_AS_EmployeeInProbation] PRIMARY KEY CLUSTERED 
(
	[ProbationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


