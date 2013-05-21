CREATE TABLE [dbo].[HR_Emp_LeaveRequest](
	[LeaveRequestID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NULL,
	[LeaveID] [int] NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[TotalNoLeavesRequested] [int] NOT NULL,
	[ApprovalStatusID] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_HR_Emp_LeaveRequest] PRIMARY KEY CLUSTERED 
(
	[LeaveRequestID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


