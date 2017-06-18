using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drogeria
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            bool hasStore = town.ToLower().Equals("sofia") || town.ToLower().Equals("plovdiv") || town.ToLower().Equals("varna"); // ако не е изпълнено условието не въртим програмата.

            if (hasStore)
            {

            
                switch (town.ToLower())
            {
                case "sofia":
                    switch (product.ToLower())
                    {
                        case "coffee":
                            break;
                        case "water":
                            break;
                        case "beer":
                            break;
                        case "sweets":
                            break;
                        case "peanuts":
                            break;

                    }

                    break;
                case "plovdiv":
                    break;
                case "varna":
                    break;
                default:
                    Console.WriteLine("No store in this town.");
                    break;
                }
           }
            else Console.WriteLine("No store in this town.");
        }
    }
}
