CREATE TABLE [dbo].[HR_Emp_ContactDetails](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
	[MobileNumber] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TelNumber] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsPrimaryMobile] [bit] NULL,
	[IsEmergencyContact] [bit] NULL,
	[WorkTelephone] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EmpOtherEmail] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WorkEmailAddress] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_Emp_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_EmployeeHR_ContactDetails] FOREIGN KEY([EmployeeNumber])
REFERENCES [dbo].[HR_Employee] ([EmployeeNumber])
)


