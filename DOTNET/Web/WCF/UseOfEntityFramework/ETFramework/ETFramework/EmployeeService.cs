using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ETFramework
{
    
    class EmployeeService : IEmployee
    {
        public EmployeeDetails GetEmployeeDetails(int EmployeeID)
        {
            ETFramework.AdventureWorksEntities1 entity = new AdventureWorksEntities1();
            System.Data.Objects.ObjectSet<Employee> obj = entity.Employees;
            
            var query = from emp in entity.Employees
                        join add in entity.EmployeeAddresses on emp.EmployeeID equals add.EmployeeID
                        join add1 in entity.Addresses on add.AddressID equals add1.AddressID where emp.EmployeeID == EmployeeID
                        select new { emp.EmployeeID, emp.Title, emp.LoginID,  add1.AddressLine1, add1.AddressLine2, add1.City };
            EmployeeDetails empDet = new EmployeeDetails();
             
            //Employee emp = obj.FirstOrDefault();
            if (query.Count() >= 1)
            {
                var result = query.FirstOrDefault();
                empDet.EmployeeID = result.EmployeeID;
                empDet.LoginID = result.LoginID;
                empDet.Title = result.Title;
                empDet.Address1 = result.AddressLine1;
                empDet.Address2 = result.AddressLine2;
                empDet.City = result.City;
            }
            return empDet;
        }
    }
}
