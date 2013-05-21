using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DualHttpSample
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode=ConcurrencyMode.Multiple)]
    public class DualNameService : IDualNameService
    {
        string fname = string.Empty, lname = string.Empty, mname = string.Empty;

        IDualNameCallback callback = null;

        public DualNameService()
        {
            callback = OperationContext.Current.GetCallbackChannel<IDualNameCallback>();
        }

        [OperationBehavior]
        public void ShowName()
        {
            fname = callback.FirstName();
            lname = callback.LastName();
            mname = callback.MiddleName();
            callback.FullName(fname + mname + lname);
        }
    }
}
