CREATE TABLE [dbo].[HR_Emp_PreviousEmploymentDetails](
	[EmploymentDetailID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
	[EmployeeSeqNumber] [smallint] NOT NULL,
	[EmployerName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[JobTitle] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NOT NULL,
	[CTC] [decimal](18, 0) NOT NULL,
	[JobDescription] [nvarchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_Emp_PreviousEmploymentDetails] PRIMARY KEY CLUSTERED 
(
	[EmploymentDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_EmployeeHR_Emp_PreviousEmploymentDetails] FOREIGN KEY([EmployeeNumber])
REFERENCES [dbo].[HR_Employee] ([EmployeeNumber])
)


