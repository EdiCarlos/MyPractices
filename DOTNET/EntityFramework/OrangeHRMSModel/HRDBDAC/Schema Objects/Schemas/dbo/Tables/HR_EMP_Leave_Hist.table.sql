CREATE TABLE [dbo].[HR_EMP_Leave_Hist](
	[LeaveHistId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Year] [int] NULL,
	[LeaveRequestID] [int] NULL,
 CONSTRAINT [PK_HR_EMP_Leave_Hist] PRIMARY KEY CLUSTERED 
(
	[LeaveHistId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


