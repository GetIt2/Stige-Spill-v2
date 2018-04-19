using System;
using Stigespill_v2.Model;

namespace Stigespill_v2.View
{
    public class GameView
    {
        private Game _game;
        private TileView[] _tileViews;

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
    }
}
