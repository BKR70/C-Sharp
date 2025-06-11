using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Delegates
{
    internal class Program
    {
        public delegate int Calculation(int x, int y);
        static void Main(string[] args)
        {
            // Two ways of Initialization 

            // 01.
            Calculation cal1 = new Calculation(Sum);
                // Two ways of calling
                int res1 = cal1.Invoke(50, 30);
                int res2 = cal1(50, 30);
                Console.WriteLine("{0} {1}",res1,res2);
            
            // 02.
            Calculation cal2 = Sum;
                int r1 = cal2.Invoke(50, 40);
                int r2 = cal2(50, 40);
                Console.WriteLine($"{r1} {r2}");

            // Now call different method using same method ref. (Delegates)
            Calculation obj = Sum;
            Console.WriteLine("Sum = "+obj(10, 15));
            obj = Sub;
            Console.WriteLine("Sub = "+obj(25, 15));
            obj = Mul;
            Console.WriteLine("Mul = "+obj(10, 15));
            obj = Div;
            Console.WriteLine("Div = "+obj(150, 15));
        }
        static int Sum(int a, int b) {
            return a + b;
        }
        static int Sub(int a, int b) {
            return a - b;
        }
        static int Mul(int a, int b) {
            return a * b;
        }
        static int Div(int a, int b) {
            return a / b;
        }
    }
}
