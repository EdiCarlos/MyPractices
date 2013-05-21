using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DualHttpSample
{
    [ServiceContract(Namespace="http://myservice/mydualname", SessionMode=SessionMode.Required, CallbackContract=typeof(IDualNameCallback))]
    public interface IDualNameService
    {
        [OperationContract(IsOneWay=true)]
        void ShowName();
    }

    public interface IDualNameCallback
    {

        [OperationContract]
        string FirstName();

        [OperationContract]
        string MiddleName();
        
        [OperationContract]
        string LastName();
   
        [OperationContract(IsOneWay=true)]
        void FullName(string fullName);
   
    }
}
