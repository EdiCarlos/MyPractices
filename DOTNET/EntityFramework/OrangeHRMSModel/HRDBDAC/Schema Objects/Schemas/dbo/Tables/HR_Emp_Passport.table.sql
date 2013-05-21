CREATE TABLE [dbo].[HR_Emp_Passport](
	[EmployeeNumber] [bigint] NOT NULL,
	[PassportNumber] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IssuedDate] [datetime] NULL,
	[ExpireDate] [datetime] NULL,
	[CountryCode] [nvarchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_Emp_Passport] PRIMARY KEY CLUSTERED 
(
	[EmployeeNumber] ASC,
	[PassportNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


