using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class GameScore : IGameScore
    {
        int totalScore { get; set; }
        public int GetScore()
        {
            // Returns the final score of the game.
            return totalScore;
        }

        public int TotalScore(int addScore)
        {
            //Get Total score by adding frame pins
            totalScore += addScore;
            return totalScore;
        }
    }
}
