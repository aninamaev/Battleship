using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBattleShipsProj;
using MyBattleShipsProj.Creating_Fleed_For_Player;
using MyBattleShipsProj.Game;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            // for computer 
            var fleedOnGridForComputer = new FleedForPlayer(Player.Computer);
            fleedOnGridForComputer.CreateFleed();
            var compGrid = fleedOnGridForComputer.PlayerOnGrid.MyGrid;

            // for user
            var fleedOnGridForUser = new FleedForPlayer(Player.User);
            fleedOnGridForUser.CreateFleed();
            var userGrid = fleedOnGridForUser.PlayerOnGrid.MyGrid;

            var cg1 = new UserGame(userGrid);
            var cg2 = new ComputerGame(compGrid);

            Console.WriteLine("Print user's Grid:");
            PrintMatrix(userGrid);
            Console.WriteLine("---------------------");
            Console.WriteLine("Print computer's Grid:");
            PrintMatrix(compGrid);

            var gameOver = false;
            while (!gameOver)
            {
                cg1.GeneratesCoordinateForHit();
                cg2.GeneratesCoordinateForHit();

                cg1.EvaluateMyHits(cg2.EvaluateOpponentHit(cg1.X, cg1.Y));
                cg2.EvaluateMyHits(cg1.EvaluateOpponentHit(cg2.X, cg2.Y));

                var cg1Eval = cg1.EvaluateAsWinner();
                var cg2Eval = cg2.EvaluateAsWinner();
                if (cg1Eval)
                {
                    gameOver = true;
                    Console.WriteLine("User wins the game!");
                }

                if (cg2Eval)
                {
                    gameOver = true;
                    Console.WriteLine("Computer wins the game!");
                }

                PrintMatrix(cg1.GameGrid);
                Console.WriteLine("---------------------");
                PrintMatrix(cg2.GameGrid);
            }
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}