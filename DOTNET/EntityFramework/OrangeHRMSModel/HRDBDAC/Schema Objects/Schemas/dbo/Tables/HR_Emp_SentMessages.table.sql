CREATE TABLE [dbo].[HR_Emp_SentMessages](
	[SentMessageID] [int] IDENTITY(1,1) NOT NULL,
	[MessageToEmployeeNumber] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MessageID] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_Emp_SentMessages] PRIMARY KEY CLUSTERED 
(
	[SentMessageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


