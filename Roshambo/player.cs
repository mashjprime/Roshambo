using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    
    class Player
    {


        public string playerName;
        public int winCount = 0;
        public int drawCount = 0;
        public int loseCount = 0;

        public Player()
        {
        }

        public int GetWinCount()
        {
            return this.winCount;
        }

        public int GetDrawCount()
        {
            return this.drawCount;
        }

        public int GetLoseCount()
        {
            return this.loseCount;
        }

        public void WinCount()
        {
            this.winCount++;
        }

        public void DrawCount()
        {
            this.drawCount++;
        }

        public void LoseCount()
        {
            this.loseCount++;
        }

        public string GetPlayerName()
        {
            return this.playerName;
        }

        public void SetPlayerName(string name)
        {
            this.playerName = name;
        }



    }
}