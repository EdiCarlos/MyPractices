using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ServiceModel;
using System.Data.Linq;

namespace WCFToDB
{
    [ServiceBehavior]
    class Services : IEmployeeTable, ITable
    {
        ITableCallback tableCallBack;

        public List<EmployeeTable> GetEmployeeTable()
        {
            LinqPracDBDataContext dbContext = new LinqPracDBDataContext();
            return dbContext.EmployeeTables.ToList<EmployeeTable>();
        }
        public void UpdateEmployeeTable(EmployeeTable table)
        {
            LinqPracDBDataContext dbContext = new LinqPracDBDataContext();
            //var empTable = dbContext.EmployeeTables.Select(e => e.Employeeid == table.Employeeid);
            var empTable = from emp in dbContext.EmployeeTables where emp.Employeeid == table.Employeeid select emp;
            EmployeeTable employeeTable = empTable.First<EmployeeTable>();
            employeeTable.BirthDate = table.BirthDate;
            employeeTable.LoginID = table.LoginID;
            employeeTable.Title = table.Title;
            dbContext.SubmitChanges();
        }

        public int DeleteEmployeeTable(int EmployeeID)
        {
            throw new NotImplementedException();
        }

        public void InsertEmployeeTable(EmployeeTable table)
        {
            throw new NotImplementedException();
        }

        
        public List<t1> GetTable1()
        {
            return new LinqPracDBDataContext().t1s.ToList<t1>();
        }

        public void UpdateTable(Table1 table)
        {
            LinqPracDBDataContext pracDb = new LinqPracDBDataContext();
            var enTable1 = from tt1 in pracDb.t1s
                           where tt1.t1id == table.ID
                           select tt1;
            t1 t = enTable1.First<t1>();
            t.firstName = table.FirstName;
            pracDb.SubmitChanges();
        }
        public void InsertTable(string firstName)
        {
            LinqPracDBDataContext pracDb = new LinqPracDBDataContext();
            t1 t = new t1();
            t.firstName = firstName;
            pracDb.t1s.InsertOnSubmit(t);
            pracDb.SubmitChanges();
        }
        public void DeleteTable(int id)
        {
            LinqPracDBDataContext pracDb = new LinqPracDBDataContext();
            pracDb.t1s.DeleteOnSubmit(pracDb.t1s.Select(e => e).Where(w => w.t1id == id).First<t1>());
            pracDb.SubmitChanges();
        }
    }
}
