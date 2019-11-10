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
            Function.pause(1);
            Console.Clear();
            Gfx.paperArt();
            Function.pause(1);
            Console.Clear();
            Gfx.scissorArt();
            Function.pause(1);
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

            player p1 = new player();
            Console.WriteLine("\nPlease enter your name:");
            string playerName = Console.ReadLine();
            Function.pause(1);
            p1.SetPlayerName(playerName);
            p1.SetHighScore(0);
            Console.WriteLine($"Welcome {p1.GetPlayerName()}");
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
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }
        }

        public static void HighScore()
        {
            Console.WriteLine("HighScore!!");
            Function.pause(2);
        }


    }
}
