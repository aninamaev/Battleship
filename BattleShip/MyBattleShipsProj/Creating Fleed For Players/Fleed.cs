using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBattleShipsProj
{
    public class Fleed
    {
        public Minesweeper MinesweeperOne;
        public Minesweeper MinesweeperTwo;
        public Destroyer Destroyer;
        public Battleship Battleship;

        public Fleed()
        {
            MinesweeperOne = new Minesweeper(11, "Minesweeper One");
            MinesweeperTwo = new Minesweeper(12, "Minesweeper Two");

            Destroyer = new Destroyer(21, "Destroyer");

            Battleship = new Battleship(31, "BattleShip");
        }

        // create fleed for user
        public void CreateShipForUser(Ship ship)
        {
            ship.CoordX = ReturnCoordonatesForShip("x coordinate", ship.Name);
            ship.CoordY = ReturnCoordonatesForShip("y coordinate", ship.Name);
            ship.Orientation = ReturnOrientationForShip(ship.Name);
        }

        public int ReturnCoordonatesForShip(string coordonate, string ship)
        {
            var answer = -1;

            while (answer == -1)
            {
                Console.WriteLine($"Please enter {coordonate} for {ship}!");
                var answerSt = Console.ReadLine();
                if (int.TryParse(answerSt, out answer))
                {
                    if ((answer < 0) || (answer > 9))
                    {
                        answer = -1;
                        Console.WriteLine("Invalid coordinate! Please enter a value between 0 and 9");
                    }
                }
            }
            return answer;
        }

        public string ReturnOrientationForShip(string ship)
        {
            var answer = string.Empty;

            while (answer == string.Empty)
            {
                Console.WriteLine($"Please enter orientation for {ship}! h/v");
                answer = Console.ReadLine();
                if ((answer != "h") && (answer != "v"))
                {
                    answer = string.Empty;
                    Console.WriteLine("You can only choose between horizontal or vertical orientation! (h/v)");
                }
            }
            return answer;
        }

        // create fleed for computer
        public void CreateShipForComputer(Ship ship)
        {
            var random = new Random();
            ship.CoordX = random.Next(0, 9);
            ship.CoordY = random.Next(0, 9);
            ship.Orientation = random.Next(0, 1) == 0 ? "h" : "v";
        }

    }
}