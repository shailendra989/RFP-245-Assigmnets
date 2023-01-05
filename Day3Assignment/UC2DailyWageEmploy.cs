using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    internal class UC2DailyWageEmploy
    {
        public static void  dailywage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHRS = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck == IS_FULL_TIME)
            {
                empHRS = 8;
            }
            else
            {
                empHRS = 0;
            }
            empWage = empHRS * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp wage is - :"  +empWage);


        }
    }
}
