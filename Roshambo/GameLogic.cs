using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class GameLogic
    {

        public static int GetWinner(int playerInput, int aiInput)
        {
            int result;

            // Console.WriteLine("Rock smashes scissors..");
            if ((playerInput == 1 && aiInput == 3) || (playerInput == 3 && aiInput == 1))
            {
                result = 1;
            }
            // Consol(e.WriteLine("Paper covers rock");
            else if ((playerInput == 2 && aiInput == 1) || (playerInput == 1 && aiInput == 2))
            {
                result = 2;
            }
            // Consol(e.WriteLine("Scissors cuts paper");
            else if ((playerInput == 3 && aiInput == 2) || (playerInput == 2 && aiInput == 3))
            {
                result = 3;
            }
            // Draw
            else
            {
                result = 0;
            }
            return result;
        }

    }
}
