﻿CREATE NONCLUSTERED INDEX [IX_FK_HR_LK_PropertyTypeIDHR_CompanyAssets] ON [dbo].[HR_CompanyAssets] 
(
	[PropertyTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)


