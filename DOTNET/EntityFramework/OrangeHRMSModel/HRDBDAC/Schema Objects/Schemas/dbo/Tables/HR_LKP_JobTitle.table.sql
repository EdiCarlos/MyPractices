CREATE TABLE [dbo].[HR_LKP_JobTitle](
	[JobID] [int] IDENTITY(1,1) NOT NULL,
	[JobTitle] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyID] [bigint] NULL,
	[JobRole] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[JobDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DepartmentID] [int] NULL,
	[IsActive] [bit] NULL,
	[SalaryGradeCode] [int] NOT NULL,
 CONSTRAINT [PK_HR_LKP_JobTitle] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


