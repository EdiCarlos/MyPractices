CREATE TABLE [dbo].[HR_GBL_TaxRules](
	[TaxRuleID] [int] IDENTITY(1,1) NOT NULL,
	[RuleName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RuleDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RuleValue] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyID] [bigint] NULL,
 CONSTRAINT [PK_HR_GBL_TaxRules] PRIMARY KEY CLUSTERED 
(
	[TaxRuleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


