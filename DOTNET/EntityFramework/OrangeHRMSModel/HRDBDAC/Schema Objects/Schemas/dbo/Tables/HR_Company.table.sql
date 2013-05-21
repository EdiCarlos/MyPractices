CREATE TABLE [dbo].[HR_Company](
	[CompanyID] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[OrganizationCode] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[WebsiteUrl] [nvarchar](300) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OrganizationLogoPath] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NumberOfEmployees] [int] NULL,
	[RegisteredEmailAddress] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyDescription] [nvarchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsGovermentSector] [bit] NULL,
	[IndustryTypeID] [int] NULL,
 CONSTRAINT [PK_HR_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FR_HR_Company_HR_IndustryType_IndustryTypeID] FOREIGN KEY([IndustryTypeID])
REFERENCES [dbo].[HR_GBL_LKP_IndustryType] ([IndustryTypeID])
ON UPDATE SET NULL
ON DELETE SET NULL
)


