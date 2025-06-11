using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generic_Delegates_Basic.Program;

namespace Generic_Delegates_Basic
{
    internal class Program
    {
        public delegate void NamePrint<T>(T name);
        public delegate T1 CalSum<T1,T2>(T1 v1, T2 v2);
        static void Main(string[] args)
        {
            NamePrint<string> np = First;
            np += Second;
            np("Bilas");
            Console.WriteLine("---------");
            np -= First;                                // Here see the changes
            np("Bilas");

            CalSum<int, int> obj = Sum;
            Console.WriteLine(obj(2, 3));
        }
        static void First(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        static void Second(string name)
        {
            Console.WriteLine("How are you " + name + "?");
        }
        static int Sum(int a, int b)
        {
            return a * a + b * b;
        }
    }
}
