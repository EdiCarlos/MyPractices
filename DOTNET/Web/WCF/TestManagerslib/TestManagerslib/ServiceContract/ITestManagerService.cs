using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TestManagerslib.Contract;

namespace TestManagerslib.ServiceContract
{
    [ServiceContract]
    public interface ITestManagerService
    {
        [OperationContract]
        CTestManager GetTest(int TestID);
        [OperationContract]
        List<CTestManager> GetTests(List<int> TestIds);
        [OperationContract(IsOneWay=true)]
        void InsertTest(CTestManager manager);
        [OperationContract]
        List<string> GetClaims();
    }
}
