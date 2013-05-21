using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessManagementService;

namespace CreatePDB
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessManagement ass = new AccessManagement();
            ass.GetUserInfo();
        }
    }
}
