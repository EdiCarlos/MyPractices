CREATE TABLE [dbo].[HR_GBL_LKP_IndustryType] (
    [IndustryTypeID]   INT            IDENTITY (1, 1) NOT NULL,
    [IndustryType]     NVARCHAR (MAX) NOT NULL,
    [Domain]           NVARCHAR (20)  NULL,
    [NatureOfBusiness] NVARCHAR (100) NULL
 CONSTRAINT [PK_HR_GBL_LKP_IndustryType] PRIMARY KEY CLUSTERED 
(
	[IndustryTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
);



