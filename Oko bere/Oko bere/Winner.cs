using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oko_bere
{
    class Winner
    {
        static public string Weiner(int nearest, int player1, int player2, int player3, int player4, int player5, int player6, string name1, string name2, string name3, string name4, string name5, string name6)
        {
            string winner;
            if (nearest == player1 && player1 <= 21)
            {
               winner = name1;
            }
            else if (nearest == player2 && player2 <= 21)
            {
                winner = name2;
            }
            else if (nearest == player3 && player3 <= 21)
            {
                winner = name3;
            }
            else if (nearest == player4 && player4 <= 21)
            {
                winner = name4;
            }
            else if (nearest == player5 && player5 <= 21)
            {
                winner = name5;
            }
            else if (nearest == player6 && player6 <= 21)
            {
                winner = name6;
            }
            else
            {
                winner = "" ;
            }

            return winner;
        }
    }
}
