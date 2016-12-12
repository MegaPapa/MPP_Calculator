using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Calculator.Exceptions;

namespace Calculator
{
    public class WEBCalculator : ICalculator
    {

        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            if (b == 0)
            {
                FaultReason reason = new FaultReason("Second parameter can't be 0.");
                throw new FaultException<ZeroDivideFault>(new ZeroDivideFault(),reason);
            }
            return a / b;
        }

        public double Sqrt(double a)
        {
            if (a < 0)
            {
                FaultReason reason = new FaultReason("Parameter must be positivate.");
                throw new FaultException<NegativateSqrtFault>(new NegativateSqrtFault(),reason);
            }
            return Math.Sqrt(a);
        }
    }
}
