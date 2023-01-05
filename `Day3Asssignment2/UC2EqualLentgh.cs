using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Day3Asssignment2
{
    internal class UC2EqualLentgh
    {
        public static void CompareLentgh()
        {
            double x1 = 9;
            double x2 = 18;
            double y1 = 19;
            double y2 = 26;

            double l1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            Console.WriteLine(l1);

            double a1 = 9;
            double a2 = 18;
            double b1 = 16;
            double b2 = 19;

            double l2 = Math.Sqrt((Math.Pow((a2 - a1),2) + Math.Pow((b2- b1), 2)));
            Console.WriteLine(l2);

            if(l1 == l2)
            {
                Console.WriteLine("both are equal");
            }
            else
            {
                Console.WriteLine("both are different");
            }
        }

    }
}
