using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int height = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x1 = 0;
            int y1 = 0;
            int x2 = 3*height;
            int y2 = height;
            int x3 = height;
            int y3 = height;
            int x4 = 2* height;
            int y4 = 4* height;

            bool istOnBorder1 = (x1 == x || x == x2) && (y1 <= y && y <= y2) || (y1 == y || y == y2) && (x1 <= x && x <= x2); // на линията на фигура 1
            //Console.WriteLine("istOnBorder1 {0}", istOnBorder1);
            bool istInFigure1 = (x1 < x && x < x2) && (y1 < y && y < y2);// във фигура 1
            //Console.WriteLine("istInFigure1 {0}", istInFigure1);
            bool istOnBorder2 = (x3 == x || x == x4) && (y3 <= y && y <= y4) || (y3 == y || y == y4) && (x3 <= x && x <= x4);// на линията на фигура 2
            //Console.WriteLine("istOnBorder2 {0}", istOnBorder2);
            bool istInFigure2 = (x3 < x && x < x4) && (y3 < y && y < y4);// във фигура 2
            //Console.WriteLine("istInFigure2 {0}", istInFigure2);
            bool exeption = !((x3 < x && x < x4) && y == y3);
            //Console.WriteLine("exeption {0}", exeption);

            bool istOnBorder = (istOnBorder1 || istOnBorder2) && exeption;
            //Console.WriteLine("istOnBorder {0}", istOnBorder);
            bool istInFigure = istInFigure1 || istInFigure2 || !exeption;
            //Console.WriteLine("istInFigure {0}", istInFigure);

            if (istOnBorder)
            {
                Console.WriteLine("Border");
            }
            else if (istInFigure)
                 {
                Console.WriteLine("Inside");
                 }
            else
                {
                Console.WriteLine("Outside");
                }
            
        }
    }
}
