CREATE TABLE [dbo].[HR_CompanyAssets](
	[AssetID] [int] IDENTITY(1,1) NOT NULL,
	[PropertyTypeID] [int] NOT NULL,
	[ModelNumber] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyID] [bigint] NULL,
 CONSTRAINT [PK_HR_CompanyAssets] PRIMARY KEY CLUSTERED 
(
	[AssetID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_LK_PropertyTypeIDHR_CompanyAssets] FOREIGN KEY([PropertyTypeID])
REFERENCES [dbo].[HR_LKP_PropertyTypeID] ([PropertyTypeID])
)


