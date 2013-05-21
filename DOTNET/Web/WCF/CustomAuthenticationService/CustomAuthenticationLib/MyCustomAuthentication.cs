using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel;
using System.IdentityModel.Tokens;
using System.IdentityModel.Selectors;

namespace CustomAuthenticationLib
{
    public class MyCustomAuthentication : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (!userName.Equals("axkhan2") && !password.Equals("andheri788"))
            {
                throw new SecurityTokenValidationException("Loging Failed, Please validate with correct username password");
            }
        }
    }
}
