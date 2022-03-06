using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class TieScore : Score
    {
        readonly Dictionary<int, string> expectedScore = new Dictionary<int, string>() { { 0, "Love" }, { 1, "Fifteen" }, { 2, "Thirty" } };
        public TieScore(Player player1, Player player2) : base(player1, player2)
        {

        }
        public override bool IsThisScore()
        {
            return Player1.IsATieWith(Player2);
        }

        public override string ScoreName()
        {
            return Player1.GetScore() > 2 ? "Deuce" : expectedScore[Player1.GetScore()] + "-All";
        }
    }
}
