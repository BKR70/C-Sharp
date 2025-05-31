/*
 * Eta 2 vabe use kora jay
 *    01. System namespace e built-in thake
 *    02. custom or user modified (not necessary, rare used)
 * Max. 16 ta input parameter newa jay (0 - 16)
 * Must be output parameter thakbe (except void type)
 * Last param. is function return type others input param. type
 * Anonymous method and lambda expression can also be used here
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Func_Generics
{
    internal class Program
    {
        // User defined func delegate ( main function e kaj korar jonno etar decl. dorkar nai)
        // public delegate TResult Func<in T1, in T2, out TResult>(T1 p1, T2 p2);
        static void Main(string[] args)
        {
            Func<int, int, int> Calc1 = Add;      
            int res = Calc1(10, 930);             
            Console.WriteLine(res);


            Func<int, int, int> Calc2 = (x, y) => x + y;
            int ans = Calc2(10, 40);
            Console.WriteLine(ans);


            Func<int> Calc3 = () =>         // return kortei hobe must (not void)
            { 
                Console.WriteLine("Hello World");
                return 10;
            };
            Console.WriteLine(Calc3());
        }
        static int Add(int x, int y) {
            return x + y; 
        }
    }
}
