namespace Stigespill_v2.Model
{
    public class Player
    {
        private Game _game;
        public int Index { get; }
        public string Name { get; }
        public int GamePosition { get; private set; }
        public char Symbol { get; }

        public Player(Game game, string name, char symbol, int index)
        {
            _game = game;
            Index = index;
            Name = name;
            Symbol = symbol;
            game.StartTile.ArrivePlayer(this);
        }

        public void MovePlayer(int dice)
        {
            _game.FindDepartTile().DepartPlayer(this);
            GamePosition += dice;
            var arriveTile = _game.FindArriveTile();
            if (arriveTile.Jump != null)
            {
                arriveTile = arriveTile.Jump.To;
                GamePosition = arriveTile.GamePosition;
            }
            arriveTile.ArrivePlayer(this);
        }

        public void Jump(int jumpTo)
        {
            GamePosition = jumpTo;
        }
    }
}
