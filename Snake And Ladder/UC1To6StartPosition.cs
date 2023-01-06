using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    internal class UC1StartPosition
    {
        public static int PositionZero()
        {
            int count = 0;
            int position= 0;
            while (position < 100)
            {
             count = count+ 1;
             Random random= new Random();
             int checkDice = random.Next(1, 7);
             position= position + checkDice;
             int check = random.Next(0,3);
             if(check == 1)
                {
                    position = position + 10; ;
                }
             if(check == 2)
                {
                    position = position - 10; ;
                }
            
              
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
