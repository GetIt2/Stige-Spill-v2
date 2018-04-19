namespace Stigespill_v2.Model
{
    public class Tile
    {
        private readonly int _columnCount;
        public Player[] Players { get; }

        public Tile(int arrayIndex, int columnCount)
        {
            _columnCount = columnCount;
            ArrayIndex = arrayIndex;
            Players = new Player[4];
        }

        public void ArrivePlayer(Player player)
        {
            Players[player.Index] = player;
        }

        public void DepartPlayer(Player player)
        {
            Players[player.Index] = null;
        }

        public Jump Jump { get; }
        public int GamePosition { get; set; }
        public int ArrayIndex { get; }
        public int RowIndex => ArrayIndex / _columnCount;
        public int ColumnIndex => ArrayIndex % _columnCount;

    }
}
