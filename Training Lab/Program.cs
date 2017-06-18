using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal length = decimal.Parse(Console.ReadLine());
            decimal l = Math.Floor(length /0.70m);
            decimal w = Math.Floor((width - 1) / 1.20m);
            decimal result = (l * w) - 3;
            Console.WriteLine(result);
        }
    }
}
