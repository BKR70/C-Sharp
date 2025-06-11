/*
 * Eta 2 vabe use kora jay
 *    01. System namespace e built in thake
 *    02. custom or user modified (not necessary, rare used)
 * Max. 16 ta input parameter newa jay (0 - 16)
 * Not present output parameter (auto void type thake)
 * Anonymous method and lambda expression can also be used here
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Action_Generics
{
    internal class Program
    {
        // User defined action delegate ( main function e kaj korar jonno etar decl. dorkar nai)
        // public delegate void Action<in T1, in T2, in T3>(T1 p1, T2 p2);

        static void Main(string[] args)
        {
            Action<int, int> Cal = Add;
            Cal += Sub;                     // multicast delegates
            Cal(5, 10);

            Action<int, int> Sum = (x, y) =>
            {
                Console.WriteLine(x + y);
                Console.WriteLine(x * y);
            };
            Sum(50, 10);

            Action HW = delegate
            {
                Console.WriteLine("Hello World");
            };
            HW();
        }
        static void Add(int x, int y) {
            Console.WriteLine(x + y);
        }
        static void Sub(int x, int y) {
            Console.WriteLine(x - y);
        }
    }
}
