
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/06/2012 13:34:48
-- Generated from EDMX file: D:\MyPractices\DOTNET\EntityFramework\OrangeHRMSModel\HRDBModel\HRDBModelDatabase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HRDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_HR_CompanyAssetsHR_EmployeeProperty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_Property] DROP CONSTRAINT [FK_HR_CompanyAssetsHR_EmployeeProperty];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_CompanyHR_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Employee] DROP CONSTRAINT [FK_HR_CompanyHR_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_Emp_AddressHR_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Address] DROP CONSTRAINT [FK_HR_Emp_AddressHR_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_Emp_EducationDocsHR_Emp_AS_EducationDocs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_AS_EducationDocs] DROP CONSTRAINT [FK_HR_Emp_EducationDocsHR_Emp_AS_EducationDocs];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_Emp_SkillsHR_LKP_Skill]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_Skills] DROP CONSTRAINT [FK_HR_Emp_SkillsHR_LKP_Skill];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_EmployeeHR_CompanyProperty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_Property] DROP CONSTRAINT [FK_HR_EmployeeHR_CompanyProperty];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_EmployeeHR_ContactDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_ContactDetails] DROP CONSTRAINT [FK_HR_EmployeeHR_ContactDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_EmployeeHR_Emp_EducationDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_EducationDetails] DROP CONSTRAINT [FK_HR_EmployeeHR_Emp_EducationDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_EmployeeHR_Emp_EmergenceContact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_EmergenceContact] DROP CONSTRAINT [FK_HR_EmployeeHR_Emp_EmergenceContact];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_EmployeeHR_Emp_FamilyMembers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_FamilyMembers] DROP CONSTRAINT [FK_HR_EmployeeHR_Emp_FamilyMembers];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_EmployeeHR_Emp_PreviousEmploymentDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_PreviousEmploymentDetails] DROP CONSTRAINT [FK_HR_EmployeeHR_Emp_PreviousEmploymentDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_EmployeeHR_LKP_Departments]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Employee] DROP CONSTRAINT [FK_HR_EmployeeHR_LKP_Departments];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_GLB_LKP_NameTitleHR_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Employee] DROP CONSTRAINT [FK_HR_GLB_LKP_NameTitleHR_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_LK_AddressTypeHR_Emp_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Address] DROP CONSTRAINT [FK_HR_LK_AddressTypeHR_Emp_Address];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_LK_CountryHR_LK_Currency]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_LKP_Country] DROP CONSTRAINT [FK_HR_LK_CountryHR_LK_Currency];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_LK_CountryHR_Locations]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Locations] DROP CONSTRAINT [FK_HR_LK_CountryHR_Locations];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_LK_PropertyTypeIDHR_CompanyAssets]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_CompanyAssets] DROP CONSTRAINT [FK_HR_LK_PropertyTypeIDHR_CompanyAssets];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_LKP_DiplomaDetailsHR_Emp_EducationDetails]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_EducationDetails] DROP CONSTRAINT [FK_HR_LKP_DiplomaDetailsHR_Emp_EducationDetails];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_LKP_RelationTypeHR_Emp_FamilyMembers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Emp_FamilyMembers] DROP CONSTRAINT [FK_HR_LKP_RelationTypeHR_Emp_FamilyMembers];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_LKP_SalaryGradeDetailsHR_LKP_SalaryGrades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_LKP_SalaryGradeDetails] DROP CONSTRAINT [FK_HR_LKP_SalaryGradeDetailsHR_LKP_SalaryGrades];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_LocationsHR_Emp_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Address] DROP CONSTRAINT [FK_HR_LocationsHR_Emp_Address];
GO
IF OBJECT_ID(N'[dbo].[FK_HR_SalaryGradesHR_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HR_Employee] DROP CONSTRAINT [FK_HR_SalaryGradesHR_Employee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[HR_Address]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Address];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_AccountsWithBanks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_AccountsWithBanks];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_AS_PolicyAppliedTo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_AS_PolicyAppliedTo];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_AS_WorkShifts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_AS_WorkShifts];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_ExemptionRules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_ExemptionRules];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_ExemptionsType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_ExemptionsType];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_InsurancePolicy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_InsurancePolicy];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_LKP_Holidays]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_LKP_Holidays];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_LKP_InsuranceCompanyDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_LKP_InsuranceCompanyDetail];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_LKP_LeaveQouta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_LKP_LeaveQouta];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_LKP_Leaves]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_LKP_Leaves];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_LKP_LeaveTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_LKP_LeaveTypes];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_LKP_ProbationPeriod]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_LKP_ProbationPeriod];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_LKP_StationType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_LKP_StationType];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_Messages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_Messages];
GO
IF OBJECT_ID(N'[dbo].[HR_Cmp_PerformanceRatingType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Cmp_PerformanceRatingType];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_Policies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_Policies];
GO
IF OBJECT_ID(N'[dbo].[HR_Cmp_SalaryGenerationDate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Cmp_SalaryGenerationDate];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_Stations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_Stations];
GO
IF OBJECT_ID(N'[dbo].[HR_CMP_WorkShifts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CMP_WorkShifts];
GO
IF OBJECT_ID(N'[dbo].[HR_Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Company];
GO
IF OBJECT_ID(N'[dbo].[HR_CompanyAssets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_CompanyAssets];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_ActualAnnualTaxExemptionDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_ActualAnnualTaxExemptionDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_ActualExemptions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_ActualExemptions];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_AnnualSalaryDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_AnnualSalaryDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_AnnualTaxDeductionDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_AnnualTaxDeductionDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_AS_EducationDocs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_AS_EducationDocs];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_AS_EmployeeInProbation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_AS_EmployeeInProbation];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_BankAccountDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_BankAccountDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_ContactDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_ContactDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_EducationDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_EducationDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_EducationDocs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_EducationDocs];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_EmergenceContact]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_EmergenceContact];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_EstimateAnnualTaxExemptionDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_EstimateAnnualTaxExemptionDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_EstimateExemptions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_EstimateExemptions];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_ExemptionDocuments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_ExemptionDocuments];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_FamilyMembers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_FamilyMembers];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_Inbox]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_Inbox];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_InsuranceDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_InsuranceDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_EMP_Leave_Hist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_EMP_Leave_Hist];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_LeaveApprovalMessage]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_LeaveApprovalMessage];
GO
IF OBJECT_ID(N'[dbo].[HR_EMP_LeaveQoutaDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_EMP_LeaveQoutaDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_LeaveRequest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_LeaveRequest];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_MonthlySalaryDeductionDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_MonthlySalaryDeductionDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_MonthlySalaryDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_MonthlySalaryDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_Passport]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_Passport];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_PreviousEmploymentDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_PreviousEmploymentDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_Property]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_Property];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_ProvidentFundDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_ProvidentFundDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_RelatedDocs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_RelatedDocs];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_RelatedDocs_Hist]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_RelatedDocs_Hist];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_ReportingDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_ReportingDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_ReviewDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_ReviewDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_SentMessages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_SentMessages];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_Skills]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_Skills];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_SmartGoals]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_SmartGoals];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_UserGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_UserGroup];
GO
IF OBJECT_ID(N'[dbo].[HR_Emp_Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Emp_Users];
GO
IF OBJECT_ID(N'[dbo].[HR_Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Employee];
GO
IF OBJECT_ID(N'[dbo].[HR_GBL_LKP_ApprovalStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_GBL_LKP_ApprovalStatus];
GO
IF OBJECT_ID(N'[dbo].[HR_GBL_LKP_IndustryType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_GBL_LKP_IndustryType];
GO
IF OBJECT_ID(N'[dbo].[HR_GBL_TaxRules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_GBL_TaxRules];
GO
IF OBJECT_ID(N'[dbo].[HR_GLB_LKP_Banks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_GLB_LKP_Banks];
GO
IF OBJECT_ID(N'[dbo].[HR_GLB_LKP_NameTitle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_GLB_LKP_NameTitle];
GO
IF OBJECT_ID(N'[dbo].[HR_GLB_LKP_RelationType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_GLB_LKP_RelationType];
GO
IF OBJECT_ID(N'[dbo].[HR_LK_Currency]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LK_Currency];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_AddressType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_AddressType];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_BankAccountTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_BankAccountTypes];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_Country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_Country];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_Departments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_Departments];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_DiplomaDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_DiplomaDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_EductionType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_EductionType];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_JobTitle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_JobTitle];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_PropertyTypeID]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_PropertyTypeID];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_SalaryGradeDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_SalaryGradeDetails];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_SalaryGrades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_SalaryGrades];
GO
IF OBJECT_ID(N'[dbo].[HR_LKP_Skill]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_LKP_Skill];
GO
IF OBJECT_ID(N'[dbo].[HR_Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HR_Locations];
GO
IF OBJECT_ID(N'[HRDBModelStoreContainer].[HR_Log]', 'U') IS NOT NULL
    DROP TABLE [HRDBModelStoreContainer].[HR_Log];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'HR_Address'
CREATE TABLE [dbo].[HR_Address] (
    [AddressID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NULL,
    [Street1] nvarchar(max)  NOT NULL,
    [Street2] nvarchar(max)  NOT NULL,
    [LocationID] int  NULL,
    [AddressTypeID] int  NOT NULL,
    [FamilyMemberID] int  NULL,
    [CompanyID] bigint  NULL,
    [StationID] int  NULL,
    [InusranceCompanyID] int  NULL
);
GO

-- Creating table 'HR_CMP_AccountsWithBanks'
CREATE TABLE [dbo].[HR_CMP_AccountsWithBanks] (
    [CompanyID] bigint  NOT NULL,
    [BankID] int  NOT NULL
);
GO

-- Creating table 'HR_CMP_AS_PolicyAppliedTo'
CREATE TABLE [dbo].[HR_CMP_AS_PolicyAppliedTo] (
    [PolicyID] int  NOT NULL,
    [StationID] nvarchar(max)  NOT NULL,
    [CompanyID] bigint  NULL
);
GO

-- Creating table 'HR_CMP_AS_WorkShifts'
CREATE TABLE [dbo].[HR_CMP_AS_WorkShifts] (
    [CompanyID] bigint IDENTITY(1,1) NOT NULL,
    [WorkShiftID] int  NOT NULL,
    [StationID] int  NOT NULL
);
GO

-- Creating table 'HR_CMP_ExemptionRules'
CREATE TABLE [dbo].[HR_CMP_ExemptionRules] (
    [ExemptionRuleID] int IDENTITY(1,1) NOT NULL,
    [CompanyID] decimal(18,0)  NULL,
    [ExemptionTypeID] nvarchar(max)  NOT NULL,
    [ExemptionRule] nvarchar(max)  NOT NULL,
    [ExemptionRuleDescription] nvarchar(max)  NOT NULL,
    [ExemptionLimitedAmount] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_CMP_ExemptionsType'
CREATE TABLE [dbo].[HR_CMP_ExemptionsType] (
    [ExemptionTypeId] int IDENTITY(1,1) NOT NULL,
    [ExemptionType] nvarchar(max)  NOT NULL,
    [ExemptionDescriptions] nvarchar(max)  NOT NULL,
    [CompanyID] decimal(18,0)  NULL
);
GO

-- Creating table 'HR_CMP_InsurancePolicy'
CREATE TABLE [dbo].[HR_CMP_InsurancePolicy] (
    [InsurancePolicyID] int IDENTITY(1,1) NOT NULL,
    [InusranceCompanyID] int  NOT NULL,
    [PolicyAmount] decimal(18,0)  NOT NULL,
    [CompanyID] bigint  NULL,
    [PolicyDescription] nvarchar(max)  NOT NULL,
    [CompanyURL] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_CMP_LKP_Holidays'
CREATE TABLE [dbo].[HR_CMP_LKP_Holidays] (
    [HolidayID] int IDENTITY(1,1) NOT NULL,
    [CompanyID] bigint  NOT NULL,
    [HolidayTitle] nvarchar(max)  NOT NULL,
    [HolidayDescription] nvarchar(max)  NOT NULL,
    [HolidayDate] nvarchar(max)  NOT NULL,
    [Year] int  NOT NULL
);
GO

-- Creating table 'HR_CMP_LKP_InsuranceCompanyDetail'
CREATE TABLE [dbo].[HR_CMP_LKP_InsuranceCompanyDetail] (
    [InusranceCompanyID] int IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_CMP_LKP_LeaveQouta'
CREATE TABLE [dbo].[HR_CMP_LKP_LeaveQouta] (
    [LeaveQuotaID] int IDENTITY(1,1) NOT NULL,
    [CompanyID] bigint  NULL,
    [LeaveQouta] nvarchar(max)  NOT NULL,
    [PorbationLeaveQouta] int  NULL
);
GO

-- Creating table 'HR_CMP_LKP_Leaves'
CREATE TABLE [dbo].[HR_CMP_LKP_Leaves] (
    [LeaveID] int IDENTITY(1,1) NOT NULL,
    [LeaveTypeID] int  NULL,
    [CompanyID] bigint  NULL,
    [NumberOfLeaves] int  NOT NULL,
    [IsPaid] bit  NOT NULL
);
GO

-- Creating table 'HR_CMP_LKP_LeaveTypes'
CREATE TABLE [dbo].[HR_CMP_LKP_LeaveTypes] (
    [LeaveTypeID] int IDENTITY(1,1) NOT NULL,
    [LeaveType] nvarchar(max)  NOT NULL,
    [LeaveDescription] nvarchar(max)  NOT NULL,
    [CompanyID] bigint  NULL
);
GO

-- Creating table 'HR_CMP_LKP_ProbationPeriod'
CREATE TABLE [dbo].[HR_CMP_LKP_ProbationPeriod] (
    [ProbationPeriodID] int IDENTITY(1,1) NOT NULL,
    [ProbationInMonths] int  NOT NULL,
    [CompanyID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_CMP_LKP_StationType'
CREATE TABLE [dbo].[HR_CMP_LKP_StationType] (
    [StationTypeID] int IDENTITY(1,1) NOT NULL,
    [StationType] nvarchar(max)  NOT NULL,
    [CompanyID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_CMP_Messages'
CREATE TABLE [dbo].[HR_CMP_Messages] (
    [MessageID] int IDENTITY(1,1) NOT NULL,
    [CompanyNumber] nvarchar(max)  NOT NULL,
    [FromEmployeeNumber] nvarchar(max)  NOT NULL,
    [MessageToEmployeeNumber] nvarchar(max)  NOT NULL,
    [Subject] nvarchar(max)  NOT NULL,
    [Body] nvarchar(max)  NOT NULL,
    [MessageDate] nvarchar(max)  NOT NULL,
    [CompanyID] bigint  NULL
);
GO

-- Creating table 'HR_Cmp_PerformanceRatingType'
CREATE TABLE [dbo].[HR_Cmp_PerformanceRatingType] (
    [RatingTypeID] int IDENTITY(1,1) NOT NULL,
    [RatingType] nvarchar(max)  NOT NULL,
    [RatingDescription] nvarchar(max)  NOT NULL,
    [CompanyID] bigint  NULL
);
GO

-- Creating table 'HR_CMP_Policies'
CREATE TABLE [dbo].[HR_CMP_Policies] (
    [PolicyID] int IDENTITY(1,1) NOT NULL,
    [CompanyID] bigint  NOT NULL,
    [PolicyName] nvarchar(max)  NOT NULL,
    [PolicyDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Cmp_SalaryGenerationDate'
CREATE TABLE [dbo].[HR_Cmp_SalaryGenerationDate] (
    [GenerationId] int IDENTITY(1,1) NOT NULL,
    [CompanyID] bigint  NOT NULL,
    [GenerationDay] smallint  NOT NULL
);
GO

-- Creating table 'HR_CMP_Stations'
CREATE TABLE [dbo].[HR_CMP_Stations] (
    [StationID] int IDENTITY(1,1) NOT NULL,
    [CompanyID] nvarchar(max)  NOT NULL,
    [StationName] nvarchar(max)  NOT NULL,
    [StationTypeID] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_CMP_WorkShifts'
CREATE TABLE [dbo].[HR_CMP_WorkShifts] (
    [WorkShiftID] int IDENTITY(1,1) NOT NULL,
    [Weekdays] nvarchar(max)  NOT NULL,
    [Weekends] nvarchar(max)  NOT NULL,
    [ShiftName] nvarchar(max)  NOT NULL,
    [WorkingHoursFrom] nvarchar(max)  NOT NULL,
    [LunchBreakHoursFrom] nvarchar(max)  NOT NULL,
    [WorkingHoursTo] nvarchar(max)  NOT NULL,
    [LunchBreakHoursTo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Company'
CREATE TABLE [dbo].[HR_Company] (
    [CompanyID] bigint IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(30)  NOT NULL,
    [OrganizationCode] nvarchar(10)  NULL,
    [WebsiteUrl] nvarchar(300)  NULL,
    [OrganizationLogoPath] nvarchar(100)  NOT NULL,
    [NumberOfEmployees] int  NULL,
    [RegisteredEmailAddress] nvarchar(100)  NOT NULL,
    [CompanyDescription] nvarchar(1000)  NOT NULL,
    [IsGovermentSector] bit  NULL,
    [IndustryTypeID] int  NULL
);
GO

-- Creating table 'HR_CompanyAssets'
CREATE TABLE [dbo].[HR_CompanyAssets] (
    [AssetID] int IDENTITY(1,1) NOT NULL,
    [PropertyTypeID] int  NOT NULL,
    [ModelNumber] nvarchar(50)  NOT NULL,
    [CompanyID] bigint  NULL
);
GO

-- Creating table 'HR_Emp_ActualAnnualTaxExemptionDetails'
CREATE TABLE [dbo].[HR_Emp_ActualAnnualTaxExemptionDetails] (
    [ActualTaxExemptionID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [ProffessionalTax] decimal(18,0)  NOT NULL,
    [ProvidentFund] decimal(18,0)  NOT NULL,
    [VoluntaryPF] decimal(18,0)  NOT NULL,
    [IncomeTax] decimal(18,0)  NOT NULL,
    [LifeInsurance] decimal(18,0)  NOT NULL,
    [OtherDeduction1] decimal(18,0)  NOT NULL,
    [OtherDeduction2] decimal(18,0)  NOT NULL,
    [OtherDeduction3] decimal(18,0)  NOT NULL,
    [OtherDeduction4] decimal(18,0)  NOT NULL,
    [OtherDeduction5] decimal(18,0)  NOT NULL,
    [OtherDeduction6] decimal(18,0)  NOT NULL,
    [OtherDeduction7] decimal(18,0)  NOT NULL,
    [OtherDeduction8] decimal(18,0)  NOT NULL,
    [OtherDeduction9] decimal(18,0)  NOT NULL,
    [OD1Description] nvarchar(max)  NULL,
    [OD2Description] nvarchar(max)  NULL,
    [OD3Description] nvarchar(max)  NULL,
    [OD4Description] nvarchar(max)  NULL,
    [OD5Description] nvarchar(max)  NULL,
    [OD6Description] nvarchar(max)  NULL,
    [OD7Description] nvarchar(max)  NULL,
    [OD8Description] nvarchar(max)  NULL,
    [OD9Description] nvarchar(max)  NULL,
    [Year] int  NOT NULL,
    [LastUpdateDate] datetime  NULL
);
GO

-- Creating table 'HR_Emp_ActualExemptions'
CREATE TABLE [dbo].[HR_Emp_ActualExemptions] (
    [MiscExemptionID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [ExemptionRuleID] int  NOT NULL,
    [ExemptionAmount] decimal(18,0)  NOT NULL,
    [ActualTaxExemptionID] int  NOT NULL
);
GO

-- Creating table 'HR_Emp_AnnualSalaryDetails'
CREATE TABLE [dbo].[HR_Emp_AnnualSalaryDetails] (
    [AnnualSalaryID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [SalaryGradeCode] int  NULL,
    [AnnualBasic] decimal(18,0)  NOT NULL,
    [AnnualHouseRent] decimal(18,0)  NOT NULL,
    [AnnualMedicalReimbursment] decimal(18,0)  NOT NULL,
    [AnnualLTAReimbursment] decimal(18,0)  NOT NULL,
    [AnnualFuelReimbursment] decimal(18,0)  NOT NULL,
    [AnnualProfessionalDevelopment] decimal(18,0)  NOT NULL,
    [Misc1] decimal(18,0)  NULL,
    [Misc2] decimal(18,0)  NULL,
    [Misc3] decimal(18,0)  NULL,
    [Misc4] decimal(18,0)  NULL,
    [Misc5] decimal(18,0)  NULL,
    [Misc6] decimal(18,0)  NULL,
    [Misc7] decimal(18,0)  NULL,
    [Misc8] decimal(18,0)  NULL,
    [Misc9] decimal(18,0)  NULL,
    [Misc1Description] nvarchar(max)  NULL,
    [Misc2Description] nvarchar(max)  NULL,
    [Misc3Description] nvarchar(max)  NULL,
    [Misc4Description] nvarchar(max)  NULL,
    [Misc5Description] nvarchar(max)  NULL,
    [Misc6Description] nvarchar(max)  NULL,
    [Misc7Description] nvarchar(max)  NULL,
    [Misc8Description] nvarchar(max)  NULL,
    [Misc9Description] nvarchar(max)  NULL,
    [AnnualGrossSalary] decimal(18,0)  NOT NULL,
    [AnnualNetSalary] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'HR_Emp_AnnualTaxDeductionDetails'
CREATE TABLE [dbo].[HR_Emp_AnnualTaxDeductionDetails] (
    [AnnualTaxDeductionID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [ProffessionalTax] decimal(18,0)  NOT NULL,
    [ProvidentFund] decimal(18,0)  NOT NULL,
    [VoluntaryPF] decimal(18,0)  NOT NULL,
    [IncomeTax] decimal(18,0)  NOT NULL,
    [LifeInsurance] decimal(18,0)  NOT NULL,
    [OtherDeduction1] decimal(18,0)  NOT NULL,
    [OtherDeduction2] decimal(18,0)  NOT NULL,
    [OtherDeduction3] decimal(18,0)  NOT NULL,
    [OtherDeduction4] decimal(18,0)  NOT NULL,
    [OtherDeduction5] decimal(18,0)  NOT NULL,
    [OtherDeduction6] decimal(18,0)  NOT NULL,
    [OtherDeduction7] decimal(18,0)  NOT NULL,
    [OtherDeduction8] decimal(18,0)  NOT NULL,
    [OtherDeduction9] decimal(18,0)  NOT NULL,
    [OD1Description] nvarchar(max)  NULL,
    [OD2Description] nvarchar(max)  NULL,
    [OD3Description] nvarchar(max)  NULL,
    [OD4Description] nvarchar(max)  NULL,
    [OD5Description] nvarchar(max)  NULL,
    [OD6Description] nvarchar(max)  NULL,
    [OD7Description] nvarchar(max)  NULL,
    [OD8Description] nvarchar(max)  NULL,
    [OD9Description] nvarchar(max)  NULL
);
GO

-- Creating table 'HR_Emp_AS_EducationDocs'
CREATE TABLE [dbo].[HR_Emp_AS_EducationDocs] (
    [AssociateDocID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [EducationDocID] int  NOT NULL
);
GO

-- Creating table 'HR_Emp_AS_EmployeeInProbation'
CREATE TABLE [dbo].[HR_Emp_AS_EmployeeInProbation] (
    [ProbationID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NULL,
    [ProbationStartDate] datetime  NOT NULL,
    [ProbationEndDate] datetime  NOT NULL
);
GO

-- Creating table 'HR_Emp_BankAccountDetails'
CREATE TABLE [dbo].[HR_Emp_BankAccountDetails] (
    [EmployeeNumber] bigint  NOT NULL,
    [BankID] int  NULL,
    [AccountNumber] int  NOT NULL,
    [IsSalaryAccount] bit  NULL,
    [IsSalaryCreditAccount] bit  NULL,
    [BankAccountTypeID] int  NOT NULL
);
GO

-- Creating table 'HR_Emp_ContactDetails'
CREATE TABLE [dbo].[HR_Emp_ContactDetails] (
    [ContactID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [MobileNumber] nvarchar(20)  NULL,
    [TelNumber] nvarchar(30)  NULL,
    [IsPrimaryMobile] bit  NULL,
    [IsEmergencyContact] bit  NULL,
    [WorkTelephone] nvarchar(30)  NULL,
    [EmpOtherEmail] nvarchar(max)  NOT NULL,
    [WorkEmailAddress] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Emp_EducationDetails'
CREATE TABLE [dbo].[HR_Emp_EducationDetails] (
    [EmployeeNumber] bigint  NOT NULL,
    [EducationID] nvarchar(max)  NOT NULL,
    [SchoolName] nvarchar(50)  NULL,
    [UniversityName] nvarchar(50)  NULL,
    [CollegeName] nvarchar(50)  NULL,
    [StartDate] nvarchar(max)  NOT NULL,
    [EndDate] nvarchar(max)  NOT NULL,
    [EduSeqNo] smallint  NOT NULL,
    [PassPercentage] decimal(18,0)  NULL,
    [PassGrade] nchar(2)  NULL,
    [DiplomaID] int  NULL,
    [EducationDetailID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'HR_Emp_EducationDocs'
CREATE TABLE [dbo].[HR_Emp_EducationDocs] (
    [EducationDocID] int IDENTITY(1,1) NOT NULL,
    [CertificatePath] nvarchar(max)  NOT NULL,
    [MarkSheetPath] nvarchar(max)  NOT NULL,
    [DiplomaCertificatePath] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Emp_EmergenceContact'
CREATE TABLE [dbo].[HR_Emp_EmergenceContact] (
    [EmergencyContactID] int IDENTITY(1,1) NOT NULL,
    [FamilyMemberID] int  NULL,
    [Name] nvarchar(max)  NOT NULL,
    [RelationID] int  NOT NULL,
    [EmployeeNumber] bigint  NOT NULL
);
GO

-- Creating table 'HR_Emp_EstimateAnnualTaxExemptionDetails'
CREATE TABLE [dbo].[HR_Emp_EstimateAnnualTaxExemptionDetails] (
    [EstimateTaxExemptionID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [ProffessionalTax] decimal(18,0)  NOT NULL,
    [ProvidentFund] decimal(18,0)  NOT NULL,
    [VoluntaryPF] decimal(18,0)  NOT NULL,
    [IncomeTax] decimal(18,0)  NOT NULL,
    [LifeInsurance] decimal(18,0)  NOT NULL,
    [OtherDeduction1] decimal(18,0)  NOT NULL,
    [OtherDeduction2] decimal(18,0)  NOT NULL,
    [OtherDeduction3] decimal(18,0)  NOT NULL,
    [OtherDeduction4] decimal(18,0)  NOT NULL,
    [OtherDeduction5] decimal(18,0)  NOT NULL,
    [OtherDeduction6] decimal(18,0)  NOT NULL,
    [OtherDeduction7] decimal(18,0)  NOT NULL,
    [OtherDeduction8] decimal(18,0)  NOT NULL,
    [OtherDeduction9] decimal(18,0)  NOT NULL,
    [OD1Description] nvarchar(max)  NULL,
    [OD2Description] nvarchar(max)  NULL,
    [OD3Description] nvarchar(max)  NULL,
    [OD4Description] nvarchar(max)  NULL,
    [OD5Description] nvarchar(max)  NULL,
    [OD6Description] nvarchar(max)  NULL,
    [OD7Description] nvarchar(max)  NULL,
    [OD8Description] nvarchar(max)  NULL,
    [OD9Description] nvarchar(max)  NULL,
    [Year] int  NOT NULL,
    [LastUpdateDate] datetime  NULL
);
GO

-- Creating table 'HR_Emp_EstimateExemptions'
CREATE TABLE [dbo].[HR_Emp_EstimateExemptions] (
    [EstimateExemptionID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [ExemptionRuleID] int  NOT NULL,
    [ExemptionAmount] decimal(18,0)  NOT NULL,
    [EstimateTaxExemptionID] int  NOT NULL
);
GO

-- Creating table 'HR_Emp_ExemptionDocuments'
CREATE TABLE [dbo].[HR_Emp_ExemptionDocuments] (
    [DocumentID] int IDENTITY(1,1) NOT NULL,
    [MiscExemptionID] int  NOT NULL,
    [DocumentName] nvarchar(max)  NOT NULL,
    [DocumentPath] nvarchar(max)  NOT NULL,
    [UploadDate] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Emp_FamilyMembers'
CREATE TABLE [dbo].[HR_Emp_FamilyMembers] (
    [FamilyMemberID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Age] nvarchar(max)  NOT NULL,
    [RelationID] int  NOT NULL,
    [Gender] nvarchar(1)  NOT NULL,
    [IsMinor] bit  NULL,
    [IsDependent] bit  NULL,
    [IsNominee] nvarchar(max)  NOT NULL,
    [ResidesWithEmployee] bit  NULL,
    [EmployeeNumber] bigint  NULL,
    [ContactPersonInEmergency] bit  NOT NULL,
    [EligibleForInsurance] bit  NULL
);
GO

-- Creating table 'HR_Emp_Inbox'
CREATE TABLE [dbo].[HR_Emp_Inbox] (
    [InboxID] int IDENTITY(1,1) NOT NULL,
    [MessageToEmployeeNumber] bigint  NOT NULL,
    [MessageID] int  NOT NULL
);
GO

-- Creating table 'HR_Emp_InsuranceDetails'
CREATE TABLE [dbo].[HR_Emp_InsuranceDetails] (
    [InsuredID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] nvarchar(max)  NULL,
    [InsurancePolicyID] int  NULL
);
GO

-- Creating table 'HR_EMP_Leave_Hist'
CREATE TABLE [dbo].[HR_EMP_Leave_Hist] (
    [LeaveHistId] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [StartDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [Year] int  NULL,
    [LeaveRequestID] int  NULL
);
GO

-- Creating table 'HR_Emp_LeaveApprovalMessage'
CREATE TABLE [dbo].[HR_Emp_LeaveApprovalMessage] (
    [MessageID] int IDENTITY(1,1) NOT NULL,
    [LeaveRequestID] nvarchar(max)  NOT NULL,
    [RequestToEMPNumber] nvarchar(max)  NOT NULL,
    [ApprovalStatusID] nvarchar(10)  NOT NULL,
    [ApprovedReason] nvarchar(1000)  NOT NULL,
    [DeniedReason] nvarchar(1000)  NOT NULL
);
GO

-- Creating table 'HR_EMP_LeaveQoutaDetails'
CREATE TABLE [dbo].[HR_EMP_LeaveQoutaDetails] (
    [LeaveQoutaDetailID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NULL,
    [LeaveTypeID] int  NOT NULL,
    [AvaiableLeaves] int  NOT NULL,
    [LeaveTaken] int  NOT NULL,
    [TotalLeaves] int  NOT NULL,
    [Year] nvarchar(max)  NOT NULL,
    [PreviousYearsLeave] int  NULL,
    [Month] int  NOT NULL
);
GO

-- Creating table 'HR_Emp_LeaveRequest'
CREATE TABLE [dbo].[HR_Emp_LeaveRequest] (
    [LeaveRequestID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NULL,
    [LeaveID] int  NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [TotalNoLeavesRequested] int  NOT NULL,
    [ApprovalStatusID] nvarchar(10)  NULL,
    [IsActive] bit  NULL
);
GO

-- Creating table 'HR_Emp_MonthlySalaryDeductionDetails'
CREATE TABLE [dbo].[HR_Emp_MonthlySalaryDeductionDetails] (
    [MonthlyDeductionID] int IDENTITY(1,1) NOT NULL,
    [MonthlySalaryID] int  NULL,
    [ProffessionalTax] decimal(18,0)  NOT NULL,
    [ProvidentFund] decimal(18,0)  NOT NULL,
    [VoluntaryPF] decimal(18,0)  NOT NULL,
    [IncomeTax] decimal(18,0)  NOT NULL,
    [LifeInsurance] decimal(18,0)  NOT NULL,
    [OtherDeduction1] decimal(18,0)  NOT NULL,
    [OtherDeduction2] decimal(18,0)  NOT NULL,
    [OtherDeduction3] decimal(18,0)  NOT NULL,
    [OtherDeduction4] decimal(18,0)  NOT NULL,
    [OtherDeduction5] decimal(18,0)  NOT NULL,
    [OtherDeduction6] decimal(18,0)  NOT NULL,
    [OtherDeduction7] decimal(18,0)  NOT NULL,
    [OtherDeduction8] decimal(18,0)  NOT NULL,
    [OtherDeduction9] decimal(18,0)  NOT NULL,
    [OD1Description] nvarchar(max)  NULL,
    [OD2Description] nvarchar(max)  NULL,
    [OD3Description] nvarchar(max)  NULL,
    [OD4Description] nvarchar(max)  NULL,
    [OD5Description] nvarchar(max)  NULL,
    [OD6Description] nvarchar(max)  NULL,
    [OD7Description] nvarchar(max)  NULL,
    [OD8Description] nvarchar(max)  NULL,
    [OD9Description] nvarchar(max)  NULL
);
GO

-- Creating table 'HR_Emp_MonthlySalaryDetails'
CREATE TABLE [dbo].[HR_Emp_MonthlySalaryDetails] (
    [MonthlySalaryID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [SalaryGradeCode] int  NULL,
    [Basic] decimal(18,0)  NOT NULL,
    [HouseRent] decimal(18,0)  NOT NULL,
    [MedicalReimbursment] decimal(18,0)  NOT NULL,
    [LTAReimbursment] decimal(18,0)  NOT NULL,
    [FuelReimbursment] decimal(18,0)  NOT NULL,
    [ProfessionalDevelopment] decimal(18,0)  NOT NULL,
    [Misc1] decimal(18,0)  NULL,
    [Misc2] decimal(18,0)  NULL,
    [Misc3] decimal(18,0)  NULL,
    [Misc4] decimal(18,0)  NULL,
    [Misc5] decimal(18,0)  NULL,
    [Misc6] decimal(18,0)  NULL,
    [Misc7] decimal(18,0)  NULL,
    [Misc8] decimal(18,0)  NULL,
    [Misc9] decimal(18,0)  NULL,
    [Misc1Description] nvarchar(max)  NULL,
    [Misc2Description] nvarchar(max)  NULL,
    [Misc3Description] nvarchar(max)  NULL,
    [Misc4Description] nvarchar(max)  NULL,
    [Misc5Description] nvarchar(max)  NULL,
    [Misc6Description] nvarchar(max)  NULL,
    [Misc7Description] nvarchar(max)  NULL,
    [Misc8Description] nvarchar(max)  NULL,
    [Misc9Description] nvarchar(max)  NULL,
    [Month] smallint  NOT NULL,
    [Year] int  NOT NULL,
    [CreationDate] nvarchar(max)  NOT NULL,
    [GrossSalary] decimal(18,0)  NOT NULL,
    [NetSalary] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'HR_Emp_Passport'
CREATE TABLE [dbo].[HR_Emp_Passport] (
    [EmployeeNumber] bigint  NOT NULL,
    [PassportNumber] nvarchar(20)  NOT NULL,
    [IssuedDate] datetime  NULL,
    [ExpireDate] datetime  NULL,
    [CountryCode] nvarchar(3)  NOT NULL
);
GO

-- Creating table 'HR_Emp_PreviousEmploymentDetails'
CREATE TABLE [dbo].[HR_Emp_PreviousEmploymentDetails] (
    [EmploymentDetailID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [EmployeeSeqNumber] smallint  NOT NULL,
    [EmployerName] nvarchar(50)  NOT NULL,
    [JobTitle] nvarchar(50)  NOT NULL,
    [FromDate] datetime  NOT NULL,
    [ToDate] datetime  NOT NULL,
    [CTC] decimal(18,0)  NOT NULL,
    [JobDescription] nvarchar(1000)  NOT NULL
);
GO

-- Creating table 'HR_Emp_Property'
CREATE TABLE [dbo].[HR_Emp_Property] (
    [AssetID] int  NOT NULL,
    [EmployeeNumber] bigint  NULL
);
GO

-- Creating table 'HR_Emp_ProvidentFundDetails'
CREATE TABLE [dbo].[HR_Emp_ProvidentFundDetails] (
    [ProvidentFundID] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NULL,
    [PFNumber] nvarchar(30)  NOT NULL,
    [TotalPFAmount] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'HR_Emp_RelatedDocs'
CREATE TABLE [dbo].[HR_Emp_RelatedDocs] (
    [EmployeeNumber] int  NOT NULL,
    [PicPath] nvarchar(max)  NOT NULL,
    [ResumePath] nvarchar(max)  NOT NULL,
    [PicName] nvarchar(max)  NOT NULL,
    [ResumeName] nvarchar(max)  NOT NULL,
    [ResumeHeadLine] nvarchar(max)  NOT NULL,
    [LastUpdateDate] datetime  NOT NULL,
    [LicensePicPath] nvarchar(max)  NOT NULL,
    [EmployeeFolderName] nvarchar(max)  NOT NULL,
    [PanCarPicPath] nvarchar(max)  NOT NULL,
    [PassportPicPath] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Emp_RelatedDocs_Hist'
CREATE TABLE [dbo].[HR_Emp_RelatedDocs_Hist] (
    [EmployeeNumber] bigint IDENTITY(1,1) NOT NULL,
    [PicPath] nvarchar(max)  NOT NULL,
    [ResumePath] nvarchar(max)  NOT NULL,
    [ResumeName] nvarchar(max)  NOT NULL,
    [ResumeHeaderLine] nvarchar(max)  NOT NULL,
    [PicName] nvarchar(max)  NOT NULL,
    [LastUsedDate] datetime  NOT NULL
);
GO

-- Creating table 'HR_Emp_ReportingDetails'
CREATE TABLE [dbo].[HR_Emp_ReportingDetails] (
    [EmployeeManagerId] int IDENTITY(1,1) NOT NULL,
    [EmployeeNumber] bigint  NULL
);
GO

-- Creating table 'HR_Emp_ReviewDetails'
CREATE TABLE [dbo].[HR_Emp_ReviewDetails] (
    [ReviewID] int IDENTITY(1,1) NOT NULL,
    [ReviewerID] bigint  NULL,
    [EmployeeNumber] bigint  NULL,
    [ReviewStartDate] datetime  NOT NULL,
    [ReviewEndDate] datetime  NOT NULL,
    [DateOfReview] datetime  NOT NULL,
    [DocPath] nvarchar(max)  NOT NULL,
    [RatingTypeID] int  NULL,
    [Year] int  NOT NULL
);
GO

-- Creating table 'HR_Emp_SentMessages'
CREATE TABLE [dbo].[HR_Emp_SentMessages] (
    [SentMessageID] int IDENTITY(1,1) NOT NULL,
    [MessageToEmployeeNumber] nvarchar(max)  NOT NULL,
    [MessageID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Emp_Skills'
CREATE TABLE [dbo].[HR_Emp_Skills] (
    [EmployeeNumber] bigint  NOT NULL,
    [SkillID] int  NOT NULL,
    [ExperienceInMonths] int  NULL,
    [ExperienceInYears] int  NULL,
    [TotalExperience] int  NULL,
    [HR_LKP_Skill_SkillID] int  NOT NULL
);
GO

-- Creating table 'HR_Emp_SmartGoals'
CREATE TABLE [dbo].[HR_Emp_SmartGoals] (
    [SmartGoalID] int IDENTITY(1,1) NOT NULL,
    [CompanyID] bigint  NULL,
    [EmployeeNumber] bigint  NULL,
    [GoalHeadLine] nvarchar(max)  NOT NULL,
    [GoalDescription] nvarchar(max)  NOT NULL,
    [Year] nvarchar(max)  NOT NULL,
    [DocPath] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Emp_UserGroup'
CREATE TABLE [dbo].[HR_Emp_UserGroup] (
    [UserGroupID] int IDENTITY(1,1) NOT NULL,
    [GroupName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Emp_Users'
CREATE TABLE [dbo].[HR_Emp_Users] (
    [UserGuid] uniqueidentifier  NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [HashKey] nvarchar(max)  NOT NULL,
    [IsAdmin] bit  NULL,
    [EmployeeNumber] bigint  NOT NULL,
    [ReceiveNotification] bit  NULL,
    [DateEntered] datetime  NOT NULL,
    [CreatedBy] nvarchar(max)  NOT NULL,
    [ModifiedUserID] nvarchar(max)  NOT NULL,
    [UserGroupID] int  NULL,
    [IsActive] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Employee'
CREATE TABLE [dbo].[HR_Employee] (
    [CompanyID] bigint  NOT NULL,
    [EmployeeUID] uniqueidentifier  NOT NULL,
    [EmployeeNumber] bigint IDENTITY(1,1) NOT NULL,
    [CompanyEmployeeID] nvarchar(max)  NOT NULL,
    [Lastname] nvarchar(max)  NOT NULL,
    [Firstname] nvarchar(max)  NOT NULL,
    [Middlename] nvarchar(max)  NOT NULL,
    [Birthday] datetime  NULL,
    [NationCode] nvarchar(max)  NULL,
    [Gender] smallint  NULL,
    [MaritalStatus] nvarchar(max)  NULL,
    [SSNNumber] nvarchar(max)  NULL,
    [LicenseNumber] nvarchar(max)  NULL,
    [LicencseExpiryDate] datetime  NULL,
    [Status] nvarchar(max)  NULL,
    [TitleCode] int  NOT NULL,
    [SalaryGradeCode] int  NOT NULL,
    [JoinedDate] datetime  NOT NULL,
    [TerminateDate] datetime  NULL,
    [TerminationReason] nvarchar(max)  NULL,
    [IsActive] nvarchar(max)  NOT NULL,
    [BloodGroup] nvarchar(2)  NOT NULL,
    [Nationality] nvarchar(max)  NOT NULL,
    [DepartmentID] int  NULL,
    [JobID] int  NULL,
    [InProbation] bit  NULL,
    [EligibleForInsurance] bit  NULL
);
GO

-- Creating table 'HR_GBL_LKP_ApprovalStatus'
CREATE TABLE [dbo].[HR_GBL_LKP_ApprovalStatus] (
    [ApprovalStatusID] int IDENTITY(1,1) NOT NULL,
    [Status] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'HR_GBL_LKP_IndustryType'
CREATE TABLE [dbo].[HR_GBL_LKP_IndustryType] (
    [IndustryTypeID] int IDENTITY(1,1) NOT NULL,
    [IndustryType] nvarchar(max)  NOT NULL,
    [Domain] nvarchar(max)  NOT NULL,
    [NatureOfBusiness] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_GBL_TaxRules'
CREATE TABLE [dbo].[HR_GBL_TaxRules] (
    [TaxRuleID] int IDENTITY(1,1) NOT NULL,
    [RuleName] nvarchar(max)  NOT NULL,
    [RuleDescription] nvarchar(max)  NOT NULL,
    [RuleValue] nvarchar(max)  NOT NULL,
    [CompanyID] bigint  NULL
);
GO

-- Creating table 'HR_GLB_LKP_Banks'
CREATE TABLE [dbo].[HR_GLB_LKP_Banks] (
    [BankID] int IDENTITY(1,1) NOT NULL,
    [BankName] nvarchar(max)  NOT NULL,
    [BankAddressID] int  NOT NULL,
    [IsNationalBank] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_GLB_LKP_NameTitle'
CREATE TABLE [dbo].[HR_GLB_LKP_NameTitle] (
    [TitleCode] int IDENTITY(1,1) NOT NULL,
    [TitleName] nvarchar(5)  NOT NULL
);
GO

-- Creating table 'HR_GLB_LKP_RelationType'
CREATE TABLE [dbo].[HR_GLB_LKP_RelationType] (
    [RelationID] int IDENTITY(1,1) NOT NULL,
    [RelationName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_LK_Currency'
CREATE TABLE [dbo].[HR_LK_Currency] (
    [CurrencyID] int IDENTITY(1,1) NOT NULL,
    [CurrencyName] nvarchar(20)  NOT NULL,
    [CurrencyCode] nvarchar(5)  NOT NULL
);
GO

-- Creating table 'HR_LKP_AddressType'
CREATE TABLE [dbo].[HR_LKP_AddressType] (
    [AddressTypeID] int IDENTITY(1,1) NOT NULL,
    [CompanyID] bigint  NOT NULL,
    [AddressType] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'HR_LKP_BankAccountTypes'
CREATE TABLE [dbo].[HR_LKP_BankAccountTypes] (
    [BankTypeID] int IDENTITY(1,1) NOT NULL,
    [BankAccountType] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_LKP_Country'
CREATE TABLE [dbo].[HR_LKP_Country] (
    [CountryCode] nvarchar(3)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ISOCode] nvarchar(max)  NOT NULL,
    [CurrencyID] int  NOT NULL
);
GO

-- Creating table 'HR_LKP_Departments'
CREATE TABLE [dbo].[HR_LKP_Departments] (
    [DepartmentID] int IDENTITY(1,1) NOT NULL,
    [DepartmentName] nvarchar(max)  NOT NULL,
    [DepartmentRole] nvarchar(max)  NOT NULL,
    [DepartmentDescription] nvarchar(max)  NOT NULL,
    [CompanyID] bigint  NULL
);
GO

-- Creating table 'HR_LKP_DiplomaDetails'
CREATE TABLE [dbo].[HR_LKP_DiplomaDetails] (
    [DiplomaID] int IDENTITY(1,1) NOT NULL,
    [InstituteName] nvarchar(max)  NOT NULL,
    [CourseName] nvarchar(max)  NOT NULL,
    [PassGrade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_LKP_EductionType'
CREATE TABLE [dbo].[HR_LKP_EductionType] (
    [EducationID] int IDENTITY(1,1) NOT NULL,
    [EducationShortCode] nvarchar(max)  NOT NULL,
    [EducationFullName] nvarchar(max)  NOT NULL,
    [EducationDescription] nvarchar(max)  NULL
);
GO

-- Creating table 'HR_LKP_JobTitle'
CREATE TABLE [dbo].[HR_LKP_JobTitle] (
    [JobID] int IDENTITY(1,1) NOT NULL,
    [JobTitle] nvarchar(max)  NOT NULL,
    [CompanyID] bigint  NULL,
    [JobRole] nvarchar(max)  NOT NULL,
    [JobDescription] nvarchar(max)  NOT NULL,
    [DepartmentID] int  NULL,
    [IsActive] bit  NULL,
    [SalaryGradeCode] int  NOT NULL
);
GO

-- Creating table 'HR_LKP_PropertyTypeID'
CREATE TABLE [dbo].[HR_LKP_PropertyTypeID] (
    [PropertyTypeID] int IDENTITY(1,1) NOT NULL,
    [CompanyID] bigint  NOT NULL,
    [PropertyType] nvarchar(max)  NOT NULL,
    [PropertyName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_LKP_SalaryGradeDetails'
CREATE TABLE [dbo].[HR_LKP_SalaryGradeDetails] (
    [SalaryDetailID] int IDENTITY(1,1) NOT NULL,
    [SalaryGradeCode] int  NOT NULL,
    [CompanyID] nvarchar(max)  NOT NULL,
    [MinCTC] decimal(18,0)  NOT NULL,
    [MaxCTC] decimal(18,0)  NOT NULL,
    [MinExperience] int  NOT NULL,
    [MaxExperience] int  NOT NULL,
    [CurrencyID] int  NULL
);
GO

-- Creating table 'HR_LKP_SalaryGrades'
CREATE TABLE [dbo].[HR_LKP_SalaryGrades] (
    [SalaryGradeCode] int IDENTITY(1,1) NOT NULL,
    [SalaryGrade] nvarchar(max)  NOT NULL,
    [CompanyID] bigint  NOT NULL,
    [CurrencyID] int  NULL
);
GO

-- Creating table 'HR_LKP_Skill'
CREATE TABLE [dbo].[HR_LKP_Skill] (
    [SkillID] int IDENTITY(1,1) NOT NULL,
    [SkillName] nvarchar(max)  NOT NULL,
    [SkillDescritpion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Locations'
CREATE TABLE [dbo].[HR_Locations] (
    [LocationID] int IDENTITY(1,1) NOT NULL,
    [CountryCode] nvarchar(3)  NOT NULL,
    [State] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [ZipCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HR_Log'
CREATE TABLE [dbo].[HR_Log] (
    [LogID] bigint IDENTITY(1,1) NOT NULL,
    [Level] nvarchar(10)  NULL,
    [Host] nvarchar(30)  NULL,
    [Type] nvarchar(100)  NULL,
    [Source] nvarchar(100)  NULL,
    [Logger] nvarchar(30)  NULL,
    [Message] nvarchar(max)  NULL,
    [Date] datetime  NULL,
    [StackTrace] nvarchar(max)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AddressID] in table 'HR_Address'
ALTER TABLE [dbo].[HR_Address]
ADD CONSTRAINT [PK_HR_Address]
    PRIMARY KEY CLUSTERED ([AddressID] ASC);
GO

-- Creating primary key on [CompanyID] in table 'HR_CMP_AccountsWithBanks'
ALTER TABLE [dbo].[HR_CMP_AccountsWithBanks]
ADD CONSTRAINT [PK_HR_CMP_AccountsWithBanks]
    PRIMARY KEY CLUSTERED ([CompanyID] ASC);
GO

-- Creating primary key on [PolicyID] in table 'HR_CMP_AS_PolicyAppliedTo'
ALTER TABLE [dbo].[HR_CMP_AS_PolicyAppliedTo]
ADD CONSTRAINT [PK_HR_CMP_AS_PolicyAppliedTo]
    PRIMARY KEY CLUSTERED ([PolicyID] ASC);
GO

-- Creating primary key on [CompanyID] in table 'HR_CMP_AS_WorkShifts'
ALTER TABLE [dbo].[HR_CMP_AS_WorkShifts]
ADD CONSTRAINT [PK_HR_CMP_AS_WorkShifts]
    PRIMARY KEY CLUSTERED ([CompanyID] ASC);
GO

-- Creating primary key on [ExemptionRuleID] in table 'HR_CMP_ExemptionRules'
ALTER TABLE [dbo].[HR_CMP_ExemptionRules]
ADD CONSTRAINT [PK_HR_CMP_ExemptionRules]
    PRIMARY KEY CLUSTERED ([ExemptionRuleID] ASC);
GO

-- Creating primary key on [ExemptionTypeId] in table 'HR_CMP_ExemptionsType'
ALTER TABLE [dbo].[HR_CMP_ExemptionsType]
ADD CONSTRAINT [PK_HR_CMP_ExemptionsType]
    PRIMARY KEY CLUSTERED ([ExemptionTypeId] ASC);
GO

-- Creating primary key on [InsurancePolicyID] in table 'HR_CMP_InsurancePolicy'
ALTER TABLE [dbo].[HR_CMP_InsurancePolicy]
ADD CONSTRAINT [PK_HR_CMP_InsurancePolicy]
    PRIMARY KEY CLUSTERED ([InsurancePolicyID] ASC);
GO

-- Creating primary key on [HolidayID] in table 'HR_CMP_LKP_Holidays'
ALTER TABLE [dbo].[HR_CMP_LKP_Holidays]
ADD CONSTRAINT [PK_HR_CMP_LKP_Holidays]
    PRIMARY KEY CLUSTERED ([HolidayID] ASC);
GO

-- Creating primary key on [InusranceCompanyID] in table 'HR_CMP_LKP_InsuranceCompanyDetail'
ALTER TABLE [dbo].[HR_CMP_LKP_InsuranceCompanyDetail]
ADD CONSTRAINT [PK_HR_CMP_LKP_InsuranceCompanyDetail]
    PRIMARY KEY CLUSTERED ([InusranceCompanyID] ASC);
GO

-- Creating primary key on [LeaveQuotaID] in table 'HR_CMP_LKP_LeaveQouta'
ALTER TABLE [dbo].[HR_CMP_LKP_LeaveQouta]
ADD CONSTRAINT [PK_HR_CMP_LKP_LeaveQouta]
    PRIMARY KEY CLUSTERED ([LeaveQuotaID] ASC);
GO

-- Creating primary key on [LeaveID] in table 'HR_CMP_LKP_Leaves'
ALTER TABLE [dbo].[HR_CMP_LKP_Leaves]
ADD CONSTRAINT [PK_HR_CMP_LKP_Leaves]
    PRIMARY KEY CLUSTERED ([LeaveID] ASC);
GO

-- Creating primary key on [LeaveTypeID] in table 'HR_CMP_LKP_LeaveTypes'
ALTER TABLE [dbo].[HR_CMP_LKP_LeaveTypes]
ADD CONSTRAINT [PK_HR_CMP_LKP_LeaveTypes]
    PRIMARY KEY CLUSTERED ([LeaveTypeID] ASC);
GO

-- Creating primary key on [ProbationPeriodID] in table 'HR_CMP_LKP_ProbationPeriod'
ALTER TABLE [dbo].[HR_CMP_LKP_ProbationPeriod]
ADD CONSTRAINT [PK_HR_CMP_LKP_ProbationPeriod]
    PRIMARY KEY CLUSTERED ([ProbationPeriodID] ASC);
GO

-- Creating primary key on [StationTypeID] in table 'HR_CMP_LKP_StationType'
ALTER TABLE [dbo].[HR_CMP_LKP_StationType]
ADD CONSTRAINT [PK_HR_CMP_LKP_StationType]
    PRIMARY KEY CLUSTERED ([StationTypeID] ASC);
GO

-- Creating primary key on [MessageID] in table 'HR_CMP_Messages'
ALTER TABLE [dbo].[HR_CMP_Messages]
ADD CONSTRAINT [PK_HR_CMP_Messages]
    PRIMARY KEY CLUSTERED ([MessageID] ASC);
GO

-- Creating primary key on [RatingTypeID] in table 'HR_Cmp_PerformanceRatingType'
ALTER TABLE [dbo].[HR_Cmp_PerformanceRatingType]
ADD CONSTRAINT [PK_HR_Cmp_PerformanceRatingType]
    PRIMARY KEY CLUSTERED ([RatingTypeID] ASC);
GO

-- Creating primary key on [PolicyID] in table 'HR_CMP_Policies'
ALTER TABLE [dbo].[HR_CMP_Policies]
ADD CONSTRAINT [PK_HR_CMP_Policies]
    PRIMARY KEY CLUSTERED ([PolicyID] ASC);
GO

-- Creating primary key on [GenerationId] in table 'HR_Cmp_SalaryGenerationDate'
ALTER TABLE [dbo].[HR_Cmp_SalaryGenerationDate]
ADD CONSTRAINT [PK_HR_Cmp_SalaryGenerationDate]
    PRIMARY KEY CLUSTERED ([GenerationId] ASC);
GO

-- Creating primary key on [StationID] in table 'HR_CMP_Stations'
ALTER TABLE [dbo].[HR_CMP_Stations]
ADD CONSTRAINT [PK_HR_CMP_Stations]
    PRIMARY KEY CLUSTERED ([StationID] ASC);
GO

-- Creating primary key on [WorkShiftID] in table 'HR_CMP_WorkShifts'
ALTER TABLE [dbo].[HR_CMP_WorkShifts]
ADD CONSTRAINT [PK_HR_CMP_WorkShifts]
    PRIMARY KEY CLUSTERED ([WorkShiftID] ASC);
GO

-- Creating primary key on [CompanyID] in table 'HR_Company'
ALTER TABLE [dbo].[HR_Company]
ADD CONSTRAINT [PK_HR_Company]
    PRIMARY KEY CLUSTERED ([CompanyID] ASC);
GO

-- Creating primary key on [AssetID] in table 'HR_CompanyAssets'
ALTER TABLE [dbo].[HR_CompanyAssets]
ADD CONSTRAINT [PK_HR_CompanyAssets]
    PRIMARY KEY CLUSTERED ([AssetID] ASC);
GO

-- Creating primary key on [ActualTaxExemptionID] in table 'HR_Emp_ActualAnnualTaxExemptionDetails'
ALTER TABLE [dbo].[HR_Emp_ActualAnnualTaxExemptionDetails]
ADD CONSTRAINT [PK_HR_Emp_ActualAnnualTaxExemptionDetails]
    PRIMARY KEY CLUSTERED ([ActualTaxExemptionID] ASC);
GO

-- Creating primary key on [MiscExemptionID] in table 'HR_Emp_ActualExemptions'
ALTER TABLE [dbo].[HR_Emp_ActualExemptions]
ADD CONSTRAINT [PK_HR_Emp_ActualExemptions]
    PRIMARY KEY CLUSTERED ([MiscExemptionID] ASC);
GO

-- Creating primary key on [AnnualSalaryID] in table 'HR_Emp_AnnualSalaryDetails'
ALTER TABLE [dbo].[HR_Emp_AnnualSalaryDetails]
ADD CONSTRAINT [PK_HR_Emp_AnnualSalaryDetails]
    PRIMARY KEY CLUSTERED ([AnnualSalaryID] ASC);
GO

-- Creating primary key on [AnnualTaxDeductionID] in table 'HR_Emp_AnnualTaxDeductionDetails'
ALTER TABLE [dbo].[HR_Emp_AnnualTaxDeductionDetails]
ADD CONSTRAINT [PK_HR_Emp_AnnualTaxDeductionDetails]
    PRIMARY KEY CLUSTERED ([AnnualTaxDeductionID] ASC);
GO

-- Creating primary key on [AssociateDocID] in table 'HR_Emp_AS_EducationDocs'
ALTER TABLE [dbo].[HR_Emp_AS_EducationDocs]
ADD CONSTRAINT [PK_HR_Emp_AS_EducationDocs]
    PRIMARY KEY CLUSTERED ([AssociateDocID] ASC);
GO

-- Creating primary key on [ProbationID] in table 'HR_Emp_AS_EmployeeInProbation'
ALTER TABLE [dbo].[HR_Emp_AS_EmployeeInProbation]
ADD CONSTRAINT [PK_HR_Emp_AS_EmployeeInProbation]
    PRIMARY KEY CLUSTERED ([ProbationID] ASC);
GO

-- Creating primary key on [EmployeeNumber] in table 'HR_Emp_BankAccountDetails'
ALTER TABLE [dbo].[HR_Emp_BankAccountDetails]
ADD CONSTRAINT [PK_HR_Emp_BankAccountDetails]
    PRIMARY KEY CLUSTERED ([EmployeeNumber] ASC);
GO

-- Creating primary key on [ContactID] in table 'HR_Emp_ContactDetails'
ALTER TABLE [dbo].[HR_Emp_ContactDetails]
ADD CONSTRAINT [PK_HR_Emp_ContactDetails]
    PRIMARY KEY CLUSTERED ([ContactID] ASC);
GO

-- Creating primary key on [EducationDetailID] in table 'HR_Emp_EducationDetails'
ALTER TABLE [dbo].[HR_Emp_EducationDetails]
ADD CONSTRAINT [PK_HR_Emp_EducationDetails]
    PRIMARY KEY CLUSTERED ([EducationDetailID] ASC);
GO

-- Creating primary key on [EducationDocID] in table 'HR_Emp_EducationDocs'
ALTER TABLE [dbo].[HR_Emp_EducationDocs]
ADD CONSTRAINT [PK_HR_Emp_EducationDocs]
    PRIMARY KEY CLUSTERED ([EducationDocID] ASC);
GO

-- Creating primary key on [EmergencyContactID] in table 'HR_Emp_EmergenceContact'
ALTER TABLE [dbo].[HR_Emp_EmergenceContact]
ADD CONSTRAINT [PK_HR_Emp_EmergenceContact]
    PRIMARY KEY CLUSTERED ([EmergencyContactID] ASC);
GO

-- Creating primary key on [EstimateTaxExemptionID] in table 'HR_Emp_EstimateAnnualTaxExemptionDetails'
ALTER TABLE [dbo].[HR_Emp_EstimateAnnualTaxExemptionDetails]
ADD CONSTRAINT [PK_HR_Emp_EstimateAnnualTaxExemptionDetails]
    PRIMARY KEY CLUSTERED ([EstimateTaxExemptionID] ASC);
GO

-- Creating primary key on [EstimateExemptionID] in table 'HR_Emp_EstimateExemptions'
ALTER TABLE [dbo].[HR_Emp_EstimateExemptions]
ADD CONSTRAINT [PK_HR_Emp_EstimateExemptions]
    PRIMARY KEY CLUSTERED ([EstimateExemptionID] ASC);
GO

-- Creating primary key on [DocumentID] in table 'HR_Emp_ExemptionDocuments'
ALTER TABLE [dbo].[HR_Emp_ExemptionDocuments]
ADD CONSTRAINT [PK_HR_Emp_ExemptionDocuments]
    PRIMARY KEY CLUSTERED ([DocumentID] ASC);
GO

-- Creating primary key on [FamilyMemberID] in table 'HR_Emp_FamilyMembers'
ALTER TABLE [dbo].[HR_Emp_FamilyMembers]
ADD CONSTRAINT [PK_HR_Emp_FamilyMembers]
    PRIMARY KEY CLUSTERED ([FamilyMemberID] ASC);
GO

-- Creating primary key on [InboxID] in table 'HR_Emp_Inbox'
ALTER TABLE [dbo].[HR_Emp_Inbox]
ADD CONSTRAINT [PK_HR_Emp_Inbox]
    PRIMARY KEY CLUSTERED ([InboxID] ASC);
GO

-- Creating primary key on [InsuredID] in table 'HR_Emp_InsuranceDetails'
ALTER TABLE [dbo].[HR_Emp_InsuranceDetails]
ADD CONSTRAINT [PK_HR_Emp_InsuranceDetails]
    PRIMARY KEY CLUSTERED ([InsuredID] ASC);
GO

-- Creating primary key on [LeaveHistId] in table 'HR_EMP_Leave_Hist'
ALTER TABLE [dbo].[HR_EMP_Leave_Hist]
ADD CONSTRAINT [PK_HR_EMP_Leave_Hist]
    PRIMARY KEY CLUSTERED ([LeaveHistId] ASC);
GO

-- Creating primary key on [MessageID] in table 'HR_Emp_LeaveApprovalMessage'
ALTER TABLE [dbo].[HR_Emp_LeaveApprovalMessage]
ADD CONSTRAINT [PK_HR_Emp_LeaveApprovalMessage]
    PRIMARY KEY CLUSTERED ([MessageID] ASC);
GO

-- Creating primary key on [LeaveQoutaDetailID] in table 'HR_EMP_LeaveQoutaDetails'
ALTER TABLE [dbo].[HR_EMP_LeaveQoutaDetails]
ADD CONSTRAINT [PK_HR_EMP_LeaveQoutaDetails]
    PRIMARY KEY CLUSTERED ([LeaveQoutaDetailID] ASC);
GO

-- Creating primary key on [LeaveRequestID] in table 'HR_Emp_LeaveRequest'
ALTER TABLE [dbo].[HR_Emp_LeaveRequest]
ADD CONSTRAINT [PK_HR_Emp_LeaveRequest]
    PRIMARY KEY CLUSTERED ([LeaveRequestID] ASC);
GO

-- Creating primary key on [MonthlyDeductionID] in table 'HR_Emp_MonthlySalaryDeductionDetails'
ALTER TABLE [dbo].[HR_Emp_MonthlySalaryDeductionDetails]
ADD CONSTRAINT [PK_HR_Emp_MonthlySalaryDeductionDetails]
    PRIMARY KEY CLUSTERED ([MonthlyDeductionID] ASC);
GO

-- Creating primary key on [MonthlySalaryID] in table 'HR_Emp_MonthlySalaryDetails'
ALTER TABLE [dbo].[HR_Emp_MonthlySalaryDetails]
ADD CONSTRAINT [PK_HR_Emp_MonthlySalaryDetails]
    PRIMARY KEY CLUSTERED ([MonthlySalaryID] ASC);
GO

-- Creating primary key on [EmployeeNumber], [PassportNumber] in table 'HR_Emp_Passport'
ALTER TABLE [dbo].[HR_Emp_Passport]
ADD CONSTRAINT [PK_HR_Emp_Passport]
    PRIMARY KEY CLUSTERED ([EmployeeNumber], [PassportNumber] ASC);
GO

-- Creating primary key on [EmploymentDetailID] in table 'HR_Emp_PreviousEmploymentDetails'
ALTER TABLE [dbo].[HR_Emp_PreviousEmploymentDetails]
ADD CONSTRAINT [PK_HR_Emp_PreviousEmploymentDetails]
    PRIMARY KEY CLUSTERED ([EmploymentDetailID] ASC);
GO

-- Creating primary key on [AssetID] in table 'HR_Emp_Property'
ALTER TABLE [dbo].[HR_Emp_Property]
ADD CONSTRAINT [PK_HR_Emp_Property]
    PRIMARY KEY CLUSTERED ([AssetID] ASC);
GO

-- Creating primary key on [ProvidentFundID] in table 'HR_Emp_ProvidentFundDetails'
ALTER TABLE [dbo].[HR_Emp_ProvidentFundDetails]
ADD CONSTRAINT [PK_HR_Emp_ProvidentFundDetails]
    PRIMARY KEY CLUSTERED ([ProvidentFundID] ASC);
GO

-- Creating primary key on [EmployeeNumber] in table 'HR_Emp_RelatedDocs'
ALTER TABLE [dbo].[HR_Emp_RelatedDocs]
ADD CONSTRAINT [PK_HR_Emp_RelatedDocs]
    PRIMARY KEY CLUSTERED ([EmployeeNumber] ASC);
GO

-- Creating primary key on [EmployeeNumber] in table 'HR_Emp_RelatedDocs_Hist'
ALTER TABLE [dbo].[HR_Emp_RelatedDocs_Hist]
ADD CONSTRAINT [PK_HR_Emp_RelatedDocs_Hist]
    PRIMARY KEY CLUSTERED ([EmployeeNumber] ASC);
GO

-- Creating primary key on [EmployeeManagerId] in table 'HR_Emp_ReportingDetails'
ALTER TABLE [dbo].[HR_Emp_ReportingDetails]
ADD CONSTRAINT [PK_HR_Emp_ReportingDetails]
    PRIMARY KEY CLUSTERED ([EmployeeManagerId] ASC);
GO

-- Creating primary key on [ReviewID] in table 'HR_Emp_ReviewDetails'
ALTER TABLE [dbo].[HR_Emp_ReviewDetails]
ADD CONSTRAINT [PK_HR_Emp_ReviewDetails]
    PRIMARY KEY CLUSTERED ([ReviewID] ASC);
GO

-- Creating primary key on [SentMessageID] in table 'HR_Emp_SentMessages'
ALTER TABLE [dbo].[HR_Emp_SentMessages]
ADD CONSTRAINT [PK_HR_Emp_SentMessages]
    PRIMARY KEY CLUSTERED ([SentMessageID] ASC);
GO

-- Creating primary key on [EmployeeNumber] in table 'HR_Emp_Skills'
ALTER TABLE [dbo].[HR_Emp_Skills]
ADD CONSTRAINT [PK_HR_Emp_Skills]
    PRIMARY KEY CLUSTERED ([EmployeeNumber] ASC);
GO

-- Creating primary key on [SmartGoalID] in table 'HR_Emp_SmartGoals'
ALTER TABLE [dbo].[HR_Emp_SmartGoals]
ADD CONSTRAINT [PK_HR_Emp_SmartGoals]
    PRIMARY KEY CLUSTERED ([SmartGoalID] ASC);
GO

-- Creating primary key on [UserGroupID] in table 'HR_Emp_UserGroup'
ALTER TABLE [dbo].[HR_Emp_UserGroup]
ADD CONSTRAINT [PK_HR_Emp_UserGroup]
    PRIMARY KEY CLUSTERED ([UserGroupID] ASC);
GO

-- Creating primary key on [UserGuid] in table 'HR_Emp_Users'
ALTER TABLE [dbo].[HR_Emp_Users]
ADD CONSTRAINT [PK_HR_Emp_Users]
    PRIMARY KEY CLUSTERED ([UserGuid] ASC);
GO

-- Creating primary key on [EmployeeNumber] in table 'HR_Employee'
ALTER TABLE [dbo].[HR_Employee]
ADD CONSTRAINT [PK_HR_Employee]
    PRIMARY KEY CLUSTERED ([EmployeeNumber] ASC);
GO

-- Creating primary key on [ApprovalStatusID] in table 'HR_GBL_LKP_ApprovalStatus'
ALTER TABLE [dbo].[HR_GBL_LKP_ApprovalStatus]
ADD CONSTRAINT [PK_HR_GBL_LKP_ApprovalStatus]
    PRIMARY KEY CLUSTERED ([ApprovalStatusID] ASC);
GO

-- Creating primary key on [IndustryTypeID] in table 'HR_GBL_LKP_IndustryType'
ALTER TABLE [dbo].[HR_GBL_LKP_IndustryType]
ADD CONSTRAINT [PK_HR_GBL_LKP_IndustryType]
    PRIMARY KEY CLUSTERED ([IndustryTypeID] ASC);
GO

-- Creating primary key on [TaxRuleID] in table 'HR_GBL_TaxRules'
ALTER TABLE [dbo].[HR_GBL_TaxRules]
ADD CONSTRAINT [PK_HR_GBL_TaxRules]
    PRIMARY KEY CLUSTERED ([TaxRuleID] ASC);
GO

-- Creating primary key on [BankID] in table 'HR_GLB_LKP_Banks'
ALTER TABLE [dbo].[HR_GLB_LKP_Banks]
ADD CONSTRAINT [PK_HR_GLB_LKP_Banks]
    PRIMARY KEY CLUSTERED ([BankID] ASC);
GO

-- Creating primary key on [TitleCode] in table 'HR_GLB_LKP_NameTitle'
ALTER TABLE [dbo].[HR_GLB_LKP_NameTitle]
ADD CONSTRAINT [PK_HR_GLB_LKP_NameTitle]
    PRIMARY KEY CLUSTERED ([TitleCode] ASC);
GO

-- Creating primary key on [RelationID] in table 'HR_GLB_LKP_RelationType'
ALTER TABLE [dbo].[HR_GLB_LKP_RelationType]
ADD CONSTRAINT [PK_HR_GLB_LKP_RelationType]
    PRIMARY KEY CLUSTERED ([RelationID] ASC);
GO

-- Creating primary key on [CurrencyID] in table 'HR_LK_Currency'
ALTER TABLE [dbo].[HR_LK_Currency]
ADD CONSTRAINT [PK_HR_LK_Currency]
    PRIMARY KEY CLUSTERED ([CurrencyID] ASC);
GO

-- Creating primary key on [AddressTypeID] in table 'HR_LKP_AddressType'
ALTER TABLE [dbo].[HR_LKP_AddressType]
ADD CONSTRAINT [PK_HR_LKP_AddressType]
    PRIMARY KEY CLUSTERED ([AddressTypeID] ASC);
GO

-- Creating primary key on [BankTypeID] in table 'HR_LKP_BankAccountTypes'
ALTER TABLE [dbo].[HR_LKP_BankAccountTypes]
ADD CONSTRAINT [PK_HR_LKP_BankAccountTypes]
    PRIMARY KEY CLUSTERED ([BankTypeID] ASC);
GO

-- Creating primary key on [CountryCode] in table 'HR_LKP_Country'
ALTER TABLE [dbo].[HR_LKP_Country]
ADD CONSTRAINT [PK_HR_LKP_Country]
    PRIMARY KEY CLUSTERED ([CountryCode] ASC);
GO

-- Creating primary key on [DepartmentID] in table 'HR_LKP_Departments'
ALTER TABLE [dbo].[HR_LKP_Departments]
ADD CONSTRAINT [PK_HR_LKP_Departments]
    PRIMARY KEY CLUSTERED ([DepartmentID] ASC);
GO

-- Creating primary key on [DiplomaID] in table 'HR_LKP_DiplomaDetails'
ALTER TABLE [dbo].[HR_LKP_DiplomaDetails]
ADD CONSTRAINT [PK_HR_LKP_DiplomaDetails]
    PRIMARY KEY CLUSTERED ([DiplomaID] ASC);
GO

-- Creating primary key on [EducationID] in table 'HR_LKP_EductionType'
ALTER TABLE [dbo].[HR_LKP_EductionType]
ADD CONSTRAINT [PK_HR_LKP_EductionType]
    PRIMARY KEY CLUSTERED ([EducationID] ASC);
GO

-- Creating primary key on [JobID] in table 'HR_LKP_JobTitle'
ALTER TABLE [dbo].[HR_LKP_JobTitle]
ADD CONSTRAINT [PK_HR_LKP_JobTitle]
    PRIMARY KEY CLUSTERED ([JobID] ASC);
GO

-- Creating primary key on [PropertyTypeID] in table 'HR_LKP_PropertyTypeID'
ALTER TABLE [dbo].[HR_LKP_PropertyTypeID]
ADD CONSTRAINT [PK_HR_LKP_PropertyTypeID]
    PRIMARY KEY CLUSTERED ([PropertyTypeID] ASC);
GO

-- Creating primary key on [SalaryDetailID] in table 'HR_LKP_SalaryGradeDetails'
ALTER TABLE [dbo].[HR_LKP_SalaryGradeDetails]
ADD CONSTRAINT [PK_HR_LKP_SalaryGradeDetails]
    PRIMARY KEY CLUSTERED ([SalaryDetailID] ASC);
GO

-- Creating primary key on [SalaryGradeCode] in table 'HR_LKP_SalaryGrades'
ALTER TABLE [dbo].[HR_LKP_SalaryGrades]
ADD CONSTRAINT [PK_HR_LKP_SalaryGrades]
    PRIMARY KEY CLUSTERED ([SalaryGradeCode] ASC);
GO

-- Creating primary key on [SkillID] in table 'HR_LKP_Skill'
ALTER TABLE [dbo].[HR_LKP_Skill]
ADD CONSTRAINT [PK_HR_LKP_Skill]
    PRIMARY KEY CLUSTERED ([SkillID] ASC);
GO

-- Creating primary key on [LocationID] in table 'HR_Locations'
ALTER TABLE [dbo].[HR_Locations]
ADD CONSTRAINT [PK_HR_Locations]
    PRIMARY KEY CLUSTERED ([LocationID] ASC);
GO

-- Creating primary key on [LogID] in table 'HR_Log'
ALTER TABLE [dbo].[HR_Log]
ADD CONSTRAINT [PK_HR_Log]
    PRIMARY KEY CLUSTERED ([LogID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeNumber] in table 'HR_Address'
ALTER TABLE [dbo].[HR_Address]
ADD CONSTRAINT [FK_HR_Emp_AddressHR_Employee]
    FOREIGN KEY ([EmployeeNumber])
    REFERENCES [dbo].[HR_Employee]
        ([EmployeeNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_Emp_AddressHR_Employee'
CREATE INDEX [IX_FK_HR_Emp_AddressHR_Employee]
ON [dbo].[HR_Address]
    ([EmployeeNumber]);
GO

-- Creating foreign key on [AddressTypeID] in table 'HR_Address'
ALTER TABLE [dbo].[HR_Address]
ADD CONSTRAINT [FK_HR_LK_AddressTypeHR_Emp_Address]
    FOREIGN KEY ([AddressTypeID])
    REFERENCES [dbo].[HR_LKP_AddressType]
        ([AddressTypeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_LK_AddressTypeHR_Emp_Address'
CREATE INDEX [IX_FK_HR_LK_AddressTypeHR_Emp_Address]
ON [dbo].[HR_Address]
    ([AddressTypeID]);
GO

-- Creating foreign key on [LocationID] in table 'HR_Address'
ALTER TABLE [dbo].[HR_Address]
ADD CONSTRAINT [FK_HR_LocationsHR_Emp_Address]
    FOREIGN KEY ([LocationID])
    REFERENCES [dbo].[HR_Locations]
        ([LocationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_LocationsHR_Emp_Address'
CREATE INDEX [IX_FK_HR_LocationsHR_Emp_Address]
ON [dbo].[HR_Address]
    ([LocationID]);
GO

-- Creating foreign key on [CompanyID] in table 'HR_Employee'
ALTER TABLE [dbo].[HR_Employee]
ADD CONSTRAINT [FK_HR_CompanyHR_Employee]
    FOREIGN KEY ([CompanyID])
    REFERENCES [dbo].[HR_Company]
        ([CompanyID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_CompanyHR_Employee'
CREATE INDEX [IX_FK_HR_CompanyHR_Employee]
ON [dbo].[HR_Employee]
    ([CompanyID]);
GO

-- Creating foreign key on [AssetID] in table 'HR_Emp_Property'
ALTER TABLE [dbo].[HR_Emp_Property]
ADD CONSTRAINT [FK_HR_CompanyAssetsHR_EmployeeProperty]
    FOREIGN KEY ([AssetID])
    REFERENCES [dbo].[HR_CompanyAssets]
        ([AssetID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PropertyTypeID] in table 'HR_CompanyAssets'
ALTER TABLE [dbo].[HR_CompanyAssets]
ADD CONSTRAINT [FK_HR_LK_PropertyTypeIDHR_CompanyAssets]
    FOREIGN KEY ([PropertyTypeID])
    REFERENCES [dbo].[HR_LKP_PropertyTypeID]
        ([PropertyTypeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_LK_PropertyTypeIDHR_CompanyAssets'
CREATE INDEX [IX_FK_HR_LK_PropertyTypeIDHR_CompanyAssets]
ON [dbo].[HR_CompanyAssets]
    ([PropertyTypeID]);
GO

-- Creating foreign key on [EducationDocID] in table 'HR_Emp_AS_EducationDocs'
ALTER TABLE [dbo].[HR_Emp_AS_EducationDocs]
ADD CONSTRAINT [FK_HR_Emp_EducationDocsHR_Emp_AS_EducationDocs]
    FOREIGN KEY ([EducationDocID])
    REFERENCES [dbo].[HR_Emp_EducationDocs]
        ([EducationDocID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_Emp_EducationDocsHR_Emp_AS_EducationDocs'
CREATE INDEX [IX_FK_HR_Emp_EducationDocsHR_Emp_AS_EducationDocs]
ON [dbo].[HR_Emp_AS_EducationDocs]
    ([EducationDocID]);
GO

-- Creating foreign key on [EmployeeNumber] in table 'HR_Emp_ContactDetails'
ALTER TABLE [dbo].[HR_Emp_ContactDetails]
ADD CONSTRAINT [FK_HR_EmployeeHR_ContactDetails]
    FOREIGN KEY ([EmployeeNumber])
    REFERENCES [dbo].[HR_Employee]
        ([EmployeeNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_EmployeeHR_ContactDetails'
CREATE INDEX [IX_FK_HR_EmployeeHR_ContactDetails]
ON [dbo].[HR_Emp_ContactDetails]
    ([EmployeeNumber]);
GO

-- Creating foreign key on [EmployeeNumber] in table 'HR_Emp_EducationDetails'
ALTER TABLE [dbo].[HR_Emp_EducationDetails]
ADD CONSTRAINT [FK_HR_EmployeeHR_Emp_EducationDetails]
    FOREIGN KEY ([EmployeeNumber])
    REFERENCES [dbo].[HR_Employee]
        ([EmployeeNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_EmployeeHR_Emp_EducationDetails'
CREATE INDEX [IX_FK_HR_EmployeeHR_Emp_EducationDetails]
ON [dbo].[HR_Emp_EducationDetails]
    ([EmployeeNumber]);
GO

-- Creating foreign key on [DiplomaID] in table 'HR_Emp_EducationDetails'
ALTER TABLE [dbo].[HR_Emp_EducationDetails]
ADD CONSTRAINT [FK_HR_LKP_DiplomaDetailsHR_Emp_EducationDetails]
    FOREIGN KEY ([DiplomaID])
    REFERENCES [dbo].[HR_LKP_DiplomaDetails]
        ([DiplomaID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_LKP_DiplomaDetailsHR_Emp_EducationDetails'
CREATE INDEX [IX_FK_HR_LKP_DiplomaDetailsHR_Emp_EducationDetails]
ON [dbo].[HR_Emp_EducationDetails]
    ([DiplomaID]);
GO

-- Creating foreign key on [EmployeeNumber] in table 'HR_Emp_EmergenceContact'
ALTER TABLE [dbo].[HR_Emp_EmergenceContact]
ADD CONSTRAINT [FK_HR_EmployeeHR_Emp_EmergenceContact]
    FOREIGN KEY ([EmployeeNumber])
    REFERENCES [dbo].[HR_Employee]
        ([EmployeeNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_EmployeeHR_Emp_EmergenceContact'
CREATE INDEX [IX_FK_HR_EmployeeHR_Emp_EmergenceContact]
ON [dbo].[HR_Emp_EmergenceContact]
    ([EmployeeNumber]);
GO

-- Creating foreign key on [EmployeeNumber] in table 'HR_Emp_FamilyMembers'
ALTER TABLE [dbo].[HR_Emp_FamilyMembers]
ADD CONSTRAINT [FK_HR_EmployeeHR_Emp_FamilyMembers]
    FOREIGN KEY ([EmployeeNumber])
    REFERENCES [dbo].[HR_Employee]
        ([EmployeeNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_EmployeeHR_Emp_FamilyMembers'
CREATE INDEX [IX_FK_HR_EmployeeHR_Emp_FamilyMembers]
ON [dbo].[HR_Emp_FamilyMembers]
    ([EmployeeNumber]);
GO

-- Creating foreign key on [RelationID] in table 'HR_Emp_FamilyMembers'
ALTER TABLE [dbo].[HR_Emp_FamilyMembers]
ADD CONSTRAINT [FK_HR_LKP_RelationTypeHR_Emp_FamilyMembers]
    FOREIGN KEY ([RelationID])
    REFERENCES [dbo].[HR_GLB_LKP_RelationType]
        ([RelationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_LKP_RelationTypeHR_Emp_FamilyMembers'
CREATE INDEX [IX_FK_HR_LKP_RelationTypeHR_Emp_FamilyMembers]
ON [dbo].[HR_Emp_FamilyMembers]
    ([RelationID]);
GO

-- Creating foreign key on [EmployeeNumber] in table 'HR_Emp_PreviousEmploymentDetails'
ALTER TABLE [dbo].[HR_Emp_PreviousEmploymentDetails]
ADD CONSTRAINT [FK_HR_EmployeeHR_Emp_PreviousEmploymentDetails]
    FOREIGN KEY ([EmployeeNumber])
    REFERENCES [dbo].[HR_Employee]
        ([EmployeeNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_EmployeeHR_Emp_PreviousEmploymentDetails'
CREATE INDEX [IX_FK_HR_EmployeeHR_Emp_PreviousEmploymentDetails]
ON [dbo].[HR_Emp_PreviousEmploymentDetails]
    ([EmployeeNumber]);
GO

-- Creating foreign key on [EmployeeNumber] in table 'HR_Emp_Property'
ALTER TABLE [dbo].[HR_Emp_Property]
ADD CONSTRAINT [FK_HR_EmployeeHR_CompanyProperty]
    FOREIGN KEY ([EmployeeNumber])
    REFERENCES [dbo].[HR_Employee]
        ([EmployeeNumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_EmployeeHR_CompanyProperty'
CREATE INDEX [IX_FK_HR_EmployeeHR_CompanyProperty]
ON [dbo].[HR_Emp_Property]
    ([EmployeeNumber]);
GO

-- Creating foreign key on [HR_LKP_Skill_SkillID] in table 'HR_Emp_Skills'
ALTER TABLE [dbo].[HR_Emp_Skills]
ADD CONSTRAINT [FK_HR_Emp_SkillsHR_LKP_Skill]
    FOREIGN KEY ([HR_LKP_Skill_SkillID])
    REFERENCES [dbo].[HR_LKP_Skill]
        ([SkillID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_Emp_SkillsHR_LKP_Skill'
CREATE INDEX [IX_FK_HR_Emp_SkillsHR_LKP_Skill]
ON [dbo].[HR_Emp_Skills]
    ([HR_LKP_Skill_SkillID]);
GO

-- Creating foreign key on [DepartmentID] in table 'HR_Employee'
ALTER TABLE [dbo].[HR_Employee]
ADD CONSTRAINT [FK_HR_EmployeeHR_LKP_Departments]
    FOREIGN KEY ([DepartmentID])
    REFERENCES [dbo].[HR_LKP_Departments]
        ([DepartmentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_EmployeeHR_LKP_Departments'
CREATE INDEX [IX_FK_HR_EmployeeHR_LKP_Departments]
ON [dbo].[HR_Employee]
    ([DepartmentID]);
GO

-- Creating foreign key on [TitleCode] in table 'HR_Employee'
ALTER TABLE [dbo].[HR_Employee]
ADD CONSTRAINT [FK_HR_GLB_LKP_NameTitleHR_Employee]
    FOREIGN KEY ([TitleCode])
    REFERENCES [dbo].[HR_GLB_LKP_NameTitle]
        ([TitleCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_GLB_LKP_NameTitleHR_Employee'
CREATE INDEX [IX_FK_HR_GLB_LKP_NameTitleHR_Employee]
ON [dbo].[HR_Employee]
    ([TitleCode]);
GO

-- Creating foreign key on [SalaryGradeCode] in table 'HR_Employee'
ALTER TABLE [dbo].[HR_Employee]
ADD CONSTRAINT [FK_HR_SalaryGradesHR_Employee]
    FOREIGN KEY ([SalaryGradeCode])
    REFERENCES [dbo].[HR_LKP_SalaryGrades]
        ([SalaryGradeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_SalaryGradesHR_Employee'
CREATE INDEX [IX_FK_HR_SalaryGradesHR_Employee]
ON [dbo].[HR_Employee]
    ([SalaryGradeCode]);
GO

-- Creating foreign key on [CurrencyID] in table 'HR_LKP_Country'
ALTER TABLE [dbo].[HR_LKP_Country]
ADD CONSTRAINT [FK_HR_LK_CountryHR_LK_Currency]
    FOREIGN KEY ([CurrencyID])
    REFERENCES [dbo].[HR_LK_Currency]
        ([CurrencyID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_LK_CountryHR_LK_Currency'
CREATE INDEX [IX_FK_HR_LK_CountryHR_LK_Currency]
ON [dbo].[HR_LKP_Country]
    ([CurrencyID]);
GO

-- Creating foreign key on [CountryCode] in table 'HR_Locations'
ALTER TABLE [dbo].[HR_Locations]
ADD CONSTRAINT [FK_HR_LK_CountryHR_Locations]
    FOREIGN KEY ([CountryCode])
    REFERENCES [dbo].[HR_LKP_Country]
        ([CountryCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_LK_CountryHR_Locations'
CREATE INDEX [IX_FK_HR_LK_CountryHR_Locations]
ON [dbo].[HR_Locations]
    ([CountryCode]);
GO

-- Creating foreign key on [SalaryGradeCode] in table 'HR_LKP_SalaryGradeDetails'
ALTER TABLE [dbo].[HR_LKP_SalaryGradeDetails]
ADD CONSTRAINT [FK_HR_LKP_SalaryGradeDetailsHR_LKP_SalaryGrades]
    FOREIGN KEY ([SalaryGradeCode])
    REFERENCES [dbo].[HR_LKP_SalaryGrades]
        ([SalaryGradeCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_HR_LKP_SalaryGradeDetailsHR_LKP_SalaryGrades'
CREATE INDEX [IX_FK_HR_LKP_SalaryGradeDetailsHR_LKP_SalaryGrades]
ON [dbo].[HR_LKP_SalaryGradeDetails]
    ([SalaryGradeCode]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------