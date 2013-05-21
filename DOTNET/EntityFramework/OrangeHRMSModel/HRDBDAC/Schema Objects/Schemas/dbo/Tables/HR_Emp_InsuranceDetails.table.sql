CREATE TABLE [dbo].[HR_Emp_InsuranceDetails](
	[InsuredID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[InsurancePolicyID] [int] NULL,
 CONSTRAINT [PK_HR_Emp_InsuranceDetails] PRIMARY KEY CLUSTERED 
(
	[InsuredID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


