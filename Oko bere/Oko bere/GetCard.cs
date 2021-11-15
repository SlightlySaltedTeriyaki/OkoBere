using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oko_bere
{
    class GetCard
    {
        static public int RandomCard()
        {
            Random number = new Random();
            int[] cards = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11 };
            int card = cards[number.Next(0, 31)];
            return card;
        }

    }
}
