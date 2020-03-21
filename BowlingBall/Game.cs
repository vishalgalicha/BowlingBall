using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {
        public int totalScore = 0;

        public int TotalScore(int addScore)
        {
            //Get Total score by adding frame pins
            totalScore += addScore;
            return totalScore;
        }
        
        public void Roll(int[][] framePins)
        {
            // Add your logic here. Add classes as needed.
            int bowl1, bowl2 = 0, frame, extraFrame;
            bool strike = false, strikeTwo = false, spare = false;

            //run for 10 frames to calculate final score
            for (frame = 0; frame < framePins.Length; frame++)
            {
                bowl1 = framePins[frame][0];
                int prevFrame;
                if (spare == true)// if previous frame was a spare add bonus then
                {
                    prevFrame = 10 + bowl1;
                    spare = false;
                    TotalScore(prevFrame);
                }

                int prevFrameTwo;
                if (strikeTwo == true && bowl1 == 10)  //if double strike and also third is strike
                {
                    prevFrameTwo = 30;
                    TotalScore(prevFrameTwo);
                }
                if (strikeTwo == true && bowl1 != 10) //if double strike and third is not strike
                {
                    strikeTwo = false;
                    prevFrameTwo = 10 + 10 + bowl1;
                    TotalScore(prevFrameTwo);
                }
                if (strike == true && bowl1 == 10) //if strike and second is also strike
                {
                    strikeTwo = true; //Double strike
                    prevFrameTwo = 20;
                }

                if (bowl1 < 10) //if pins falled in first chance are less than 10
                {
                    bowl2 = framePins[frame][1]; //get pins falled in second chance
                    if (bowl1 + bowl2 == 10) //if it is spare
                    {
                        spare = true;  //all 10 pins dropped in two chances
                    }

                    if (strikeTwo == true && frame == 9) //if double strike and frame is last
                    {
                        prevFrameTwo = 10 + 10 + bowl2;
                        TotalScore(prevFrameTwo);
                        strikeTwo = false;
                    }

                    if (strike == true && bowl1 != 10) //if previous strike and next chance falls less than 10 pins
                    {
                        strike = false;
                        prevFrame = 10 + bowl1 + bowl2;
                        TotalScore(prevFrame);
                    }
                    if (spare != true && strike != true && strikeTwo != true) //if no spare, no strike or double strike then just add points of pins
                    {
                        int frameScore = bowl1 + bowl2;
                        TotalScore(frameScore);
                    }
                }
                else
                {
                    strike = true;  //all pins dropped in one single chance
                    prevFrame = 10;
                }
                if (frame == 9 && strike == true) //if last frame and strike in first chance
                {
                    bowl2 = framePins[frame][1];

                    if (strikeTwo == true) //if last frame and strike in second chance as well
                    {
                        prevFrameTwo = 10 + 10 + bowl2;
                        TotalScore(prevFrameTwo);
                        strikeTwo = false;
                    }
                }

                if (frame == 9 && (spare == true || strike == true))//if last frame and its spare or strike
                {
                    extraFrame = framePins[frame][2];
                    if (strike == true) 
                    {
                        prevFrame = 10 + bowl2 + extraFrame;
                        TotalScore(prevFrame);
                    }
                    else
                    {
                        totalScore = totalScore + 10 + extraFrame;
                    }
                }
            }
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            return totalScore;
        }
    }
}
