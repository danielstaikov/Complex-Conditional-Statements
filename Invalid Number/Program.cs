using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isNotValid = (200 < n || n < 100 && n != 0);
            if (isNotValid)
            {
                Console.WriteLine("invalid");
            }
        }  
    }
}
