using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expression_and_statements_and_Anonymous_method
{
    internal class Program
    {
        public delegate int Calculation(int x, int y);
        static void Main(string[] args)
        {
            //Anonymous method
            Calculation cal = delegate (int x, int y) {
                return x + y;
            };
            Result(cal, 140, 30);


            // Lambda expression 
            Calculation cal2 = (x, y) => x + y;
            Result(cal2, 10, 30);


            // Lambda statements
            Calculation cal3 = (x, y) =>
            {
                return x + y;
            };
            Result(cal3, 10, 30);
        }
        static void Result(Calculation cal, int n1, int n2)
        {
            Console.WriteLine(cal(n1, n2));
        }
    }
}
