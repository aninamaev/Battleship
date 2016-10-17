namespace MyBattleShipsProj.Game
{
    public abstract class PlayerGame
    {
        public int X;
        public int Y;
        private readonly int[] hitShips = new[] { 0, 0, 0, 0 };

        private readonly int[] countships = new int[4] { 0, 0, 0, 0 };

        private readonly int[,] myFleedGrid;
        public int[,] GameGrid;

        protected PlayerGame(int[,] myFleedGrid)
        {
            this.myFleedGrid = myFleedGrid;
            GameGrid = new int[10, 10];
            for (var i = 0; i < 10; i++)
                for (var j = 0; j < 10; j++)
                    GameGrid[i, j] = 0;
        }

        public HitType EvaluateOpponentHit(int x, int y)
        {
            var result = myFleedGrid[x, y];
            switch (result)
            {
                case 11:
                    countships[0]++;
                    if (countships[0] == 2)
                        return HitType.SunkM;
                    return HitType.Hit;
                case 12:
                    countships[1]++;
                    if (countships[1] == 2)
                        return HitType.SunkM;
                    return HitType.Hit;
                case 21:
                    countships[2]++;
                    if (countships[2] == 3)
                        return HitType.SunkD;
                    return HitType.Hit;
                case 31:
                    countships[3]++;
                    if (countships[3] == 4)
                        return HitType.SunkB;
                    return HitType.Hit;
                default:
                    return HitType.Missed;
            }
        }

        public abstract void GeneratesCoordinateForHit();

        public void EvaluateMyHits(HitType hit)
        {
            switch (hit)
            {
                case HitType.Missed:
                    GameGrid[X, Y] = 1;
                    break;
                case HitType.Hit:
                    GameGrid[X, Y] = 2;
                    break;
                case HitType.SunkM:
                    GameGrid[X, Y] = 2;
                    if (hitShips[0] == 0)
                        hitShips[0] = 1;
                    else
                        hitShips[1] = 1;
                    break;
                case HitType.SunkD:
                    GameGrid[X, Y] = 2;
                    hitShips[2] = 1;
                    break;
                case HitType.SunkB:
                    GameGrid[X, Y] = 2;
                    hitShips[3] = 1;
                    break;
            }
        }

        public bool EvaluateAsWinner()
        {
            if (hitShips[0] + hitShips[1] + hitShips[2] + hitShips[3] == 4)
                return true;
            return false;
        }
    }
}