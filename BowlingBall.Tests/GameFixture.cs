using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            int[][] Frame = new int[10][];
            Frame[0] = new int[2] { 9, 1 };  //16
            Frame[1] = new int[2] { 6, 3 };  //25
            Frame[2] = new int[2] { 5, 5 };  //45
            Frame[3] = new int[2] { 10, 0 }; //63
            Frame[4] = new int[2] { 5, 3 };  //71
            Frame[5] = new int[2] { 3, 7 };  //91
            Frame[6] = new int[2] { 10, 0 }; //111
            Frame[7] = new int[2] { 9, 1 };  //128
            Frame[8] = new int[2] { 7, 3 };  //148
            Frame[9] = new int[3] { 10, 10, 10 }; //178

            Roll(game,Frame);
            Assert.AreEqual(0, game.GetScore());
        }
        [TestMethod]
        public void Gutter_game_score_should_not_be_zero_test()
        {
            var game = new Game();
            int[][] Frame = new int[10][];
            Frame[0] = new int[2] { 9, 1 };  //16
            Frame[1] = new int[2] { 6, 3 };  //25
            Frame[2] = new int[2] { 5, 5 };  //45
            Frame[3] = new int[2] { 10, 0 }; //63
            Frame[4] = new int[2] { 5, 3 };  //71
            Frame[5] = new int[2] { 3, 7 };  //91
            Frame[6] = new int[2] { 10, 0 }; //111
            Frame[7] = new int[2] { 9, 1 };  //128
            Frame[8] = new int[2] { 7, 3 };  //148
            Frame[9] = new int[3] { 10, 10, 10 }; //178

            Roll(game,Frame);
            Assert.AreNotEqual(0, game.GetScore());
        }
        [TestMethod]
        public void Gutter_game_score2_should_not_be_zero_test()
        {
            var game = new Game();
            int[][] Frame = new int[10][];
            Frame[0] = new int[2] { 10, 0 };  //20
            Frame[1] = new int[2] { 9, 1 };  //35
            Frame[2] = new int[2] { 5, 5 };  //52
            Frame[3] = new int[2] { 7, 2 }; //61
            Frame[4] = new int[2] { 10, 0 };  //91
            Frame[5] = new int[2] { 10, 0 };  //120
            Frame[6] = new int[2] { 10, 0 }; //139
            Frame[7] = new int[2] { 9, 0 };  //148
            Frame[8] = new int[2] { 8, 2 };  //167
            Frame[9] = new int[3] { 9, 1, 10 }; //187

            Roll(game,Frame);
            Assert.AreEqual(0, game.GetScore());
        }

        [TestMethod]
        public void Gutter_game_score()
        {
            var game = new Game();
            int[][] Frame = new int[10][];
            Frame[0] = new int[2] { 9, 1 };  //16
            Frame[1] = new int[2] { 6, 3 };  //25
            Frame[2] = new int[2] { 5, 5 };  //45
            Frame[3] = new int[2] { 10, 0 }; //63
            Frame[4] = new int[2] { 5, 3 };  //71
            Frame[5] = new int[2] { 3, 7 };  //91
            Frame[6] = new int[2] { 10, 0 }; //111
            Frame[7] = new int[2] { 9, 1 };  //128
            Frame[8] = new int[2] { 7, 3 };  //148
            Frame[9] = new int[3] { 10, 10, 10 }; //178

            Roll(game,Frame);
            Assert.AreEqual(178, game.GetScore());
        }

        private void Roll(Game game, int[][] frame)
        {
            game.Roll(frame);
        }
    }
}
