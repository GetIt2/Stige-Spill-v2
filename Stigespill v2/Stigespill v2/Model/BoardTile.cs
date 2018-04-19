namespace Stigespill_v2.Model
{
    public class BoardTile
    {
        public BoardTile(int arrayIndex)
        {
            ArrayIndex = arrayIndex;
        }

        public BoardJumpPath Jump { get; }
        public int GamePosition { get; set; }
        public int ArrayIndex { get; }

    }
}
