using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA1Sample1
{
    public class Player : IComparable
    {
        // Question 2
        public int PlayerID { get; }
        public string PlayerName { get; set; }
        public int Score { get; private set; }

        public static int HighScore { get; private set; }

        // Question 3 + 4
        public Player(int playerID, string playerName, int score)
        {
            PlayerID = playerID;
            PlayerName = playerName;
            Score = score;
        }

        // Question 7
        public void IncreaseScore(int addScore)
        {
            if (Score < 100)
            Score += addScore;

            // Question 10
            if (Score > HighScore)
                HighScore = Score;
        }

        // Question 11
        public override string ToString()
        {
            return $"{PlayerID}\t{PlayerName}\t{Score}";
        }

        // Question 12
        public int CompareTo(object obj)
        {
            Player objectThatIAmComparingTo = obj as Player;
            int returnValue = this.Score.CompareTo(objectThatIAmComparingTo.Score);
            return returnValue;
        }


    }
}
