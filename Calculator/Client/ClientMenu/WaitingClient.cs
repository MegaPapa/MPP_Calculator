using Client.CalculatorReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Client.ClientMenu
{
    public class WaitingClient : IClient
    {
        private readonly CalculatorClient clientConnection;
        private static Logger logger = LogManager.GetCurrentClassLogger();
 
        public WaitingClient(CalculatorClient clientConnection) 
        {
            this.clientConnection = clientConnection;
        }

        private static void Add(CalculatorClient client)
        {
            double a,
                b;
            Console.WriteLine("Enter first parameter: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second parameter:");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Result: {0}", client.Addition(a, b));
        }

        private static void Sub(CalculatorClient client)
        {
            double a,
                b;
            Console.WriteLine("Enter first parameter: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second parameter:");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Result: {0}", client.Subtraction(a, b));
        }

        private static void Mult(CalculatorClient client)
        {
            double a,
                b;
            Console.WriteLine("Enter first parameter: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second parameter:");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Result: {0}", client.Multiplication(a, b));
        }

        private static void Div(CalculatorClient client)
        {
            try
            {
                double a,
                    b;
                Console.WriteLine("Enter first parameter: ");
                a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter second parameter:");
                b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", client.Division(a, b));
            }
            catch (FaultException<ZeroDivideFault> ex)
            {
                logger.Warn(ex);
            }
        }

        private static void Sqrt(CalculatorClient client)
        {
            try
            {
                double a;
                Console.WriteLine("Enter parameter: ");
                a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", client.Sqrt(a));
            }
            catch (FaultException<NegativateSqrtFault> ex)
            {
                logger.Warn(ex);
            }
        }

        public void WaitCommands()
        {
            int command = 0;
            while (command != -1)
            {
                Console.WriteLine("Enter command number(+ 1,- 2,* 3,/ 4,sqrt 5,exit -1):");
                command = Int32.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        Add(clientConnection);
                        break;
                    case 2:
                        Sub(clientConnection);
                        break;
                    case 3:
                        Mult(clientConnection);
                        break;
                    case 4:
                        Div(clientConnection);
                        break;
                    case 5:
                        Sqrt(clientConnection);
                        break;
                }
            }
        }
    }
}
