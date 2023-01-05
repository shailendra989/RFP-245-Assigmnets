using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment
{
    internal class UC6TotalWorkingHour
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 10;
        public static void workinghour()
        {
            int empHrs = 0;
            int totalemphrs = 0;
            int totalworkingDays = 0;

         while(totalemphrs <=MAX_HRS_IN_MONTH && totalworkingDays < NUM_OF_WORKING_DAYS)
            {
                totalworkingDays++;
                Random random= new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalemphrs += empHrs;
                Console.WriteLine("Day# :" + totalworkingDays + "emp hrs : " + empHrs);

         }
            int totalempWage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("TOTAL EMPLOY WAGE IS :"+ totalempWage);


        }

    }
}
