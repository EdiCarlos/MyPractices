CREATE TABLE [dbo].[HR_Log](
	[LogID] [bigint] IDENTITY(1,1) NOT NULL,
	[Level] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Host] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Type] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Source] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Logger] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Message] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Date] [date] NULL,
	[StackTrace] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)


