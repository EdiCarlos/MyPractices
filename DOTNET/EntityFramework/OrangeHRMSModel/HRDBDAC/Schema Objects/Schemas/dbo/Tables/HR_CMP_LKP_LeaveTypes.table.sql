CREATE TABLE [dbo].[HR_CMP_LKP_LeaveTypes](
	[LeaveTypeID] [int] IDENTITY(1,1) NOT NULL,
	[LeaveType] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LeaveDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyID] [bigint] NULL,
 CONSTRAINT [PK_HR_CMP_LKP_LeaveTypes] PRIMARY KEY CLUSTERED 
(
	[LeaveTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


