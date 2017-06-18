using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            bool isAdult = age >= 16;

            if (gender == "m")
            {
                Console.WriteLine("{0}",isAdult? "Mr." : "Master");
            }
            else if (gender == "f") 
            {
                Console.WriteLine("{0}", isAdult ? "Ms." : "Miss");
            }
            else
            {
                Console.WriteLine("error");
            }
            
          }
     }
}
