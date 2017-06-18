using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myBoolA = true;
            bool myBoolB = true;

            Console.WriteLine("Are both Booleans true? {0}",
                myBoolA || myBoolB);

        }
    }
}
