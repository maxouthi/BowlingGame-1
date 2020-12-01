using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTests
{
    [TestClass]
    public class GameTests
    {
        private Game game;

        [TestInitialize]
        public void Initialize()
        {
            game = new Game();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            AddRolls(20, 0);
            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            AddRolls(20,1);
            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);

            AddRolls(17, 0);
            Assert.AreEqual(16, game.Score());
        }

        [TestMethod]
        public void TestOneStrike()
        {
            game.Roll(10);
            game.Roll(5);
            game.Roll(3);

            AddRolls(16,0);
            Assert.AreEqual(26, game.Score());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            AddRolls(12, 10);
            Assert.AreEqual(300, game.Score());
        }


        private void AddRolls(int rolls, int pins)
        {
            for (var i = 0; i < rolls; i++)
                game.Roll(pins);
        }

    }
}
