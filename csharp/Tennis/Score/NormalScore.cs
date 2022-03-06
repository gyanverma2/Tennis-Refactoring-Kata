using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class NormalScore : Score
    {
        readonly Dictionary<int, string> expectedScore = new Dictionary<int, string>() { { 0, "Love" }, { 1, "Fifteen" }, { 2, "Thirty" }, { 3, "Forty" } };
        public NormalScore(Player player1, Player player2) : base(player1, player2)
        {

        }
        public override bool IsThisScore()
        {
            return Player1.GetScore() <= 3 && Player2.GetScore() <= 3;
        }

        public override string ScoreName()
        {
            return expectedScore[Player1.GetScore()] + "-" + expectedScore[Player2.GetScore()];
        }
    }
}
