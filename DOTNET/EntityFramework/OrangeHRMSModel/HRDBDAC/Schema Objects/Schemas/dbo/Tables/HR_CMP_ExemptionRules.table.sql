CREATE TABLE [dbo].[HR_CMP_ExemptionRules](
	[ExemptionRuleID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [decimal](18, 0) NULL,
	[ExemptionTypeID] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ExemptionRule] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ExemptionRuleDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ExemptionLimitedAmount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_CMP_ExemptionRules] PRIMARY KEY CLUSTERED 
(
	[ExemptionRuleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


