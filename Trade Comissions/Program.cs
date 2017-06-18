using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string sity = Console.ReadLine().ToLower();
            decimal sales = decimal.Parse(Console.ReadLine());
            decimal commision = -1;
            decimal result = 0;
            if (0 <= sales && sales <= 500)
            {
                switch (sity)
                {
                    case "sofia":
                        commision = 0.05m;
                        break;
                    case "plovdiv":
                        commision = 0.055m;
                        break;
                    case "varna":
                        commision = 0.045m;
                        break;
                }
            }
            else if (500 < sales && sales <= 1000)
            {
                switch (sity)
                {
                    case "sofia":
                        commision = 0.07m;
                        break;
                    case "plovdiv":
                        commision = 0.08m;
                        break;
                    case "varna":
                        commision = 0.075m;
                        break;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                switch (sity)
                {
                    case "sofia":
                        commision = 0.08m;
                        break;
                    case "plovdiv":
                        commision = 0.12m;
                        break;
                    case "varna":
                        commision = 0.10m;
                        break;
                }
            }
            else if (sales > 10000)
            {
                switch (sity)
                {
                    case "sofia":
                        commision = 0.12m;
                        break;
                    case "plovdiv":
                        commision = 0.145m;
                        break;
                    case "varna":
                        commision = 0.13m;
                        break;
                }
            }
            result = sales * commision;
          if (commision != -1)
            {
              Console.WriteLine("{0:f2}",result);
                    
            }
            else
            {
                Console.WriteLine("error");
            }

           }
        }

}