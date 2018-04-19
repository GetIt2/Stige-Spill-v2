namespace Stigespill_v2
{
    class GameTile
    {
        //public int directionX { get; private set; }
        //public int directionY { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public GameTile(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        //public void Move()
        //{
        //    X += directionX;
        //    Y += directionY;
        //}
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
