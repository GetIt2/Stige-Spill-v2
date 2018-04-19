using System;
using Stigespill_v2.Model;
using Stigespill_v2.View;

namespace Stigespill_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(10, 10);
            game.AddPlayer("Emil", '♥');
            game.AddPlayer("Kvamme", '♣');
            game.AddPlayer("Hellenes", '♦');
            game.AddPlayer("Lill", '♠');

            var gameView = new GameView(game);
            gameView.Show();

            Console.ReadLine();
        }
    }
}
