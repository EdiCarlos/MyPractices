CREATE PROCEDURE [dbo].[HR_SP_UpdateIndustryType]
	@industryTypeID [int],
	@industryType [nvarchar](100),
	@domain [nvarchar](100),
	@natureOfBusiness [nvarchar](100)
WITH EXECUTE AS CALLER
AS
BEGIN
UPDATE HR_GBL_LKP_IndustryType set IndustryType = @industryType, Domain = @domain, NatureOfBusiness = 
@natureOfBusiness  where IndustryTypeID = @industryTypeID
END


