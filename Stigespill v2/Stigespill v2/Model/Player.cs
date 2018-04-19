namespace Stigespill_v2.Model
{
    public class Player
    {
        public string Name { get; }
        public int GamePosition { get; private set; }
        public char Symbol { get; }

        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}
