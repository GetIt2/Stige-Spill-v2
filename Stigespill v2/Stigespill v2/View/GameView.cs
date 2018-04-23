using System;
using System.Threading;
using Stigespill_v2.Model;

namespace Stigespill_v2.View
{
    public class GameView
    {
        private Game _game;
        private static TileView[] _tileViews;

        public GameView(Game game)
        {
            _game = game;
            _tileViews = new TileView[_game.TileCount];
            for (var index = 0; index < game.Tiles.Length; index++)
            {
                _tileViews[index] = new TileView(game.Tiles[index]);
            }
        }

        public void Show()
        {
            Console.Clear();
            foreach (var tileView in _tileViews)
            {
                tileView.Show();
            }

        }

        public static void AnnounceTurn(Player[] players, int playerTurnIndex, int dice)
        {
            SetCursor(0);
            Console.WriteLine($"{players[playerTurnIndex].Name}'s Turn");
            Console.ReadKey();
            SetCursor(1);
            Console.WriteLine($"{players[playerTurnIndex].Name} got {dice}");
            Thread.Sleep(1000);
        }

        private static void SetCursor(int index)
        {
            Console.CursorLeft = _tileViews[_tileViews.Length - 1].GetX() + _tileViews[_tileViews.Length - 1].GetWidth();
            Console.CursorTop = index;
        }
    }
}
