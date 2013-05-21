CREATE TABLE [dbo].[HR_CMP_LKP_LeaveQouta](
	[LeaveQuotaID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [bigint] NULL,
	[LeaveQouta] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PorbationLeaveQouta] [int] NULL,
 CONSTRAINT [PK_HR_CMP_LKP_LeaveQouta] PRIMARY KEY CLUSTERED 
(
	[LeaveQuotaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


