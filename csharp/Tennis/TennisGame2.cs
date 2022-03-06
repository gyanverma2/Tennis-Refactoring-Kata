using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private Player Player1;
        private Player Player2;

        public TennisGame2(string player1Name, string player2Name)
        {
            Player1 = new Player(player1Name);
            Player2 = new Player(player2Name);
        }
        public void WonPoint(string playerName)
        {
            GetPlayerInstance(playerName).WonPoint();
        }
        private Player GetPlayerInstance(string playerName)
        {
            return Player1.IsPlayer(playerName) ? Player1 : Player2;
        }
        public string GetScore()
        {
            List<Score> predictedScore = PredictPosibleScore();
            var scoreObj = predictedScore.Find(i => i.IsThisScore() == true);
            return scoreObj != null ? scoreObj.ScoreName() : "";
        }
        private List<Score> PredictPosibleScore()
        {
            return new List<Score>()
            {
                 new TieScore(Player1, Player2),
                 new WinScore(Player1, Player2),
                 new AdvantageScore(Player1, Player2),
                 new NormalScore(Player1, Player2),
                 new InitialScore(Player1, Player2)
            };
        }
    }
}

