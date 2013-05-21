CREATE TABLE [dbo].[HR_Emp_AnnualSalaryDetails](
	[AnnualSalaryID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
	[SalaryGradeCode] [int] NULL,
	[AnnualBasic] [decimal](18, 0) NOT NULL,
	[AnnualHouseRent] [decimal](18, 0) NOT NULL,
	[AnnualMedicalReimbursment] [decimal](18, 0) NOT NULL,
	[AnnualLTAReimbursment] [decimal](18, 0) NOT NULL,
	[AnnualFuelReimbursment] [decimal](18, 0) NOT NULL,
	[AnnualProfessionalDevelopment] [decimal](18, 0) NOT NULL,
	[Misc1] [decimal](18, 0) NULL,
	[Misc2] [decimal](18, 0) NULL,
	[Misc3] [decimal](18, 0) NULL,
	[Misc4] [decimal](18, 0) NULL,
	[Misc5] [decimal](18, 0) NULL,
	[Misc6] [decimal](18, 0) NULL,
	[Misc7] [decimal](18, 0) NULL,
	[Misc8] [decimal](18, 0) NULL,
	[Misc9] [decimal](18, 0) NULL,
	[Misc1Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Misc2Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Misc3Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Misc4Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Misc5Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Misc6Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Misc7Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Misc8Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Misc9Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AnnualGrossSalary] [decimal](18, 0) NOT NULL,
	[AnnualNetSalary] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_HR_Emp_AnnualSalaryDetails] PRIMARY KEY CLUSTERED 
(
	[AnnualSalaryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


