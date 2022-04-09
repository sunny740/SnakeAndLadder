using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class SnakeAndLadderGames
    {
        const int position = 0;
        public int DieRoll()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            return roll;
        }
    }
}
