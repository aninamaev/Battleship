namespace MyBattleShipsProj
{
    public class Destroyer : Ship
    {
        public Destroyer(int id, string name) : base(id, name)
        {
            NoOfSp = 3;
        }
    }
}