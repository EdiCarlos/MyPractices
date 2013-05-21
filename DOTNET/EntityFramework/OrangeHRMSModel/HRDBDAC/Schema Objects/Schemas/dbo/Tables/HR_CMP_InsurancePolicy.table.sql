CREATE TABLE [dbo].[HR_CMP_InsurancePolicy](
	[InsurancePolicyID] [int] IDENTITY(1,1) NOT NULL,
	[InusranceCompanyID] [int] NOT NULL,
	[PolicyAmount] [decimal](18, 0) NOT NULL,
	[CompanyID] [bigint] NULL,
	[PolicyDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyURL] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_CMP_InsurancePolicy] PRIMARY KEY CLUSTERED 
(
	[InsurancePolicyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


