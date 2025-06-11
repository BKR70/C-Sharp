using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OrderStatus.OrderPlace);
            Console.WriteLine((int)OrderStatus.OrderPlace);
            Console.WriteLine((int)OrderStatus.OrderConfirmed);
            Console.WriteLine((int)OrderStatus.Packaging);
            Console.WriteLine((int)OrderStatus.Delivering);
            Console.WriteLine((int)OrderStatus.Received);
            int productOrderInfo = 1;
            if(productOrderInfo == (int)OrderStatus.OrderPlace)
            {

            }
            else if(productOrderInfo == (int)OrderStatus.Packaging)
            {

            }

            Console.ReadKey(); 
        }
    }
}
