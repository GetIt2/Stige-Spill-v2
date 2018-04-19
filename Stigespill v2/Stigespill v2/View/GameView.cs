using System;
using Stigespill_v2.Model;

namespace Stigespill_v2.View
{
    public class GameView
    {
        public const int TileWidth = 8;
        public const int TileHeight = 4;
        private Game _game;

        public GameView(Game game)
        {
            _game = game;
        }

        public void Show()
        {
            var board = new BoardView(
                TileWidth * _game.ColumnCount,
                TileHeight * _game.RowCount);
            foreach (var tile in tiles)
            {
                board.Add(tile);
            }
            board.Show();
        }
    }
}
