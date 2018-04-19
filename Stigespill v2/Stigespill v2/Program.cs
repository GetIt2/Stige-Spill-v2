using System;
using Stigespill_v2.Model;
using Stigespill_v2.View;

namespace Stigespill_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.AddPlayer("Emil", '♥');
            game.AddPlayer("Kvamme", '♣');
            game.AddPlayer("Hellenes", '♦');
            game.AddPlayer("Lill", '♠');
            game.PlaceGamePiecesFromStart();

            var gameView = new GameView(game);

            while (true)
            {
                gameView.Show();
                Console.WriteLine("(press enter for new. ctrl+c=exit)");
                Console.ReadLine();
            }
        }
    }
}
