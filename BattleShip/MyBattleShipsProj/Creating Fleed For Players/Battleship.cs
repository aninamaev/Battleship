namespace MyBattleShipsProj
{
    public class Battleship : Ship
    {
        public Battleship(int id, string name) : base(id, name)
        {
            NoOfSp = 4;
        }
    }
}