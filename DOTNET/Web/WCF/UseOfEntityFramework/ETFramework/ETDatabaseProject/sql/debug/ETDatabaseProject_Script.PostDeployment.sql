/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

use AdventureWorks

SELECT     HumanResources.Employee.EmployeeID AS [Employee ID], HumanResources.Employee.Title, HumanResources.Employee.LoginID AS [Login ID], 
                      Person.Address.AddressLine1 AS [Address 1], Person.Address.AddressLine2 AS [Address 2], Person.Address.City
FROM         HumanResources.Employee INNER JOIN
                      HumanResources.EmployeeAddress ON HumanResources.Employee.EmployeeID = HumanResources.EmployeeAddress.EmployeeID INNER JOIN
                      Person.Address ON HumanResources.EmployeeAddress.AddressID = Person.Address.AddressID
