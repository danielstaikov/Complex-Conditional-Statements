using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpans
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Define a time interval equal to two hours.
                TimeSpan baseInterval = new TimeSpan(2, 0, 0);

                // Define an array of time intervals to compare with
                // the base interval.
                TimeSpan[] spans = { TimeSpan.FromSeconds(-2.5),
                             TimeSpan.FromMinutes(20),
                             TimeSpan.FromHours(1),
                             TimeSpan.FromMinutes(90),
                             baseInterval,
                             TimeSpan.FromDays(.5),
                             TimeSpan.FromDays(1) };

                // Compare the time intervals.
                foreach (var span in spans)
                {
                    int result = TimeSpan.Compare(baseInterval, span);
                    Console.WriteLine("{0} {1} {2} (Compare returns {3})",
                                      baseInterval,
                                      result == 1 ? ">" : result == 0 ? "=" : "<",
                                      span, result);
                }
            }
        }
    }
    }
}
