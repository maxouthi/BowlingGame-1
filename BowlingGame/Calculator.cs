namespace BowlingGame
{
    class Calculator
    {
        private int[] rolls;

        private Calculator(int[] rolls)
        {
            this.rolls = rolls;
        }

        public static Calculator GetRollCalculator(int[] rolls)
        {
            return new Calculator(rolls);
        }

        public void GetScoreForAllRollsInGame(ref int score)
        {
            int rollIndex = 0;
            int currentRoll = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                // strike
                if (IsAStrike(rollIndex))
                {

                    score += rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
                    rollIndex++;
                }
                else if (IsASpare(rollIndex))
                {
                    score += 10 + rolls[rollIndex + 2];
                    rollIndex += 2;
                }
                else
                {
                    score += rolls[rollIndex] + rolls[rollIndex + 1];
                    rollIndex += 2;
                }
            }
        }

        private bool IsASpare(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }

        private bool IsAStrike(int rollIndex)
        {
            return rolls[rollIndex] == 10;
        }
    }
}
