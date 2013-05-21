using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAuthenticationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CustAuthenticationServiceClient.CustomAuthenticationServiceClient client = new CustAuthenticationServiceClient.CustomAuthenticationServiceClient();
            client.ClientCredentials.UserName.UserName = "axkhan2";
            client.ClientCredentials.UserName.Password = "andheri788";

            foreach (string claim in client.GetClaims())
            {
                Console.WriteLine(claim);
            }
        }
    }
}
