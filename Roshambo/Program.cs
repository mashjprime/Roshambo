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

        public static void Menu()
        {
            string menuInput = null;            
            String[] menuOptions;
            int wrongSelectionCount = 0;
            
            menuOptions = new string[3];
            menuOptions[0] = "1. Play Game";
            menuOptions[1] = "2. High Score";
            menuOptions[2] = "3. Exit";
           
            // Display options
            Console.WriteLine("\n\nPlease select from the menu options below:");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine(menuOptions[i]);
            }
            
            // Take input
            while(menuInput != "exit")
            {
                menuInput = Console.ReadLine();
                
                switch (menuInput)
                {
                    case "1":
                        Console.WriteLine("Test");
                        break;
                    case "2":
                        Console.WriteLine("High Score!!");
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
            Thread.Sleep(500);
            Console.WriteLine("    The game of..");
            Thread.Sleep(500);
            Console.Write("Rock");
            Thread.Sleep(500);
            Console.Write("\tPaper");
            Thread.Sleep(500);
            Console.Write("\tScissors");
        }


    }
}
