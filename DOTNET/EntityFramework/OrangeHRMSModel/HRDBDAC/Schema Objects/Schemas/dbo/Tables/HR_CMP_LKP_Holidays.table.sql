CREATE TABLE [dbo].[HR_CMP_LKP_Holidays](
	[HolidayID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [bigint] NOT NULL,
	[HolidayTitle] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[HolidayDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[HolidayDate] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Year] [int] NOT NULL,
 CONSTRAINT [PK_HR_CMP_LKP_Holidays] PRIMARY KEY CLUSTERED 
(
	[HolidayID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


