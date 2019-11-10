using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    
    class Player
    {
        private string playerName;
        private int winCount = 0;
        private int drawCount = 0;
        private int loseCount = 0;
        public int LoseCount { get => loseCount; set => loseCount++; }
        public int DrawCount { get => drawCount; set => drawCount++; }
        public int WinCount { get => winCount; set => winCount++; }
        public string PlayerName { get => playerName; set => playerName = value; }

        public Player()
        {
        }
    }
}