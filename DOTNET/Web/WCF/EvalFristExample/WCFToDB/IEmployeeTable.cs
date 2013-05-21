using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data.Linq;

namespace WCFToDB
{
    [ServiceContract]
    interface IEmployeeTable
    {
        [OperationContract]
        List<EmployeeTable> GetEmployeeTable();
        [OperationContract]
        void UpdateEmployeeTable(EmployeeTable table);
        int DeleteEmployeeTable(int EmployeeID);
        void InsertEmployeeTable(EmployeeTable table);
    }
}
