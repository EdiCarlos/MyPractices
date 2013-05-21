CREATE TABLE [dbo].[HR_LKP_PropertyTypeID](
	[PropertyTypeID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [bigint] NOT NULL,
	[PropertyType] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PropertyName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_LKP_PropertyTypeID] PRIMARY KEY CLUSTERED 
(
	[PropertyTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


