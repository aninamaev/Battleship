using System;

namespace MyBattleShipsProj.Game
{
    public class UserGame : PlayerGame
    {
        public UserGame(int[,] myFleedGrid) : base(myFleedGrid)
        {
            
        }

        public override void GeneratesCoordinateForHit()
        {
            bool isNew = false;
            while (!isNew)
            {
                X = ReturnCoordonateForUser("x");
                Y = ReturnCoordonateForUser("y");
                if (GameGrid[X, Y] == 0)
                    isNew = true;
                else
                    Console.WriteLine("You have already hit this point");
            }
        }

        private int ReturnCoordonateForUser(string coordonate)
        {
            var answer = -1;

            while (answer == -1)
            {
                Console.WriteLine($"Enter coordonate {coordonate} for next hit!");
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
    }
}