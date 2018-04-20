namespace Stigespill_v2.Model
{
    public class Player
    {
        public int Index { get; }
        public string Name { get; }
        public int GamePosition { get; private set; }
        public char Symbol { get; }

        public Player(Game game, string name, char symbol, int index)
        {
            Index = index;
            Name = name;
            Symbol = symbol;
            game.StartTile.ArrivePlayer(this);
        }

        public void MovePlayer(int dice)
        {
            GamePosition += dice;
        }
    }
}
