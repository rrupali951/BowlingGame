using Game.Bowling.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Game.Bowling.UnitTests
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void TestAllZeros()
        {
            ScoreCalculationService game = new ScoreCalculationService();
            RollMany(game, 20, 0);
            Assert.AreEqual(0, game.CalculateTotalScore());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            ScoreCalculationService game = new ScoreCalculationService();
            RollMany(game, 20, 1);
            Assert.AreEqual(20, game.CalculateTotalScore());
        }

        [TestMethod]
        public void TestSpare()
        {
            ScoreCalculationService game = new ScoreCalculationService();
            game.Roll(5);
            game.Roll(5); // Spare
            game.Roll(3);
            RollMany(game, 17, 0);
            Assert.AreEqual(16, game.CalculateTotalScore());
        }

        [TestMethod]
        public void TestStrike()
        {
            ScoreCalculationService game = new ScoreCalculationService();
            game.Roll(10); // Strike
            game.Roll(3);
            game.Roll(4);
            RollMany(game, 16, 0);
            Assert.AreEqual(24, game.CalculateTotalScore());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            ScoreCalculationService game = new ScoreCalculationService();
            RollMany(game, 12, 10);
            Assert.AreEqual(300, game.CalculateTotalScore());
        }

        private void RollMany(ScoreCalculationService game, int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
