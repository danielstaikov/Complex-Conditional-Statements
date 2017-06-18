using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            bool istOnBorder = (x1 == x || x == x2) && (y1 <= y &&  y <= y2) || (y1 == y || y == y2) && (x1 <= x && x <= x2);
            Console.WriteLine("{0}", istOnBorder ? "Border" : "Inside / Outside");

        }
    }
}
