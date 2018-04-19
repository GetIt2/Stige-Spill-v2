using System;
using Stigespill_v2.Model;

namespace Stigespill_v2.View
{
    public class BoardView
    {
        private BoardRowView[] _rows;
        private BoardTileView[] _tiles;
        private Board _board;

        public BoardView(int width, int height, Board board)
        {
            _board = board;
            _rows = new BoardRowView[height];
            for (var i = 0; i < _rows.Length; i++)
            {
                _rows[i] = new BoardRowView(width);
            }

            _tiles = CreateTiles();
        }

        public BoardTileView[] CreateTiles()
        {
            var x = 0;
            var y = 0;
            var counter = 0;
            var tiles = new BoardTileView[_board.ColumnCount * _game.RowCount];
            for (var i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new BoardTileView(x, y,
                    TileWidth, TileHeight, _game.BoardTiles[i]);
                x += TileWidth - 1;
                counter++;
                if (counter == _game.ColumnCount)
                {
                    counter = 0;
                    y += TileHeight - 1;
                    x = 0;
                }
            }
            return tiles;
        }

        public void Add(BoardTileView tile)
        {
            var firstY = tile.GetTopRowY();
            var lastY = tile.GetBottomRowY();
            _rows[firstY].AddTopRow(tile.X, tile.Width);
            _rows[lastY].AddBottomRow(tile.X, tile.Width);
            for (var rowId = firstY + 1; rowId < lastY; rowId++)
            {
                _rows[rowId].AddMiddleRow(tile.X, tile.Width);
            }
        }

        public void Show()
        {
            Console.Clear();
            foreach (var row in _rows)
            {
                row.Show();
            }
        }

    }
}
