using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_as_parameter
{
    internal class Program
    {
        public delegate int Calculation(int x, int y);
        static void Main(string[] args)
        {
            Calculation cal = Sum;
            Result(cal, 30, 40);
            cal = Sub;
            Result(cal, 70, 35);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static void Result(Calculation cal, int n1, int n2)
        {
            Console.WriteLine(cal(n1, n2));
        }
    }
}
