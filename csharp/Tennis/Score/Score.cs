using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public abstract class Score
    {
        protected Player Player1;
        protected Player Player2;
        public Score(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
        public abstract bool IsThisScore();
        public abstract string ScoreName();

    }
}
