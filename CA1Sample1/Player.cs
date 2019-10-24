using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA1Sample1
{
    class Player
    {
        // Question 2
        private int PlayerID { get; }
        private string PlayerName { get; set; }
        private int Score { get; set; }

        // Question 3
        public Player(int playerID, string playerName, int score)
        {
            PlayerID = playerID;
            PlayerName = playerName;
            Score = score;
        }
    }
}
