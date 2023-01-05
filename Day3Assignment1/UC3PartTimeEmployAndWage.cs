using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    internal class UC3PartTimeEmployAndWage
    {
        public static void partTimeWage()
        {
            int PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHRS = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == PART_TIME)
            {
                empHRS = 4;
            }
            else if(empCheck == IS_FULL_TIME )
            {
                empHRS = 8;
            }
            else
            {
                empHRS = 0;
            }

            empWage = empHRS * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp wage is - :" + empWage);
        }
    }
}
