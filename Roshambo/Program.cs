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
            //int selection;
            string menuInput;            
            String[] menuOptions;
            menuOptions = new string[3];
            menuOptions[0] = "1. Play Game";
            menuOptions[1] = "2. High Score";
            menuOptions[2] = "3. Exit";

            Console.WriteLine("\n\nPlease select from the menu options below:");

            for(int i = 0; i < menuOptions.Length; i++)
            {
                Console.WriteLine(menuOptions[i]);
            }
            Environment.Exit(0);
            menuInput = Console.ReadLine();
            while(menuInput != null)
            {
                menuInput = Console.ReadLine();
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
