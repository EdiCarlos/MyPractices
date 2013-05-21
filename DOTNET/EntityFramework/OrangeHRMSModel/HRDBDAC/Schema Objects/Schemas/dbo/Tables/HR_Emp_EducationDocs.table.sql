CREATE TABLE [dbo].[HR_Emp_EducationDocs](
	[EducationDocID] [int] IDENTITY(1,1) NOT NULL,
	[CertificatePath] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MarkSheetPath] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DiplomaCertificatePath] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_Emp_EducationDocs] PRIMARY KEY CLUSTERED 
(
	[EducationDocID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


