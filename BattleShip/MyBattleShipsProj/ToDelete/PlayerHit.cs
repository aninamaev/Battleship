//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//using MyBattleShipsProj.Creating_Fleed_For_Player;

//namespace MyBattleShipsProj
//{
//    public class PlayerHit
//    {
//        public int[,] playerGrid;
//        int[,] opponentGrid;

//        public PlayerHit(int[,] opponentGrid)
//        {
//            playerGrid = new int[10, 10];
//            for (var i = 0; i < 10; i++)
//                for (var j = 0; j < 10; j++)
//                    playerGrid[i, j] = 0;

//            this.opponentGrid = opponentGrid;
//        }

//        public bool TryHitOpponentShip(int x, int y)
//        {
//            // verifica daca nu ai mai incercat acest punct
//            if (playerGrid[x, y] == 0)
//            {
//                if (opponentGrid[x, y] != 0)
//                    playerGrid[x, y] = 4;
//                else
//                    playerGrid[x, y] = 1;
//                return true;
//            }
//            Console.WriteLine("You have already hit this point!");
//            return false;
//        }

//        public int SumOnPlayerGrid()
//        {
//            int sum = 0;
//            for (var i = 0; i < 10; i++)
//                for (var j = 0; j < 10; j++)
//                {
//                    if (playerGrid[i, j] == 4)
//                        sum += playerGrid[i, j];
//                }
//            return sum;
//        }

//        public void PrintPlayerGrid()
//        {
//            for (var i = 0; i < 10; i++)
//            {
//                for (var j = 0; j < 10; j++)
//                    Console.Write(playerGrid[i, j] + " ");
//                Console.WriteLine();
//            }
//        }
//    }

//    public class Game
//    {
//        public bool IsGameOver;
//        public string Winner;

//        public int HitNo = 0;

//        public readonly PlayerHit Player1Hit;
//        public readonly PlayerHit Player2Hit;

//        public Game(int[,] player1Grid, int[,] player2Grid)
//        {
//            Player1Hit = new PlayerHit(player2Grid);
//            Player2Hit = new PlayerHit(player1Grid);
//        }

//        // let player 1 = user; player 2 = computer
//        public void UserHit()
//        {
//            bool isHitOk = false;
//            while (!isHitOk)
//            {
//                var x = ReturnCoordonateForUser("x");
//                var y = ReturnCoordonateForUser("y");
//                isHitOk = Player1Hit.TryHitOpponentShip(x, y);
//            }
//        }

//        public void ComputerHit()
//        {
//            bool isHitOk = false;
//            var random = new Random();
//            while (!isHitOk)
//            {
//                var x = random.Next(0, 9);
//                var y = random.Next(0, 9);
//                isHitOk = Player2Hit.TryHitOpponentShip(x, y);
//            }
//        }

//        public void EvaluateGame()
//        {
//            if (Player1Hit.SumOnPlayerGrid() == 44)
//            {
//                Winner = "user";
//                IsGameOver = true;
//            }

//            if (Player2Hit.SumOnPlayerGrid() == 44)
//            {
//                Winner = "comp";
//                IsGameOver = true;
//            }

//            HitNo++;
//        }

//        private int ReturnCoordonateForUser(string coordonate)
//        {
//            var answer = -1;

//            while (answer == -1)
//            {
//                Console.WriteLine($"Enter coordonate {coordonate} for hit number {HitNo}!");
//                var answerSt = Console.ReadLine();
//                if (int.TryParse(answerSt, out answer))
//                {
//                    if ((answer < 0) || (answer > 9))
//                    {
//                        answer = -1;
//                        Console.WriteLine("Invalid coordinate! Please enter a value between 0 and 9");
//                    }
//                }
//            }
//            return answer;
//        }
//    }
//}
