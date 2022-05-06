using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Game
{
    public class Game
    {
        public string PlayerBlue { get; set; }
        public string PlayerGreen { get; set; }
        public string PlayerRed { get; set; }
        public string PlayerYellow { get; set; }

        public Game(string Blue, string Green, string Red, string Yellow )
        {
            PlayerBlue = Blue;
            PlayerGreen = Green;
            PlayerRed = Red;
            PlayerYellow = Yellow;
        }
        
        public static int RollDice()
        {
            Random num = new Random();
            int Number = num.Next(1, 7);

            return Number;

        }
        
        public static void RollTheDice()
        {
            string[] players = new string[] { "Blue", "Green", "Red", "Yellow" };
            Dictionary<string,int> firstRoll= new Dictionary<string,int>();  
            Random random = new Random();
            for (int i = 0; i < players.Length; i++)
            {
                int roll = random.Next(1, 7);
                //Console.WriteLine($"{players[i]} {roll}");
                firstRoll.Add(players[i], roll);

            }
            foreach(var player in firstRoll)
            {
                Console.WriteLine($"{player.Key} {player.Value}");

            }
        }
        

    }
    
}

