using Stigespill_v2.Model;

namespace Stigespill_v2.View
{
    public class BoardTileView
    {
        //public int directionX { get; private set; }
        //public int directionY { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        BoardTile _boardTile;

        public BoardTileView(int x, int y, int width, int height, BoardTile boardTile)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            _boardTile = boardTile;
        }

        public int GetTopRowY()
        {
            return Y;
        }

        public int GetBottomRowY()
        {
            return Y + Height - 1;
        }
    }
}
