using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TestManagerslib.Data;
using TestManagerslib.ServiceContract;
using System.IdentityModel.Policy;
using System.IdentityModel.Claims;
using System.ServiceModel.Security;
using System.Security.Permissions;

namespace TestManagerslib.Implementation
{
    [ServiceBehavior]
    public class TestManagerService : ITestManagerService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
        [OperationBehavior]
        public Contract.CTestManager GetTest(int TestID)
        {
            Contract.CTestManager testManager = null;
            using (TestManagerDBContainer container = new TestManagerDBContainer())
            {
                testManager = container.TestManagers.Where(e => e.TestManagerID == TestID).Select(e => new Contract.CTestManager()
                {
                    TestId = e.TestManagerID,
                    Name = e.TestName,
                    Description = e.TestDescription,
                    NumberOfQuestions = e.NumberOfQuestions,
                    Percent = e.PassPercentage,
                    PassingMarks = e.PassingMark,
                    GradeID = e.GradeTypeID,
                    TotalMarks = e.TotalMarks
                }).ToList().First();
            }
            return testManager;
        }
        [PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
        public List<Contract.CTestManager> GetTests(List<int> TestIds)
        {
            List<Contract.CTestManager> testManager = null;
            using (TestManagerDBContainer container = new TestManagerDBContainer())
            {
                testManager = container.TestManagers.Where(e => TestIds.Contains(e.TestManagerID)).Select(e => new Contract.CTestManager()
                {
                    TestId = e.TestManagerID,
                    Name = e.TestName,
                    Description = e.TestDescription,
                    NumberOfQuestions = e.NumberOfQuestions,
                    Percent = e.PassPercentage,
                    PassingMarks = e.PassingMark,
                    GradeID = e.GradeTypeID,
                    TotalMarks = e.TotalMarks
                }).ToList();
            }
            return testManager;
        }

        public void InsertTest(Contract.CTestManager manager)
        {
            using (TestManagerDBContainer container = new TestManagerDBContainer())
            {
                int result = container.InsertTestManager(manager.Name, manager.Description, manager.NumberOfQuestions, manager.NumberOfQuestions, manager.TotalMarks, manager.GradeID, manager.Duration, manager.PassingMarks);
            }
        }


        [OperationBehavior]
        public List<string> GetClaims()
        {
            List<string> name = new List<string>();
            ServiceSecurityContext svcContext = OperationContext.Current.ServiceSecurityContext;
            IEnumerable<Claim> claimList = svcContext.AuthorizationContext.ClaimSets[0].FindClaims(ClaimTypes.Name, Rights.Identity);
            foreach (Claim clm in claimList)
            {
                name.Add("Your name " + clm.Resource);
            }
            return name;
        }
    }
}
