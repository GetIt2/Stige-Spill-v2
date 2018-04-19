using System;
using System.Linq;

namespace Stigespill_v2
{
    class BoardRow
    {
        private BoardCell[] _cells;

        public BoardRow(int width)
        {
            _cells = new BoardCell[width];
            for (var i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new BoardCell();
            }
        }

        public void AddTopRow(int startX, int width)
        {
            var endX = startX + width - 1;
            _cells[startX].AddUpperLeftCorner();
            _cells[endX].AddUpperRightCorner();
            for (var colId = startX + 1; colId < endX; colId++)
            {
                _cells[colId].AddHorizontal();
            }
        }

        public void AddBottomRow(int startX, int width)
        {
            var endX = startX + width - 1;
            _cells[startX].AddLowerLeftCorner();
            _cells[endX].AddLowerRightCorner();
            for (var colId = startX + 1; colId < endX; colId++)
            {
                _cells[colId].AddHorizontal();
            }
        }

        public void AddMiddleRow(int startX, int width)
        {
            _cells[startX].AddVertical();
            _cells[startX + width - 1].AddVertical();
        }

        public void Show()
        {
            var array = _cells.Select(c => c.GetCharacter()).ToArray();
            Console.WriteLine(array);
        }
    }
}
