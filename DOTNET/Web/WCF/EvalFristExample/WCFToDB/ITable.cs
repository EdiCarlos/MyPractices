using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFToDB
{
    [ServiceContract]
    interface ITable
    {
        [OperationContract]
        List<t1> GetTable1();
        [OperationContract]
        void UpdateTable(Table1 table);
        [OperationContract]
        void InsertTable(string FirstName);
        [OperationContract]
        void DeleteTable(int id);
    }
    [ServiceContract]
    interface ITableCallback
    {
        [OperationContract(IsOneWay=true)]
        void OnUpdate(Table1 table);
        [OperationContract(IsOneWay = true)]
        void OnDelete(int id);
        [OperationContract(IsOneWay=true)]
        void OnInsert(string FirstName)]
    }
}
