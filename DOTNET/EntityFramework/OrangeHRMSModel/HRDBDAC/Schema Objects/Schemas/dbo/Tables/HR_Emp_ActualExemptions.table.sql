CREATE TABLE [dbo].[HR_Emp_ActualExemptions](
	[MiscExemptionID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
	[ExemptionRuleID] [int] NOT NULL,
	[ExemptionAmount] [decimal](18, 0) NOT NULL,
	[ActualTaxExemptionID] [int] NOT NULL,
 CONSTRAINT [PK_HR_Emp_ActualExemptions] PRIMARY KEY CLUSTERED 
(
	[MiscExemptionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


