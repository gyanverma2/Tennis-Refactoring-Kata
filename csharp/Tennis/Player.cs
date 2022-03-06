using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    public class Player
    {
        private int score;
        public int GetScore() { return score; }
        private string name;
        public string GetName() { return name; }

        /// <summary>
        /// Constructor of player class
        /// </summary>
        /// <param name="_name">Player name</param>
        public Player(string _name)
        {
            name = _name;
            score = 0;
        }

        /// <summary>
        /// Increment score if player won point
        /// </summary>
        public void WonPoint()
        {
            score++;
        }

        /// <summary>
        /// Check which player is active
        /// </summary>
        /// <param name="name">Player Name</param>
        /// <returns>true/false</returns>
        public bool IsPlayer(string name)
        {
            return this.name == name;
        }

        /// <summary>
        /// Check if has won against the other player
        /// </summary>
        /// <param name="otherPlayer">Other player instance</param>
        /// <returns>true/false</returns>
        public bool HasWonAgainst(Player otherPlayer)
        {
            int advgOverOtherPlayer = score - otherPlayer.GetScore();
            return score >= 4 && advgOverOtherPlayer >= 2;
        }

        /// <summary>
        /// Check if has advantage over other player
        /// </summary>
        /// <param name="otherPlayer">Other player instance</param>
        /// <returns>true/false</returns>
        public bool HasAdvantageOver(Player otherPlayer)
        {
            int advgOverOtherPlayer = score - otherPlayer.GetScore();
            return score >= 4 && advgOverOtherPlayer==1;
        }

        /// <summary>
        /// Check if tie
        /// </summary>
        /// <param name="otherPlayer">Other player instance</param>
        /// <returns>true/false</returns>
        public bool IsATieWith(Player otherPlayer)
        {
            return score == otherPlayer.GetScore();
        }
    }
}
