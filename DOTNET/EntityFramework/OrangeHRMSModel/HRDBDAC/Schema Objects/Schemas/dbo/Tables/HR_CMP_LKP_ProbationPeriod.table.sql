CREATE TABLE [dbo].[HR_CMP_LKP_ProbationPeriod](
	[ProbationPeriodID] [int] IDENTITY(1,1) NOT NULL,
	[ProbationInMonths] [int] NOT NULL,
	[CompanyID] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_CMP_LKP_ProbationPeriod] PRIMARY KEY CLUSTERED 
(
	[ProbationPeriodID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


