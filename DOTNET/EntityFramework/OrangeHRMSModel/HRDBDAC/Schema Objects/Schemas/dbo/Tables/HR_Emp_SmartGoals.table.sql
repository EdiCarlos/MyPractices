CREATE TABLE [dbo].[HR_Emp_SmartGoals](
	[SmartGoalID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [bigint] NULL,
	[EmployeeNumber] [bigint] NULL,
	[GoalHeadLine] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[GoalDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Year] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DocPath] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_Emp_SmartGoals] PRIMARY KEY CLUSTERED 
(
	[SmartGoalID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


