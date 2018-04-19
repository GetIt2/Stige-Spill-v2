namespace Stigespill_v2.Model
{
    public class Tile
    {
        private readonly int _columnCount;

        public Tile(int arrayIndex, int columnCount)
        {
            _columnCount = columnCount;
            ArrayIndex = arrayIndex;
        }

        public Jump Jump { get; }
        public int GamePosition { get; set; }
        public int ArrayIndex { get; }
        public int RowIndex => ArrayIndex / _columnCount;
        public int ColumnIndex => ArrayIndex % _columnCount;

    }
}
