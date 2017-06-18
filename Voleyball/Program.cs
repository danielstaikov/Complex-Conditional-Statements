using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първият ред съдържа думата “leap” (високосна година) или “normal” (невисокосна).
            //Вторият ред съдържа цялото число p – брой празници в годината (които не са събота и неделя).
            //Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.

            string leap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int allWeekend = 48;
            int sofiaWeekend = allWeekend - h;
            decimal gameInSofia = sofiaWeekend * 3.0m / 4;
            decimal gameInHoliday = p * 2.0m / 3;
            decimal allGame = gameInHoliday + gameInSofia + h;

            switch (leap)
            {
                case "leap":
                    allGame *= 1.15m;
                        break;
            }
            Console.WriteLine("{0}", Math.Floor(allGame));
        }
    }
}
