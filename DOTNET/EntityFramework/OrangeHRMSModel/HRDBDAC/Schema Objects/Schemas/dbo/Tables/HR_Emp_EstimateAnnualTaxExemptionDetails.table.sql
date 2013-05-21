CREATE TABLE [dbo].[HR_Emp_EstimateAnnualTaxExemptionDetails](
	[EstimateTaxExemptionID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
	[ProffessionalTax] [decimal](18, 0) NOT NULL,
	[ProvidentFund] [decimal](18, 0) NOT NULL,
	[VoluntaryPF] [decimal](18, 0) NOT NULL,
	[IncomeTax] [decimal](18, 0) NOT NULL,
	[LifeInsurance] [decimal](18, 0) NOT NULL,
	[OtherDeduction1] [decimal](18, 0) NOT NULL,
	[OtherDeduction2] [decimal](18, 0) NOT NULL,
	[OtherDeduction3] [decimal](18, 0) NOT NULL,
	[OtherDeduction4] [decimal](18, 0) NOT NULL,
	[OtherDeduction5] [decimal](18, 0) NOT NULL,
	[OtherDeduction6] [decimal](18, 0) NOT NULL,
	[OtherDeduction7] [decimal](18, 0) NOT NULL,
	[OtherDeduction8] [decimal](18, 0) NOT NULL,
	[OtherDeduction9] [decimal](18, 0) NOT NULL,
	[OD1Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OD2Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OD3Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OD4Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OD5Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OD6Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OD7Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OD8Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[OD9Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Year] [int] NOT NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_HR_Emp_EstimateAnnualTaxExemptionDetails] PRIMARY KEY CLUSTERED 
(
	[EstimateTaxExemptionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


