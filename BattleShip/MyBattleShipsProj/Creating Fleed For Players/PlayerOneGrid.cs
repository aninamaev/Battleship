using System;

namespace MyBattleShipsProj
{
    public class PlayerOnGrid
    {
        public int[,] MyGrid = new int[10, 10];

        public PlayerOnGrid()
        {
            for (var i = 0; i < 10; i++)
                for (var j = 0; j < 10; j++)
                    MyGrid[i, j] = 0;
        }

        public bool AddShipOnGrid(Ship ship)
        {
            bool isOkToAddThisShip = false;
            int countNs = 0;

            if (ship.Orientation == "v")
            {
                if (ship.CoordX + ship.NoOfSp > 10) return false;

                // verify if you do not already have something in the grid
                for (var k = 0; k < ship.NoOfSp; k++)
                {
                    if (MyGrid[ship.CoordX + k, ship.CoordY] == 0)
                        countNs++;
                }

                if (countNs == ship.NoOfSp)
                {
                    isOkToAddThisShip = true;
                    for (var k = 0; k < ship.NoOfSp; k++)
                        MyGrid[ship.CoordX + k, ship.CoordY] = ship.Id;
                }
            }

            if (ship.Orientation == "h")
            {
                if (ship.CoordY + ship.NoOfSp > 10) return false;

                // verify if you do not already have something in the grid
                for (var k = 0; k < ship.NoOfSp; k++)
                {
                    if (MyGrid[ship.CoordX, ship.CoordY +k] == 0)
                        countNs++;
                }

                if (countNs == ship.NoOfSp)
                {
                    isOkToAddThisShip = true;
                    for (var k = 0; k < ship.NoOfSp; k++)
                        MyGrid[ship.CoordX, ship.CoordY + k] = ship.Id;
                }
            }

            return isOkToAddThisShip;
        }

        public void PrintGrid()
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                    Console.Write(MyGrid[i, j] + " ");
                Console.WriteLine();
            }

        }
    }
}