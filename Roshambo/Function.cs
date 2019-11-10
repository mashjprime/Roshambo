using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Roshambo
{
    class Function
    {

        public static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        public static void pause(int x)
        {
            x = x * 1000 / 2;
            Thread.Sleep(x);
        }
    }
}
