using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManagerslib.Contract;

namespace TestManagerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TestManagerServiceClient.TestManagerServiceClient client = new TestManagerServiceClient.TestManagerServiceClient();
            client.ClientCredentials.UserName.UserName = "admin";
            client.ClientCredentials.UserName.Password = "admin";

            //client.InsertTest(new TestManagerslib.Contract.CTestManager()
            //{
            //    Name = "First Name",
            //    Description = "",
            //    Duration = 10,
            //    PassingMarks = 50,
            //    TotalMarks = 100,
            //    NumberOfQuestions = 50,
            //    Percent = 50
            //});
            List<CTestManager> testManager = client.GetTests(new List<int>() { 1, 2 });
            List<string> cliams = client.GetClaims();
            foreach (string result in cliams)
            {
                Console.WriteLine(result);
            }
            foreach (CTestManager test in testManager)
                Console.WriteLine(test.Name);
            client.Close();
        }
    }
}
