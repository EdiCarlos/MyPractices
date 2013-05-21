CREATE TABLE [dbo].[HR_Cmp_PerformanceRatingType](
	[RatingTypeID] [int] IDENTITY(1,1) NOT NULL,
	[RatingType] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RatingDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompanyID] [bigint] NULL,
 CONSTRAINT [PK_HR_Cmp_PerformanceRatingType] PRIMARY KEY CLUSTERED 
(
	[RatingTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)


