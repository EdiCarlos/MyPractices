CREATE PROCEDURE [dbo].[HR_SP_InsertCompany]
	@companyName [nvarchar](30),
	@organiztionCode [nvarchar](10),
	@webSiteURL [nvarchar](300),
	@organizationLogoPath [nvarchar](100),
	@numberOfEmployees [int],
	@registeredEmailAddress [nvarchar](100),
	@companyDescription [nvarchar](1000),
	@isGovernmentSector [bit],
	@industryTypeID [int]
WITH EXECUTE AS CALLER
AS
BEGIN
 SET NOCOUNT ON;
 INSERT INTO HR_Company(
 CompanyName, 
 OrganizationCode,
 WebsiteUrl,
 OrganizationLogoPath,
 NumberOfEmployees,
 RegisteredEmailAddress,
 CompanyDescription,
 IsGovermentSector,
 IndustryTypeID)
 VALUES
 (
  @companyName ,
  @organiztionCode ,
  @webSiteURL , 
  @organizationLogoPath , 
  @numberOfEmployees , 
  @registeredEmailAddress,
  @companyDescription ,
  @isGovernmentSector,
  @industryTypeID 
 )
 SELECT * FROM HR_Company WHERE CompanyID = IDENT_CURRENT('HR_Company')
END


