using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    internal class UC7TwoPlayerGame
    { 
        public static void twoPlayer()
        {
            int player1count = UC1StartPosition.PositionZero();
            int player2count = UC1StartPosition.PositionZero();
            if(player1count > player2count)
            {
                Console.WriteLine("player 2 win");
            }
            else
            {
                Console.WriteLine("player 1 win");
            }
        }
    }
}
