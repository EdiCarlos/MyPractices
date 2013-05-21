CREATE TABLE [dbo].[HR_Emp_FamilyMembers](
	[FamilyMemberID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Age] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RelationID] [int] NOT NULL,
	[Gender] [nvarchar](1) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsMinor] [bit] NULL,
	[IsDependent] [bit] NULL,
	[IsNominee] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ResidesWithEmployee] [bit] NULL,
	[EmployeeNumber] [bigint] NULL,
	[ContactPersonInEmergency] [bit] NOT NULL,
	[EligibleForInsurance] [bit] NULL,
 CONSTRAINT [PK_HR_Emp_FamilyMembers] PRIMARY KEY CLUSTERED 
(
	[FamilyMemberID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_EmployeeHR_Emp_FamilyMembers] FOREIGN KEY([EmployeeNumber])
REFERENCES [dbo].[HR_Employee] ([EmployeeNumber]),
 CONSTRAINT [FK_HR_LKP_RelationTypeHR_Emp_FamilyMembers] FOREIGN KEY([RelationID])
REFERENCES [dbo].[HR_GLB_LKP_RelationType] ([RelationID])
)


