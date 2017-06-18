using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());
            string exam = ( hourExam + ":"+ minuteExam);
            string arrive = (hourArrive + ":" + minuteArrive);

            DateTime examTime = DateTime.Parse(exam);
            DateTime arriveTime = DateTime.Parse(arrive);
            TimeSpan DurationMinus60 = TimeSpan.FromMinutes(-60);
            TimeSpan Duration60 = TimeSpan.FromMinutes(60);
            TimeSpan Duration30 = TimeSpan.FromMinutes(30);
            TimeSpan difference = examTime - arriveTime;

            int difMinutes = int.Parse(difference.Minutes.ToString());
            int difHours = int.Parse(difference.Hours.ToString());

            if (difference <= DurationMinus60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1:00} hours after the start", Math.Abs(difHours), Math.Abs(difMinutes));
            }
            else if (-60 < difMinutes  && difMinutes < 0)
                {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", Math.Abs(difMinutes));
                }
            else if (difference > Duration30 && difference < Duration60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", Math.Abs(difMinutes));
                }
            else if (difference <= Duration30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", Math.Abs(difMinutes));
                 }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", Math.Abs(difHours), Math.Abs(difMinutes));
                }
                }

        }
    }
