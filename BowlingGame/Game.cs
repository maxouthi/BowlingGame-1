﻿
namespace BowlingGame
{
    public class Game
    {
        // initializes rolls array
        private int[] rolls = new int[21];
        // initializes roll
        private int currentRoll = 0;

        /// <summary>
        /// Adds a role
        /// </summary>
        /// <param name="pins"></param>
        /// <param name="roll"></param>
        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        /// <summary>
        /// Calculates the score for a game
        /// </summary>
        /// <returns>the score</returns>
        public int Score()
        {
            Calculator calculator = new Calculator(rolls);

            return calculator.GetScoreForAllRollsInGame();
        }
    }
}
