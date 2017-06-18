using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());
            bool isWeekend = day == "saturday" || day == "sunday";
            bool isWeek = day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday";
            bool isArticle = fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes";
            decimal price = 0;
            decimal result = 0;
            if (isWeekend)
            {
                switch (fruit)
                {
                    case "banana": price = 2.70m;
                        break;
                    case "apple": price = 1.25m;
                        break;
                    case "orange": price = 0.90m;
                        break;
                    case "grapefruit": price = 1.60m;
                        break;
                    case "kiwi": price = 3.00m;
                        break;
                    case "pineapple": price = 5.60m;
                        break;
                    case "grapes": price = 4.20m;
                        break;
                }
            }
            else if (isWeek)
            {
                switch (fruit)
                {
                    case "banana": price = 2.50m;
                        break;
                    case "apple": price = 1.20m;
                        break;
                    case "orange": price = 0.85m;
                        break;
                    case "grapefruit": price = 1.45m;
                        break;
                    case "kiwi": price = 2.70m;
                        break;
                    case "pineapple": price = 5.50m;
                        break;
                    case "grapes": price = 3.85m;
                        break;
                }
            }
            if ((isWeek || isWeekend) && isArticle)
            {
               result = price * quantity;
               Console.WriteLine("{0:0.00}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
       }
    }
}
