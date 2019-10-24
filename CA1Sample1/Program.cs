using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA1Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 5
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            // Question 6
            List<Player> allPlayers = new List<Player>();
            allPlayers.Add(player1);
            allPlayers.Add(player2);
            allPlayers.Add(player3);
            allPlayers.Add(player4);
            allPlayers.Add(player5);

            //player1.IncreaseScore(1);
            // player2.IncreaseScore(10);

            Display(allPlayers);

            // Question 9
            GetScores(allPlayers);


            // Question 11
            WriteLine("\n***** Players Displayed with no order *****");
            DisplayPlayerDetails(allPlayers);

            // Question 13
            WriteLine("\n***** Players Displayed Sorted by Score *****");
            allPlayers.Sort();
            DisplayPlayerDetails(allPlayers);

            WriteLine("\n***** Players Displayed Sorted by Score Reversed *****");
            allPlayers.Reverse();
            DisplayPlayerDetails(allPlayers);

            // Question 14
            WriteLine($"The Highest score is {Player.HighScore}");

        }

        // Question 9
        private static void GetScores(List<Player> allPlayers)
        {
            Write("\nPlease enter number of player you wish to add score for >> ");
            string response = ReadLine();
            int playerNumber = int.Parse(response);

            while (playerNumber != 0)
            {
                Player selectedPlayer = allPlayers.ElementAt(playerNumber - 1); // Use -1 as index starts at 0

                selectedPlayer.IncreaseScore(1);

                Display(allPlayers);

                Write("\nPlease enter number of player you wish to add score for >> ");
                response = ReadLine();
                playerNumber = int.Parse(response);

            }// end of while loop
        }

        // Question 8
        private static void Display(List<Player> players)
        {
            WriteLine("{0, -15}{1, -15}{2, -15}{3, -15}{4, -15}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");

            foreach ( Player player in players)
            {
                Write("{0, -15}", player.Score);
            }

        }

        // Question 11
        private static void DisplayPlayerDetails(List<Player> players)
        {
            WriteLine($"\n{"ID"}\t{"Name"}\t{"Score"}");
            foreach (Player player in players)
            {
                WriteLine(player);
            }
        }
       
    }
}
