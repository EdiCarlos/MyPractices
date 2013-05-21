﻿CREATE TABLE [dbo].[HR_CMP_LKP_InsuranceCompanyDetail](
	[InusranceCompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_CMP_LKP_InsuranceCompanyDetail] PRIMARY KEY CLUSTERED 
(
	[InusranceCompanyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


