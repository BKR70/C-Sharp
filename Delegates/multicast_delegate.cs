using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
 * Multicasting of delegate should have a return type of Void 
 * otherwise it will throw a runtime exception.
 * 
 */
namespace Multicast_Delegates
{
    internal class Program
    {
        public delegate void NamePrint(string name);
        static void Main(string[] args)
        {
            // Way : 01
            NamePrint np = First;
            np += Second;
            np("Bilas");
            Console.WriteLine("---------");
            np -= First;  // Here see the changes
            np("Bilas");

            Console.WriteLine("\n*************\n");

            // Way : 02
            NamePrint val1 = First;
            NamePrint val2 = Second;
            NamePrint val = val1 + val2;
            val("Kohli");
            Console.WriteLine("---------");
            val -= Second;  
            val("Kohli");

            Console.WriteLine("\n*************\n");

            // Way : 03 (using anonymous method)
            NamePrint cal1 = delegate (string s) {
                Console.WriteLine("Welcome " + s);
            };
            NamePrint cal2 = delegate (string s) {
                Console.WriteLine("How are you " + s + "?");
            };
            cal1 += cal2;
            cal1("Mom");
            Console.WriteLine("---------");
            cal1 -= cal2;  
            cal1("Mom");

            Console.WriteLine("\n*************\n");

            // Way : 04 (using Lambda expression)
            NamePrint lam1 = (s) => Console.WriteLine("Welcome " + s);
            NamePrint lam2 = (s) => Console.WriteLine("How are you " + s + "?");
            NamePrint lam = lam1 + lam2;
            lam("Bro");
            Console.WriteLine("---------");
            lam -= lam2;  
            lam("Bro");


        }
        static void First(string name)
        {
            Console.WriteLine("Welcome "+name);
        }
        static void Second(string name)
        {
            Console.WriteLine("How are you "+name+"?");
        }
    }
}
