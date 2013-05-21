CREATE TABLE [dbo].[HR_Employee](
	[CompanyID] [bigint] NOT NULL,
	[EmployeeUID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_HR_Employee_EmployeeUID]  DEFAULT (newid()),
	[EmployeeNumber] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyEmployeeID] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Lastname] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Firstname] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Middlename] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Birthday] [datetime] NULL,
	[NationCode] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Gender] [smallint] NULL,
	[MaritalStatus] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SSNNumber] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LicenseNumber] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LicencseExpiryDate] [datetime] NULL,
	[Status] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TitleCode] [int] NOT NULL,
	[SalaryGradeCode] [int] NOT NULL,
	[JoinedDate] [datetime] NOT NULL,
	[TerminateDate] [datetime] NULL,
	[TerminationReason] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsActive] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[BloodGroup] [nvarchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Nationality] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DepartmentID] [int] NULL,
	[JobID] [int] NULL,
	[InProbation] [bit] NULL,
	[EligibleForInsurance] [bit] NULL,
 CONSTRAINT [PK_HR_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_CompanyHR_Employee] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[HR_Company] ([CompanyID]),
)


