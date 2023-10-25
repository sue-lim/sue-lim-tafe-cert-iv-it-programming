using System;

namespace Roll_Two_Dices_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Two Dice Game";
            Random numberGen = new Random();

            int rollOne;
            int rollTwo;
            int attempt = 0;
            string name;

            Console.WriteLine("Roll 2 dice.\nGame ends if the dice match.\n");
            Console.Write("What's your name? \n");
            name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue; // Set text color to blue
            Console.WriteLine("Hi, " + name + ". \n\nLet's Play! \nPress enter to roll the dice.");
            Console.ResetColor(); // Reset text color to default

            do
            {
                Console.ReadKey();
                rollOne = numberGen.Next(1, 7);
                rollTwo = numberGen.Next(1, 7);
                Console.WriteLine("Roll 1: " + rollOne);
                Console.WriteLine("Roll 2: " + rollTwo);
                attempt++;
            } while (rollOne != rollTwo);


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("It took you " + attempt + " attempts.");
            Console.ReadKey();
        }
    }
}
