CREATE TABLE [dbo].[HR_Emp_EducationDetails](
	[EmployeeNumber] [bigint] NOT NULL,
	[EducationID] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SchoolName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UniversityName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CollegeName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StartDate] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[EndDate] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[EduSeqNo] [smallint] NOT NULL,
	[PassPercentage] [decimal](18, 0) NULL,
	[PassGrade] [nchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DiplomaID] [int] NULL,
	[EducationDetailID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_HR_Emp_EducationDetails] PRIMARY KEY CLUSTERED 
(
	[EducationDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [FK_HR_EmployeeHR_Emp_EducationDetails] FOREIGN KEY([EmployeeNumber])
REFERENCES [dbo].[HR_Employee] ([EmployeeNumber]),
 CONSTRAINT [FK_HR_LKP_DiplomaDetailsHR_Emp_EducationDetails] FOREIGN KEY([DiplomaID])
REFERENCES [dbo].[HR_LKP_DiplomaDetails] ([DiplomaID])
)


