using System;

namespace MyBattleShipsProj.Game
{
    public class ComputerGame : PlayerGame
    {
        public ComputerGame(int[,] myFleedGrid) : base(myFleedGrid)
        {
        }

        public override void GeneratesCoordinateForHit()
        {
            bool isNew = false;
            var random = new Random();
            while (!isNew)
            {
                X = random.Next(0, 9);
                Y = random.Next(0, 9);
                if (GameGrid[X, Y] == 0)
                    isNew = true;
            }
        }
    }
}