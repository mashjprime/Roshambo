using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    
    class player
    {


        public string playerName { get; set; }
        public int playerHighScore = 0 ;


        public int GetHighScore()
        {
            return this.playerHighScore;
        }

        public void SetHighScore(int score)
        {
            this.playerHighScore = score;
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