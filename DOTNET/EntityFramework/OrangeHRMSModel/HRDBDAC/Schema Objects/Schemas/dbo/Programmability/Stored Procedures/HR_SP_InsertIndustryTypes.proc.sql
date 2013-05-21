CREATE PROCEDURE [dbo].[HR_SP_InsertIndustryTypes]
	@industryType [nvarchar](100),
	@domain [nvarchar](100),
	@natureOfBusiness [nvarchar](100)
WITH EXECUTE AS CALLER
AS
INSERT INTO HRDB.dbo.HR_GBL_LKP_IndustryType(IndustryType, Domain, NatureOfBusiness) 
VALUES (@industryType, @domain, @natureOfBusiness);
SELECT * FROM HRDB.dbo.HR_GBL_LKP_IndustryType WHERE IndustryTypeID = @@IDENTITY;


