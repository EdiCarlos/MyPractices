CREATE TABLE [dbo].[HR_LKP_SalaryGrades](
	[SalaryGradeCode] [int] IDENTITY(1,1) NOT NULL,
	[SalaryGrade] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyID] [bigint] NOT NULL,
	[CurrencyID] [int] NULL,
 CONSTRAINT [PK_HR_LKP_SalaryGrades] PRIMARY KEY CLUSTERED 
(
	[SalaryGradeCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


