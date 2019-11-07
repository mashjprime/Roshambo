using System;
using System.Threading;

namespace Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Menu();
        }

        public static void playGame()
        {
            player p1 = new player();
            string selection = null;

            Console.WriteLine("Please enter your name:");
            string playerName = Console.ReadLine();
            p1.SetPlayerName(playerName);
            p1.SetHighScore(0);
            Console.WriteLine($"Welcome {p1.GetPlayerName()}");
            Console.WriteLine("\nTo play please enter a number corresponding to the options below:");
            Console.WriteLine("1. Rock\n2. Paper\n3. Scissors");
            pause(2);
            Console.WriteLine("Ready?");
            Console.ReadLine();
            Console.Write("Rock");
            pause(1);
            Console.Write("\tPaper");
            pause(1);
            Console.Write("\tScissors");

            // Take input
            while (selection != "exit")
            {
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Rock");
                        break;
                    case "2":
                        Console.WriteLine("Paper");
                        break;
                    case "3":
                        Console.WriteLine("Scissors");
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }

            }
        }
        public static void highScore()
        {
            Console.WriteLine("HighScore!!");
            pause(2);
        }

        public static void pause(int x)
        {
            x = x * 1000 / 2;
            Thread.Sleep(x);
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
            string msg = "\n\nPlease select from the menu options below:";

            for (int i = 0; i < menuOptions.Length; i++)
            {
                msg+=("\n" + (i+1) +". " + menuOptions[i]);
            }
            
            // Take input
            while(menuInput != "exit")
            {
                Console.WriteLine(msg);
                menuInput = Console.ReadLine();
                
                switch (menuInput)
                {
                    case "1":
                        playGame();
                        break;
                    case "2":
                        highScore();
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

        public static void Intro()
        {
            Console.WriteLine("Welcome to Roshambo");
            pause(1);
            Console.WriteLine("    The game of..");
            pause(1);
            Console.Write("Rock");
            pause(1);
            Console.Write("\tPaper");
            pause(1);
            Console.Write("\tScissors");
        }


    }
}

/*Here's some random ideas..
    Use VisualStudio as an email editor to benefit from a custom controlled intellisense ;)
    
     Practice using computers without a mouse at every opportunity

    Write code.. Lots of code. Benefit from the lessons of writing music, don't mess around with tutes. Get in there and code!!
     */