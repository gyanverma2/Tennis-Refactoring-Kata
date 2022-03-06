using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class InitialScore : Score
    {
        public InitialScore(Player player1, Player player2) : base(player1,player2)
        {
           
        }
        public override bool IsThisScore()
        {
            return true;
        }

        public override string ScoreName()
        {
            return "";
        }
    }
}
