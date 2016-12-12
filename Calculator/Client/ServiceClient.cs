using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Client.CalculatorReference;
using System.ServiceModel;
using Client.ClientMenu;

namespace Client
{
    public class ServiceClient
    {
        
        static void Main(string[] args)
        {
            CalculatorClient clientConnection = new CalculatorClient("BasicHttpBinding_ICalculator");
            try
            {
                WaitingClient waitingClient = new WaitingClient(clientConnection);
                waitingClient.WaitCommands();
                clientConnection.Close();
            }
            
            catch (FaultException ex)
            {
                clientConnection.Abort();
                Console.WriteLine();
                Console.WriteLine("Ошибка: {0}", ex.Reason);
            }
            catch (Exception ex)
            {
                clientConnection.Abort();
                Console.WriteLine();
                Console.WriteLine("Ошибка: {0}",ex.Message);
            }
            Console.ReadKey();
        }
    }
}
