using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {

            int kilometers = int.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine().ToLower();

            decimal tarifaTaxi = 0;
            switch (dayNight)
                {
                case "day":
                    tarifaTaxi = 0.79m;
                    break;
                case "night":
                    tarifaTaxi = 0.90m;
                    break;
                }

            decimal taxi = 0.70m + (tarifaTaxi * kilometers);
            decimal bus = 0.09m * kilometers;
            decimal train = 0.06m * kilometers;
            if (kilometers>0 && kilometers<20)
            {
                Console.WriteLine($"{taxi}");
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                Console.WriteLine("{0}",bus<taxi? bus:taxi );
            }
            else
            {
                Console.WriteLine("{0}", bus < train ? bus : train);
            }

        }
    }
}
