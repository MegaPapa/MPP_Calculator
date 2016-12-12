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
    [ServiceContract]
    public interface ICalculator
    {

        [OperationContract]
        double Addition(double a, double b);

        [OperationContract]
        double Subtraction(double a, double b);

        [OperationContract]
        double Multiplication(double a, double b);

        [OperationContract]
        [FaultContract(typeof(ZeroDivideFault))]
        [FaultContract(typeof(NegativateSqrtFault))]
        double Division(double a, double b);

        [OperationContract]
        [FaultContract(typeof(NegativateSqrtFault))]
        [FaultContract(typeof(ZeroDivideFault))]
        double Sqrt(double a);
    }
}
