CREATE TABLE [dbo].[HR_LKP_SalaryGradeDetails](
	[SalaryDetailID] [int] IDENTITY(1,1) NOT NULL,
	[SalaryGradeCode] [int] NOT NULL,
	[CompanyID] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MinCTC] [decimal](18, 0) NOT NULL,
	[MaxCTC] [decimal](18, 0) NOT NULL,
	[MinExperience] [int] NOT NULL,
	[MaxExperience] [int] NOT NULL,
	[CurrencyID] [int] NULL,
 CONSTRAINT [PK_HR_LKP_SalaryGradeDetails] PRIMARY KEY CLUSTERED 
(
	[SalaryDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_LKP_SalaryGradeDetailsHR_LKP_SalaryGrades] FOREIGN KEY([SalaryGradeCode])
REFERENCES [dbo].[HR_LKP_SalaryGrades] ([SalaryGradeCode])
)


