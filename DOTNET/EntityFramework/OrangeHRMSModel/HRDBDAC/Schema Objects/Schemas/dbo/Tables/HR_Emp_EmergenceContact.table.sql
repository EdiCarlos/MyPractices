CREATE TABLE [dbo].[HR_Emp_EmergenceContact](
	[EmergencyContactID] [int] IDENTITY(1,1) NOT NULL,
	[FamilyMemberID] [int] NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RelationID] [int] NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
 CONSTRAINT [PK_HR_Emp_EmergenceContact] PRIMARY KEY CLUSTERED 
(
	[EmergencyContactID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_EmployeeHR_Emp_EmergenceContact] FOREIGN KEY([EmployeeNumber])
REFERENCES [dbo].[HR_Employee] ([EmployeeNumber])
)


