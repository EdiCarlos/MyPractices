CREATE TABLE [dbo].[HR_Emp_ReviewDetails](
	[ReviewID] [int] IDENTITY(1,1) NOT NULL,
	[ReviewerID] [bigint] NULL,
	[EmployeeNumber] [bigint] NULL,
	[ReviewStartDate] [datetime] NOT NULL,
	[ReviewEndDate] [datetime] NOT NULL,
	[DateOfReview] [datetime] NOT NULL,
	[DocPath] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RatingTypeID] [int] NULL,
	[Year] [int] NOT NULL,
 CONSTRAINT [PK_HR_Emp_ReviewDetails] PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


