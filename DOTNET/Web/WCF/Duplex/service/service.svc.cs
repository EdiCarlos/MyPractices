using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace service
{
    // NOTE: If you change the class name "service" here, you must also update the reference to "service" in Web.config.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class CalculatorService : ICalculator
    {
        double result = 0.0D;
        string equation;
        public CalculatorService()
        {
            equation = result.ToString();
        }
        #region ICalculator Members
        public void Clear()
        {
            CallBack.Equation(equation + " = " + result.ToString());
            equation = result.ToString();
        }
        public void AddTo(double n)
        {
            result += n;
            equation += " + " + n.ToString();
            CallBack.Result(result);
        }

        public void SubtractTo(double n)
        {
            result -= n;
            equation += " - " + n.ToString();
            CallBack.Result(result);
        }

        public void MultipleTo(double n)
        {
            result *= n;
            equation += " * " + n.ToString();
            CallBack.Result(result);
        }

        public void DivideTo(double n)
        {
            result /= n;
            equation += " / " + n.ToString();
            CallBack.Result(result);
        }
        ICallBackCalucator CallBack
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<ICallBackCalucator>();
            }
        }
        #endregion
    }
}
