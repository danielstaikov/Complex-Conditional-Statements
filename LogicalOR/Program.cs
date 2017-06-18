using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool fruit = s == "banana" || s == "apple" || s == "kiwi" || s == "cherry" || s == "lemon" || s == "grapes";
            bool vegetable = s == "tomato" || s == "cucumber" || s == "pepper" || s == "carrot";
            if (fruit)
            {
                Console.WriteLine("fruit");
            }
            else if (vegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
