using System;
using System.Threading;

namespace Roshambo
{
    class Program
    {
        public static int score = 0;
        public static string[] weapons = {"Laser", "Rock", "Paper", "Scissors" };
        static void Main(string[] args)
        {
            Intro();
            Menu();
        }


        public static void rockArt()
        {
            Console.WriteLine("      _______");
            Console.WriteLine("-- - '   ____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (_____)");
            Console.WriteLine("      (____)");
            Console.WriteLine("-- -.__(___)");
        }

        public static void paperArt()
        {
            Console.WriteLine("       _______");
            Console.WriteLine("-- - '    ____)__");
            Console.WriteLine("           ______)");
            Console.WriteLine("          _______)");
            Console.WriteLine("         _______)");
            Console.WriteLine("---.__________)");
        }

        public static void scissorArt()
        {
            Console.WriteLine("    _______");
            Console.WriteLine("---'   ____)____");
            Console.WriteLine("          ______)");
            Console.WriteLine("       __________)");
            Console.WriteLine("      (____)");
            Console.WriteLine("---.__(___)");
        }


        // Generate a random number between two numbers  
        public static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        public static int GameLogic(int playerInput, int aiInput)
        {
            int result =0 ;

            // Draw
            if(playerInput == aiInput)
            {
                result = 0;
            }
            // Rock
            else if(playerInput == 1 && aiInput == 2) {
                Console.WriteLine("Paper covers rock.. PC Wins");
                result = 2;
            }
            else if(playerInput ==1 && aiInput == 3)
            {
                Console.WriteLine("Rock smashes scissors..");
                result = 1;
            }
            // Paper
            else if(playerInput == 2 && aiInput == 1)
            {
                Console.WriteLine("Paper covers rock");
                result = 1;
            }
            else if(playerInput == 2 && aiInput == 3)
            {
                Console.WriteLine("Scissors cuts paper.. PC Wins");
                result = 2;
            }
            // Scissors
            else if(playerInput == 3 && aiInput == 1)
            {
                Console.WriteLine("Rock smashes scissors.. PC Wins");
                result = 2;
            }
            else if(playerInput == 3 && aiInput == 2)
            {
                Console.WriteLine("Scissors cuts paper");
                result = 1;
            }
            return result;
        }

        public static void playGame()
        {
            string selection = null;
            Console.Clear();
            Console.WriteLine("To play please enter a number corresponding to the options below:");
            Console.WriteLine("1. Rock\n2. Paper\n3. Scissors");

            // Take input
            //while (selection != "1" || selection != "2" || selection != "3")
           // {
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

            // }
            /*if (GameLogic(int.Parse(selection)))
            {
                //p1.SetHighScore(+1);
                Console.WriteLine("You Win!!");
            }
            pause(2);
            Console.Clear();*/

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
            string msg = "Please select from the menu options below:";

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
            // Intro animation
            Console.Clear();
            rockArt();
            pause(1);
            Console.Clear();
            paperArt();
            pause(1);
            Console.Clear();
            scissorArt();
            pause(1);
            Console.Clear();

            Console.WriteLine("Welcome to Roshambo");
            pause(1);
            Console.WriteLine("    The game of..");
            pause(1);
            Console.Write("Rock");
            pause(1);
            Console.Write("\tPaper");
            pause(1);
            Console.Write("\tScissors");

            player p1 = new player();
            Console.WriteLine("\nPlease enter your name:");
            string playerName = Console.ReadLine();
            pause(1);
            p1.SetPlayerName(playerName);
            p1.SetHighScore(0);
            Console.WriteLine($"Welcome {p1.GetPlayerName()}");
            pause(2);
            Console.Clear();
        }


    }
}

/*Here's some random ideas..
    Use VisualStudio as an email editor to benefit from a custom controlled intellisense ;)
    
     Practice using computers without a mouse at every opportunity

    Write code.. Lots of code. Benefit from the lessons of writing music, don't mess around with tutes. Get in there and code!!
     */