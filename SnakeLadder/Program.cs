using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake Ladder!");
            int playerPosition = 0, diceRoll;
            Random rand = new Random();
            diceRoll = rand.Next(1, 7);
            Console.WriteLine("Number appeared on dice is : " + diceRoll);
        }
    }
}
