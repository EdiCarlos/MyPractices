using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DuplexNetService
{
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple, InstanceContextMode=InstanceContextMode.PerSession)]
    public class CalculatorService : DuplexNetService.ICalculatorService
    {
        double result = 0.0D;
        string methodName = string.Empty;

        CallBackService callback;

        public CalculatorService()
        {
            result = 100;
            callback = OperationContext.Current.GetCallbackChannel<CallBackService>();
        }

        public void AddTo(double result)
        {
            this.result += result;
            callback.DisplayResult(result);
            callback.DisplayMethod("AddTo");
        }
    }
}
