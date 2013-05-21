CREATE TABLE [dbo].[HR_Emp_ReportingDetails](
	[EmployeeManagerId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NULL,
 CONSTRAINT [PK_HR_Emp_ReportingDetails] PRIMARY KEY CLUSTERED 
(
	[EmployeeManagerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


