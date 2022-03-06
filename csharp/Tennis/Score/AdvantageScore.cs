using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class AdvantageScore : Score
    {
        public AdvantageScore(Player player1, Player player2) : base(player1, player2)
        {

        }
        public override bool IsThisScore()
        {
            return Player1.HasAdvantageOver(Player2) || Player2.HasAdvantageOver(Player1);
        }

        public override string ScoreName()
        {
            return "Advantage " + (Player1.HasAdvantageOver(Player2) ? Player1.GetName() : Player2.GetName());
        }
    }
}
