CREATE TABLE [dbo].[HR_LKP_Country](
	[CountryCode] [nvarchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ISOCode] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CurrencyID] [int] NOT NULL,
 CONSTRAINT [PK_HR_LKP_Country] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_LK_CountryHR_LK_Currency] FOREIGN KEY([CurrencyID])
REFERENCES [dbo].[HR_LK_Currency] ([CurrencyID])
)


