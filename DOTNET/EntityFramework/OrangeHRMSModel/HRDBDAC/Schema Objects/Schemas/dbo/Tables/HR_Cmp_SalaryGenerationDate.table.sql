CREATE TABLE [dbo].[HR_Cmp_SalaryGenerationDate](
	[GenerationId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [bigint] NOT NULL,
	[GenerationDay] [smallint] NOT NULL,
 CONSTRAINT [PK_HR_Cmp_SalaryGenerationDate] PRIMARY KEY CLUSTERED 
(
	[GenerationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


