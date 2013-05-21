CREATE PROCEDURE [dbo].[HR_SP_DeleteIndustryType]
	@industryTypeID [int]
WITH EXECUTE AS CALLER
AS
DELETE HR_GBL_LKP_IndustryType where IndustryTypeID = @industryTypeID;


