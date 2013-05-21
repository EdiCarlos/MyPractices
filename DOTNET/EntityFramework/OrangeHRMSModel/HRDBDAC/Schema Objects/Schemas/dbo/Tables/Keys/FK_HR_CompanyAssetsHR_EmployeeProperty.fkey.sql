ALTER TABLE [dbo].[HR_Emp_Property]
    ADD CONSTRAINT [FK_HR_CompanyAssetsHR_EmployeeProperty] FOREIGN KEY ([AssetID]) REFERENCES [dbo].[HR_CompanyAssets] ([AssetID]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
ALTER TABLE [dbo].[HR_Emp_Property] NOCHECK CONSTRAINT [FK_HR_CompanyAssetsHR_EmployeeProperty];

