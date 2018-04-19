using System;

namespace Stigespill_v2
{
    class Program
    {

        private static int _width = 8;
        private static int _height = 4;
        private static int _tilesPerRow = 3;

        static void Main(string[] args)
        {
            while (true)
            {
                var tiles = CreateTiles();
                Show(tiles);
                Console.WriteLine("(press enter for new. ctrl+c=exit)");
                Console.ReadLine();
            }
        }

        private static GameTile[] CreateTiles()
        {
            var x = 0;
            var y = 0;
            var counter = 0;
            var tiles = new GameTile[_tilesPerRow * _tilesPerRow];
            for (var i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new GameTile(x, y, _width , _height);
                x += _width - 1;
                counter++;
                if (counter == _tilesPerRow)
                {
                    counter = 0;
                    y += _height  - 1;
                    x = 0;
                }
            }
            return tiles;
        }

        private static void Show(GameTile[] tiles)
        {
            var board = new Board(_width * _tilesPerRow, _height * _tilesPerRow);
            foreach (var tile in tiles)
            {
                board.Add(tile);
            }
            board.Show();
        }
    }
}
