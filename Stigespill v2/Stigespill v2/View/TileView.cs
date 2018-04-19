using System;
using Stigespill_v2.Model;

namespace Stigespill_v2.View
{
    public class TileView
    {
        public const int TileWidth = 8;
        public const int TileHeight = 4;
        private const char BorderCharacter = '▒';
        private readonly Tile _tile;
        private int X => _tile.ColumnIndex * TileWidth;
        private int Y => _tile.RowIndex * TileHeight;

        public TileView(Tile tile)
        {
            _tile = tile;
        }

        public void Show()
        {
            WriteSolid(BorderCharacter, X, Y, TileWidth);
            for (var dy = 0; dy < TileHeight; dy++)
                WriteHollow(BorderCharacter, X, Y + dy, TileWidth);
            WriteSolid(BorderCharacter, X, Y + TileHeight, TileWidth);
        }

        private void WriteHollow(char c, int x, int y, int width)
        {
            Console.CursorTop = y;
            Console.CursorLeft = x;
            Console.Write(c);
            Console.CursorLeft = x + width;
            Console.Write(c);
        }

        private static void WriteSolid(char c, int x, int y, int width)
        {
            Console.CursorTop = y;
            Console.CursorLeft = x;
            while (width-- >= 0) Console.Write(c);
        }
    }
}
