using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Interface
    {

        public static void Intro()
        {
            // Intro animation
            Console.Clear();
            Gfx.rockArt();
            Function.pause(2);
            Console.Clear();
            Gfx.paperArt();
            Function.pause(2);
            Console.Clear();
            Gfx.scissorArt();
            Function.pause(2);
            Console.Clear();

            Console.WriteLine("Welcome to Roshambo");
            Function.pause(1);
            Console.WriteLine("    The game of..");
            Function.pause(1);
            Console.Write("Rock");
            Function.pause(1);
            Console.Write("\tPaper");
            Function.pause(1);
            Console.Write("\tScissors");


            Console.WriteLine("\nPlease enter your name:");
            Program.p1.PlayerName = (Console.ReadLine());
            Function.pause(1);
            Console.WriteLine($"Welcome {Program.p1.PlayerName}");
            Function.pause(2);
            Console.Clear();
        }

        public static void Menu()
        {
            string menuInput = null;
            String[] menuOptions;
            menuOptions = new string[3];
            menuOptions[0] = "Play Game";
            menuOptions[1] = "High Score";
            menuOptions[2] = "Exit";

            // Display options
            string msg = "Please select from the menu options below:";

            for (int i = 0; i < menuOptions.Length; i++)
            {
                msg += ("\n" + (i + 1) + ". " + menuOptions[i]);
            }

            // Take input
            while (menuInput != "exit")
            {
                Console.Clear();
                Console.WriteLine(msg);
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        Program.PlayGame();
                        break;
                    case "2":
                        HighScore();
                        break;
                    case "3":
                        menuInput = "exit";
                        //Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }
        }

        public static void Shutdown()
        {
            Console.WriteLine($"Thank you for playing {Program.p1.PlayerName}");
            Function.pause(2);
            Console.WriteLine("Shutting down..");
            Function.pause(2);
            Console.Clear();
        }

        public static void HighScore()
        {
            Console.WriteLine("HighScore");
            Console.WriteLine(Program.p1.PlayerName);
            Console.WriteLine("Win:  " + Program.p1.WinCount);
            Console.WriteLine("Draw: " + Program.p1.DrawCount);
            Console.WriteLine("Lose: " + Program.p1.LoseCount);
            Function.pause(5);
        }


    }
}
