CREATE TABLE [dbo].[HR_LKP_DiplomaDetails](
	[DiplomaID] [int] IDENTITY(1,1) NOT NULL,
	[InstituteName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CourseName] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PassGrade] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_HR_LKP_DiplomaDetails] PRIMARY KEY CLUSTERED 
(
	[DiplomaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


