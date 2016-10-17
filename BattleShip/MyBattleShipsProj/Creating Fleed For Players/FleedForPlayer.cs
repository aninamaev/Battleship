namespace MyBattleShipsProj.Creating_Fleed_For_Player
{
    public class FleedForPlayer
    {
        readonly Fleed fleed;
        public readonly PlayerOnGrid PlayerOnGrid;

        private readonly Player player;

        public FleedForPlayer(Player player)
        {
            this.player = player;

            fleed = new Fleed();
            PlayerOnGrid = new PlayerOnGrid();
        }

        public void CreateFleed()
        {
            // create minesweeper one:
            CreateShip(fleed.MinesweeperOne);
            // create minesweeper two:
            CreateShip(fleed.MinesweeperTwo);
            // create destroyer:
            CreateShip(fleed.Destroyer);
            // create battleship:
            CreateShip(fleed.Battleship);
        }

        void CreateShip(Ship ship)
        {
            var isOk = false;

            if (player == Player.Computer)
                while (!isOk)
                {
                    fleed.CreateShipForComputer(ship);
                    isOk = PlayerOnGrid.AddShipOnGrid(ship);
                }

            if (player == Player.User)
                while (!isOk)
                {
                    fleed.CreateShipForUser(ship);
                    isOk = PlayerOnGrid.AddShipOnGrid(ship);
                }
        }
    }
}