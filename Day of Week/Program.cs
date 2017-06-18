using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (1<=input && input<=6)
            {
            string day = ((DayOfWeek)input).ToString();
            Console.WriteLine(day);
            }
            else if (input==7)
            {
            string day = (DayOfWeek.Sunday).ToString();
            Console.WriteLine(day);
            }
            else
            {
        Console.WriteLine("error");
            }
        }
    }
}
