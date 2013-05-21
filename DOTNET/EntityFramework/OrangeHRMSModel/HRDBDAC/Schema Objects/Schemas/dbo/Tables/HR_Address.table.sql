CREATE TABLE [dbo].[HR_Address](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NULL,
	[Street1] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Street2] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LocationID] [int] NULL,
	[AddressTypeID] [int] NOT NULL,
	[FamilyMemberID] [int] NULL,
	[CompanyID] [bigint] NULL,
	[StationID] [int] NULL,
	[InusranceCompanyID] [int] NULL,
 CONSTRAINT [PK_HR_Address] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_Emp_AddressHR_Employee] FOREIGN KEY([EmployeeNumber])
REFERENCES [dbo].[HR_Employee] ([EmployeeNumber]),
 CONSTRAINT [FK_HR_LK_AddressTypeHR_Emp_Address] FOREIGN KEY([AddressTypeID])
REFERENCES [dbo].[HR_LKP_AddressType] ([AddressTypeID]),
 CONSTRAINT [FK_HR_LocationsHR_Emp_Address] FOREIGN KEY([LocationID])
REFERENCES [dbo].[HR_Locations] ([LocationID])
)


