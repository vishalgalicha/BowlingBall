using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public interface IGameRoll
    {
        void Roll(int[][] framePins);
    }
}
