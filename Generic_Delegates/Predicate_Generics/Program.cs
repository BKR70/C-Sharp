/*
 *  It takes one input parameter
 *  It output boolean return type
 *  Anonymous method and lambda expression can also be used here
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Predicate_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Bilas");
            names.Add("Kumar");
            names.Add("Roy");
            names.Add("Royal");
            names.Add("BKR");
            
            // Way : 01
            Predicate<string> nameSearch = CheckName;
            var data = names.FindAll(nameSearch);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------");

            // Way : 02
            // Predicate<string> nameSearch2 = x => x.StartsWith("R");
            // or,
            var data2 = names.FindAll(x => x.StartsWith("R"));
            foreach (var item in data2)
            {
                Console.WriteLine(item);
            }

            // More Ex:
            Predicate<string> val = delegate(string str)
            {
                if (str.Length > 3)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(val("Bilas"));

            Predicate<string> obj = str => str.Equals(str.ToLower());
            Console.WriteLine(obj("BILAS"));
        }

        public static bool CheckName(string name)
        {
            if(name.StartsWith("B"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
