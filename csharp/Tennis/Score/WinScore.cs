using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class WinScore : Score
    {
        public WinScore(Player player1, Player player2) : base(player1, player2)
        {

        }
        public override bool IsThisScore()
        {
            return Player1.HasWonAgainst(Player2) || Player2.HasWonAgainst(Player1);
        }

        public override string ScoreName()
        {
            return "Win for " + (Player1.HasWonAgainst(Player2) ? Player1.GetName() : Player2.GetName());
        }
    }
}
