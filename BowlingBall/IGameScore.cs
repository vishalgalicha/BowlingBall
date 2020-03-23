using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public interface IGameScore
    {
        int TotalScore(int addScore);
        int GetScore();
    }
}
