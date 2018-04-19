using System.Collections;

namespace Stigespill_v2.Model
{
    public class Game
    {
        public int ColumnCount { get; }
        public int RowCount { get; }
        public int TileCount => ColumnCount * RowCount;
        private int _playerCount;
        public Player[] Players { get; }
        public Tile[] Tiles { get; }

        public Game(int columnCount, int rowCount)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            Players = new Player[4];
            _playerCount = 0;
            Tiles = InitBoardTiles();
            InitGamePositions();
        }

        private void InitGamePositions()
        {
            for (var gamePosition = 0; gamePosition < TileCount; gamePosition++)
            {
                var rowIndex = RowCount - gamePosition / RowCount - 1;
                var columnIndex = gamePosition % ColumnCount;
                if (IsRightToLeftRow(rowIndex)) columnIndex = ColumnCount - columnIndex;
                var arrayIndex = rowIndex * ColumnCount + columnIndex;
                Tiles[arrayIndex].GamePosition = gamePosition;
            }
        }

        private bool IsRightToLeftRow(int rowIndex)
        {
            return rowIndex % 2 == 0;
        }

        private Tile[] InitBoardTiles()
        {
            var boardTiles = new Tile[TileCount];
            for (var i = 0; i < boardTiles.Length; i++)
            {
                boardTiles[i] = new Tile(i, ColumnCount);
            }
            return boardTiles;
        }

        public void AddPlayer(string name, char symbol)
        {
            var player = new Player(this, name, symbol, _playerCount);            
            Players[_playerCount] = player;
            _playerCount++;
        }
    }
}
