//namespace MyBattleShipsProj.Creating_Fleed_For_User
//{
//    public class FleedOnGridForUser
//    {
//        readonly Fleed fleed;
//        private readonly PlayerOnGrid playerOnGrid;

//        public FleedOnGridForUser()
//        {
//            fleed = new Fleed();
//            playerOnGrid = new PlayerOnGrid();
//        }

//        public void CreateFleed()
//        {
//            // create minesweeper one:
//            CreateShip(fleed.MinesweeperOne);
//            // create minesweeper two:
//            CreateShip(fleed.MinesweeperTwo);
//            // create destroyer:
//            CreateShip(fleed.Destroyer);
//            // create battleship:
//            CreateShip(fleed.Battleship);

//            playerOnGrid.PrintGrid();
//        }

//        void CreateShip(Ship ship)
//        {
//            var isOk = false;

//            while (!isOk)
//            {
//                fleed.CreateShipForUser(ship);
//                isOk = playerOnGrid.AddShipOnGrid(ship);
//            }
//        }
//    }
//}