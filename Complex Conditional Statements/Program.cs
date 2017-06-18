using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double gender = double.Parse( Console.ReadLine());
            if (age < 16)
            //bool isAdult = age >= 16; така може да се избегне единия fi-else
            {
            //    if (gender == "m") Console.WriteLine("Master");
            //    else if (gender == "f") Console.WriteLine("Miss");
            }
            else
            {
             //   if (gender == "m") Console.WriteLine("Mr.");
             //   else if (gender == "f") Console.WriteLine("Ms.");
             //   // Console.WriteLine("{0}", isAdult ? "Mr.": "Master");
                string name = "Jo";
                string name2 = "jo";
                name.Equals(name2); //сверяване на стрингове
            }

        }
    }
}
