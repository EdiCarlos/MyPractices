CREATE TABLE [dbo].[HR_EMP_LeaveQoutaDetails](
	[LeaveQoutaDetailID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NULL,
	[LeaveTypeID] [int] NOT NULL,
	[AvaiableLeaves] [int] NOT NULL,
	[LeaveTaken] [int] NOT NULL,
	[TotalLeaves] [int] NOT NULL,
	[Year] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PreviousYearsLeave] [int] NULL,
	[Month] [int] NOT NULL,
 CONSTRAINT [PK_HR_EMP_LeaveQoutaDetails] PRIMARY KEY CLUSTERED 
(
	[LeaveQoutaDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


