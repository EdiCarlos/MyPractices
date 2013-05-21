CREATE TABLE [dbo].[HR_Emp_ProvidentFundDetails](
	[ProvidentFundID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NULL,
	[PFNumber] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TotalPFAmount] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_HR_Emp_ProvidentFundDetails] PRIMARY KEY CLUSTERED 
(
	[ProvidentFundID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


