CREATE TABLE [dbo].[HR_Emp_BankAccountDetails](
	[EmployeeNumber] [bigint] NOT NULL,
	[BankID] [int] NULL,
	[AccountNumber] [int] NOT NULL,
	[IsSalaryAccount] [bit] NULL,
	[IsSalaryCreditAccount] [bit] NULL,
	[BankAccountTypeID] [int] NOT NULL,
 CONSTRAINT [PK_HR_Emp_BankAccountDetails] PRIMARY KEY CLUSTERED 
(
	[EmployeeNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


