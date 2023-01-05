using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Day3Asssignment2
{
    internal class UC3GreaterOrLess
    {
        public static void LengthComparison()
        {
            double x1 = 93;
            double x2 = 518;
            double y1 = 49;
            double y2 = 86;

            double l1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            Console.WriteLine(l1);

            double a1 = 91;
            double a2 = 118;
            double b1 = 96;
            double b2 = 119;

            double l2 = Math.Sqrt((Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2)));
            Console.WriteLine(l2);

            if(l1==l2)
            {
                Console.WriteLine("both are equal");
            }
            else if(l1>l2)
            {
                Console.WriteLine("l1 is bigger");
            }
            else
            {
                Console.WriteLine("l2 is bigger");
            }
        }

    }
}
