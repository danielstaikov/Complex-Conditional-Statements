using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            bool hasStore = town.ToLower().Equals("sofia") || town.ToLower().Equals("plovdiv") || town.ToLower().Equals("varna"); // ако не е изпълнено условието не въртим програмата.
            decimal result = 0;

            if (hasStore)
            {

                switch (town.ToLower())
                {
                    case "sofia":
                        switch (product.ToLower())
                        {
                            case "coffee":
                                result = quantity * 0.5m;
                                break;
                            case "water":
                                result = quantity * 0.8m;
                                break;
                            case "beer":
                                result = quantity * 1.2m;
                                break;
                            case "sweets":
                                result = quantity * 1.45m;
                                break;
                            case "peanuts":
                                result = quantity * 1.60m;
                                break;
                        }
                        break;
                    case "plovdiv":
                        switch (product.ToLower())
                        {
                            case "coffee":
                                result = quantity * 0.4m;
                                break;
                            case "water":
                                result = quantity * 0.7m;
                                break;
                            case "beer":
                                result = quantity * 1.15m;
                                break;
                            case "sweets":
                                result = quantity * 1.30m;
                                break;
                            case "peanuts":
                                result = quantity * 1.50m;
                                break;
                        }
                        break;
                    case "varna":
                        switch (product.ToLower())
                        {
                            case "coffee":
                                result = quantity * 0.45m;
                                break;
                            case "water":
                                result = quantity * 0.7m;
                                break;
                            case "beer":
                                result = quantity * 1.1m;
                                break;
                            case "sweets":
                                result = quantity * 1.35m;
                                break;
                            case "peanuts":
                                result = quantity * 1.55m;
                                break;
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("No store in this town.");
            }
               Console.WriteLine("{0}",result);
            }
         }
    }
