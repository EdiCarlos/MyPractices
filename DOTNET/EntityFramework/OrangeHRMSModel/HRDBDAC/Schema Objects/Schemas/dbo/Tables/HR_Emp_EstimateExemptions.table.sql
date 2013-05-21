CREATE TABLE [dbo].[HR_Emp_EstimateExemptions](
	[EstimateExemptionID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
	[ExemptionRuleID] [int] NOT NULL,
	[ExemptionAmount] [decimal](18, 0) NOT NULL,
	[EstimateTaxExemptionID] [int] NOT NULL,
 CONSTRAINT [PK_HR_Emp_EstimateExemptions] PRIMARY KEY CLUSTERED 
(
	[EstimateExemptionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


