using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Game
{
    public class Player
    {
        public enum Colors
        {
            Green,
            Yellow,
            Blue,
            Red,
        }
        public enum Pawns
        {
            One,
            Two,
            Three,
            Four
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public Colors colors { get; set; }
        public int StartingPosition { get; set; }
        public int EndingPosition { get; set; }
        public int InitialDiceRoll { get; set;}

        public Player(int id,string name, Colors colors, int startingposition, int endingposition, int initialdiceroll)
        {
            this.Id = id;
            this.Name = name;
            this.colors = colors;
            this.StartingPosition = startingposition;
            this.EndingPosition = endingposition;
            this.InitialDiceRoll = initialdiceroll;
        }
        //public void FirstRoll()
        //{

        //    Random rand = new Random();
        //    Player[] PlayerArray = new Player[4];
            
        //    for (int i = 0; i < 4; i++)
        //    {
        //        initialdiceroll = rand.Next(1, 7);
        //        Console.WriteLine(initialdiceroll);

        //    }

        //    var (score, index) = myArray.Select((s, i) => (s, i)).Max(); //BLOCKER FOR TESTING - what happens if two numbers are equal?
        //    Console.WriteLine($" Highest roll = {score}, on index {index}.");//MY BLOCKER - how to assign player to highest roll?

        //}
    }   
}

