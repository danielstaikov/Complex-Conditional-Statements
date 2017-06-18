using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //която въвежда тип прожекция (стринг), брой редове и брой колони в залата 
            //Premiere – премиерна прожекция, на цена 12.00 лева.
            //Normal – стандартна прожекция, на цена 7.50 лева.
            //Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            decimal price=0;

            switch (projection)
            {
                case "Premiere":
                    price = 12m;
                    break;
                case "Normal":
                    price = 7.5m;
                    break;
                case "Discount":
                    price = 5m;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            decimal result = price * row * colums;
            Console.WriteLine("${0:f2} leva", result);
        }
    }
}
