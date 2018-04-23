using System;
using System.Collections;
using Stigespill_v2.View;

namespace Stigespill_v2.Model
{
    public class Game
    {
        public Random Random = new Random();
        public int ColumnCount { get; }
        public int RowCount { get; }
        public int TileCount => ColumnCount * RowCount;
        private int _playerCount;
        public Player[] Players { get; }
        public Tile[] Tiles { get; }
        public Tile StartTile { get; private set; }
        public Tile FinishTile { get; private set; }
        private int _playerTurnIndex;

        public Game(int columnCount, int rowCount)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            Players = new Player[4];
            _playerCount = 0;
            Tiles = InitBoardTiles();
            InitGamePositions();
            StartTile.Label = "Start";
            FinishTile.Label = "Finish";
            _playerTurnIndex = 0;
        }

        private void InitGamePositions()
        {
            for (var gamePosition = 0; gamePosition < TileCount; gamePosition++)
            {
                var rowIndex = RowCount - gamePosition / RowCount - 1;
                var columnIndex = gamePosition % ColumnCount;
                if (IsRightToLeftRow(rowIndex)) columnIndex = ColumnCount - columnIndex - 1;
                var arrayIndex = rowIndex * ColumnCount + columnIndex;
                var tile = Tiles[arrayIndex];
                tile.GamePosition = gamePosition;
                if (gamePosition == 0) StartTile = tile;
                else if (gamePosition == TileCount - 1) FinishTile = tile;

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

        public void PlayerTurn()
        {
            if (_playerTurnIndex == Players.Length) _playerTurnIndex = 0;
            var dice = Random.Next(1, 6);
            GameView.AnnounceTurn(Players ,_playerTurnIndex, dice);
            foreach (var tile in Tiles)
            {
                if (Players[_playerTurnIndex].GamePosition == tile.GamePosition)
                    tile.DepartPlayer(Players[_playerTurnIndex]);
            }
            Players[_playerTurnIndex].MovePlayer(dice);
            foreach (var tile in Tiles)
            {
                if (Players[_playerTurnIndex].GamePosition == tile.GamePosition)
                    tile.ArrivePlayer(Players[_playerTurnIndex]);
            }
            _playerTurnIndex++;
        }

    }
}
