namespace MyBattleShipsProj
{
    public class Ship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public string Orientation { get; set; }
        public int NoOfSp { get; set; }

        public Ship(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}