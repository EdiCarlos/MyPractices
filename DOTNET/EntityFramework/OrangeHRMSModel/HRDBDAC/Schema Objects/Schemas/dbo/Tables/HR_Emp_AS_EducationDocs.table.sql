CREATE TABLE [dbo].[HR_Emp_AS_EducationDocs](
	[AssociateDocID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [bigint] NOT NULL,
	[EducationDocID] [int] NOT NULL,
 CONSTRAINT [PK_HR_Emp_AS_EducationDocs] PRIMARY KEY CLUSTERED 
(
	[AssociateDocID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_Emp_EducationDocsHR_Emp_AS_EducationDocs] FOREIGN KEY([EducationDocID])
REFERENCES [dbo].[HR_Emp_EducationDocs] ([EducationDocID])
)


