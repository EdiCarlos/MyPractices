CREATE TABLE [dbo].[HR_CMP_ExemptionsType](
	[ExemptionTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ExemptionType] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ExemptionDescriptions] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyID] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HR_CMP_ExemptionsType] PRIMARY KEY CLUSTERED 
(
	[ExemptionTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


