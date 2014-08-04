using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAgent
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            string outputMessage = string.Empty;

            IOrderFood expeditor = new OrderExpeditor();                        

            string orderinput;

            do
            {
                Console.WriteLine("Please enter the time of the day and type of dish to order.");

                orderinput = Console.ReadLine();

                var orderParams = orderinput.Split(',');

                try
                {
                    outputMessage = expeditor.GetOrder(orderParams);
                }
                catch (Exception ex)
                {
                    outputMessage = "Invalid request.";
                }

                Console.WriteLine(outputMessage);
                Console.WriteLine("");

            } while (orderinput != null);
            
        }
    }
}
