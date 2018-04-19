using System;

namespace Stigespill_v2
{
    class Board
    {

        private BoardRow[] _rows;

        public Board(int width, int height)
        {
            _rows = new BoardRow[height];
            for (var i = 0; i < _rows.Length; i++)
            {
                _rows[i] = new BoardRow(width);
            }
        }

        public void Add(GameTile tile)
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
