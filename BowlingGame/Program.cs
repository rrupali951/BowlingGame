using Game.Bowling.Services;
using System;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreCalculationService scoreCalculationService = new ScoreCalculationService();

            int[] rolls = { 3, 7, 10, 4, 5, 2, 8, 10, 10, 10, 9, 0, 7, 3, 10 ,4 ,3,6,4,2};

           // int[] rolls = { 3, 7, 10, 4 ,2,2};

            // Record the rolls in the game
            foreach (int pins in rolls)
            {
                scoreCalculationService.Roll(pins);
            }
            var result = scoreCalculationService.CalculateTotalScore();
            Console.WriteLine($"Total score - {result}");
        }
    }
}
