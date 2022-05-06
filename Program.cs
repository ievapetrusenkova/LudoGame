using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ludo.Game
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("\n Each player rolls a die; the highest roller begins the game!");
            Console.WriteLine($" <<<<<<<<<<<< LETS START THE GAME >>>>>>>>>>>>\n");
            //string[] players = new string[] { "Blue", "Green", "Red", "Yellow" };
            Random random = new Random();

            //FirstRoll();

            Player player1 = new Player(1, "player1", Player.Colors.Green, 0, 6, 0);
            Player player2 = new Player(2, "player2", Player.Colors.Yellow, 0, 12, 0);
            Player player3 = new Player(3, "player3", Player.Colors.Blue, 0, 2, 0);
            Player player4 = new Player(4, "player4", Player.Colors.Red, 0, 2, 0);

            List<Player> PlayerList = new List<Player>();
            PlayerList.Add(player1);
            PlayerList.Add(player2);
            PlayerList.Add(player3);
            PlayerList.Add(player4);

            foreach (Player player in PlayerList)
            {
                player.InitialDiceRoll = random.Next(1, 7);
                Console.WriteLine($"{player.colors} rolled : {player.InitialDiceRoll}");
            }
            
            var HighestRoll = PlayerList.MaxBy(x => x.InitialDiceRoll);

            List<Player> temp = PlayerList.Where(x => x.InitialDiceRoll == HighestRoll.InitialDiceRoll).ToList();
            Console.WriteLine("Rerolling.....");
            if (temp.Count > 1)
            {
                foreach (Player player in temp)
                {
                    player.InitialDiceRoll = random.Next(1, 7);
                    Console.WriteLine($"{player.colors} rolled : {player.InitialDiceRoll}");
                }
                
                HighestRoll = PlayerList.MaxBy(x => x.InitialDiceRoll);
            }
            Console.WriteLine($"{HighestRoll.colors} starts the game!");

            

            int firstToStartGame = HighestRoll.Id; //this is my addition,
                                                   //if you could run it and see if it was needed but at least I tried :D

            bool correct = true;
            do
            {
                Console.WriteLine($" {HighestRoll.colors} (player ID: {firstToStartGame}) rolled {RollDice()}");

                if (firstToStartGame == player1.Id) {  correct = true; }
                else if (firstToStartGame == player2.Id) { correct = true; }
                else if (firstToStartGame == player3.Id) {  correct = true; }
                else if (firstToStartGame == player4.Id) {  correct = true; }

                else correct = false;
            }
            while (!correct);

            int activePlayer = firstToStartGame;


            //Console.WriteLine($"get High roller id if red");
            //if (HighestRoll.colors == Player.Colors.Red)
            //{
            //    Console.WriteLine($"{HighestRoll.Id}");
            //}


            //foreach (Player.Colors colors in Enum.GetValues(typeof(Player.Colors)))
            //{
            //    Console.WriteLine(colors.ToString());
            //    if (HighestRoll.colors == Player.Colors.Red)
            //    {
            //        Console.WriteLine(HighestRoll.Id);
            //    }
            //}



            //    int[] player = new int[players.Length];
            //    int playerBlue = 0;
            //    int playerGreen = 0;
            //    int playerRed = 0;
            //    int playerYellow = 0;

            //    for (int i = 0; i < players.Length; i++)
            //    {
            //        Console.WriteLine(" Press any key to roll the dice.");
            //        Console.ReadKey();

            //        playerBlue = random.Next(1, 7);
            //        Console.WriteLine($" BLUE rolled a  " + playerBlue);
            //        if (playerBlue == 1 || playerBlue == 6)
            //        {
            //            Console.WriteLine($" Roll the dice again!");  //BLOCKER - if rolled 1 or 6 again?
            //            //RollDice();
            //        }
            //        else
            //        {
            //            Console.WriteLine($" Next player's turn! ");
            //        }
            //        Console.WriteLine("...");
            //        Thread.Sleep(1000);

            //        playerGreen = random.Next(1, 7);
            //        Console.WriteLine(" GREEN rolled a " + playerGreen);
            //        if (playerGreen == 1 || playerGreen == 6)
            //        {
            //            Console.WriteLine($" Roll the dice again!");
            //            Console.WriteLine(random.Next(1, 7));

            //        }
            //        else
            //        {
            //            Console.WriteLine($" Next player's turn! ");
            //        }
            //        Console.WriteLine("...");
            //        Thread.Sleep(1000);

            //        playerRed = random.Next(1, 7);
            //        Console.WriteLine(" RED rolled a " + playerRed);
            //        if (playerRed == 1 || playerRed == 6)
            //        {
            //            Console.WriteLine($" Roll the dice again!");
            //            Console.WriteLine(random.Next(1, 7));

            //        }
            //        else
            //        {
            //            Console.WriteLine($" Next player's turn! ");
            //        }
            //        Console.WriteLine("...");
            //        Thread.Sleep(1000);

            //        playerYellow = random.Next(1, 7);
            //        Console.WriteLine(" YELLOW rolled a " + playerYellow);
            //        if (playerYellow == 1 || playerYellow == 6)
            //        {
            //            Console.WriteLine($" Roll the dice again!");
            //            Console.WriteLine(random.Next(1, 7));

            //        }
            //        else
            //        {
            //            Console.WriteLine($" Next player's turn! ");
            //        }
            //        Console.WriteLine("...");
            //        Thread.Sleep(1000);
            //    }

            //}
            //public static void RollTheDice()
            //{
            //    string[] players = new string[] { "Blue", "Green", "Red", "Yellow" };
            //    Random random = new Random();
            //    foreach(string player in players)
            //    {
            //        int roll = random.Next(1, 7);
            //        Console.WriteLine($"{player} {roll}");
            //    }

            //}

            //public static void FirstRoll()
            //{
            //    Random rand = new Random();
            //    int[] myArray = new int[4];

            //    for (int i = 0; i < 4; i++)
            //    {
            //        myArray[i] = rand.Next(1, 7);
            //        Console.WriteLine(myArray[i]);
            //    }

            //    var (score, index) = myArray.Select((s, i) => (s, i)).Max(); //BLOCKER FOR TESTING - what happens if two numbers are equal?
            //    Console.WriteLine($" Highest roll = {score}, on index {index}.");//MY BLOCKER - how to assign player to highest roll?
            //    Console.WriteLine($" {myArray.Max()} starts first!");


            static int RollDice()
            {
                Random num = new Random();
                int Number = num.Next(1, 7);
                Console.WriteLine(Number);

                return Number;
            }
        }
    }
}


