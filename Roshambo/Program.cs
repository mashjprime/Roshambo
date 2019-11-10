using System;

namespace Roshambo
{
    class Program
    {
        public static int score = 0;
        public static string[] weapons = { "Laser", "Rock", "Paper", "Scissors" };
        static void Main(string[] args)
        {
            Interface.Intro();
            Interface.Menu();
        }



        public static void PlayGame()
        {
            while (true)
            {
                string selection;
                int aiSelection = Function.RandomNumber();
                Console.Clear();
                Console.WriteLine("Please select:");
                Console.WriteLine("1. Rock\n2. Paper\n3. Scissors\n4. Quit");

                selection = Console.ReadLine();

                Console.WriteLine("\nYou...");

                if (selection == "4")
                {
                    break;
                }
                switch (selection)
                {
                    case "1":
                        Gfx.rockArt();
                        Console.WriteLine("Rock");
                        break;
                    case "2":
                        Gfx.paperArt();
                        Console.WriteLine("Paper");
                        break;
                    case "3":
                        Gfx.scissorArt();
                        Console.WriteLine("Scissors");
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }

                Console.WriteLine("\n\nVS\n\n");

                Console.WriteLine("Artificial Intelligence");

                switch (aiSelection)
                {
                    case 1:
                        Gfx.rockArt();
                        Console.WriteLine("Rock");
                        break;
                    case 2:                       
                        Gfx.paperArt();
                        Console.WriteLine("Paper");
                        break;
                    case 3:
                        Gfx.scissorArt();
                        Console.WriteLine("Scissors");
                        break;
                }

                int weapon = GameLogic.GetWinner(int.Parse(selection), aiSelection);
                if (weapon == 0)
                {
                    Console.WriteLine("Draw!!");
                }
                else if (weapon == (int.Parse(selection)))
                {
                    Console.WriteLine("You win!!");
                    //p1.SetHighScore(1);
                }
                else
                {
                    Console.WriteLine("You lose..");
                }
                Function.pause(4);
            }

        }
    }
}