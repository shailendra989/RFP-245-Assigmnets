using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Day3Asssignment2
{
    internal class UC1CalculateLength
    {
        public static void Length()
        {
            double x1 = 7;
            double x2 = 10;
            double y1 = 14;
            double y2 = 18;

            double length = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            Console.WriteLine(length);

        }
    }
}
