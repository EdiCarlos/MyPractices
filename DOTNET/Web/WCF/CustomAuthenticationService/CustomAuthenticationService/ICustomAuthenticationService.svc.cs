using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CustomAuthenticationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Name="CustomAuthentication", Namespace="")]
    public class CustAuthenticationService : ICustomAuthenticationService 
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<string> GetClaims()
        {
            List<string> listAdd = new List<string>();
            ServiceSecurityContext svcContext = OperationContext.Current.ServiceSecurityContext;
            IEnumerable<Claim> claims = svcContext.AuthorizationContext.ClaimSets[0].FindClaims(ClaimTypes.Name, Rights.Identity);

            foreach (Claim claim in claims)
            {
                listAdd.Add(string.Format("Claim Resource :{0}, Claim Rights: {1} ClaimType : {2}", claim.Resource, claim.Right, claim.ClaimType));
            }
            return listAdd;
        }
        [OperationBehavior]
        public FullName GetFullName(string name)
        {
            return new FullName() { FirstName = "Arif", LastName = "Khan", MiddleName = "BanneHasan" };
        }
    }
}
