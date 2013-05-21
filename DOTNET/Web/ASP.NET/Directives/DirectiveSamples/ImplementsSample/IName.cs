using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementsSample
{
    public interface IName
    {
        void SetFirstName(string fname);
        void SetLastName(string lname);
        string FullName();
    }
}
