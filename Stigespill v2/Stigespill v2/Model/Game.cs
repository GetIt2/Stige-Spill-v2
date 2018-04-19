using System.Collections;

namespace Stigespill_v2.Model
{
    public class Game
    {
        public readonly int ColumnCount = 10;
        public readonly int RowCount = 10;
        public Player[] Players { get; }
        private int _playerCount;
        public BoardTile[] BoardTiles { get; }

        public Game()
        {
            Players = new Player[4];
            _playerCount = 0;
            BoardTiles = InitBoardTiles();
            InitGamePositions();
        }

        private void InitGamePositions()
        {
            var gamePositionCount = ColumnCount * RowCount;
            for (var gamePosition = 0; gamePosition < gamePositionCount; gamePosition++)
            {
                var rowIndex = RowCount - gamePosition / RowCount - 1;
                var columnIndex = gamePosition % ColumnCount;
                if (IsRightToLeftRow(rowIndex)) columnIndex = ColumnCount - columnIndex;
                var arrayIndex = rowIndex * ColumnCount + columnIndex;
                BoardTiles[arrayIndex].GamePosition = gamePosition;
            }
        }

        private bool IsRightToLeftRow(int rowIndex)
        {
            return rowIndex % 2 == 0;
        }

        private BoardTile[] InitBoardTiles()
        {
            var boardTiles = new BoardTile[ColumnCount * RowCount];
            for (var i = 0; i < BoardTiles.Length; i++)
            {
                BoardTiles[i] = new BoardTile(i);
            }
            return boardTiles;
        }

        public void AddPlayer(string name, char symbol)
        {
            Players[_playerCount] = new Player(name, symbol);
            _playerCount++;
        }

        public void PlaceGamePiecesFromStart()
        {
            //BoardTiles[]
        }
    }
}
