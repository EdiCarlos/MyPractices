using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DualHttpSample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DualCalculatorService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession, ConcurrencyMode=ConcurrencyMode.Multiple)]
    public class DualCalculatorService : IDualCalculatorService
    {
        double result;
        string equation;
        ICallBackCalculator callback = null;
        public DualCalculatorService()
        {
            result = 0.0D;
            equation = string.Empty;
            callback = OperationContext.Current.GetCallbackChannel<ICallBackCalculator>();
        }
        public void Clear()
        {
            callback.Equation(equation + " = " + result.ToString());
            result = 0.0D;
            equation = result.ToString();
        }

        public void AddTo(double n1)
        {
            result += n1;
            equation += " + " + n1.ToString();
            callback.Result(result);
        }

        public void SubtractFrom(double n1)
        {
            result -= n1;
            equation += " - " + n1.ToString();
            callback.Result(result);
        }

        public void MultiplyBy(double n1)
        {
            result *= n1;
            equation += " * " + n1.ToString();
            callback.Result(result);
        }

        public void DivideBy(double n1)
        {
            result /= n1;
            equation += " / " + n1.ToString();
            callback.Result(result);
        }
    }
}
