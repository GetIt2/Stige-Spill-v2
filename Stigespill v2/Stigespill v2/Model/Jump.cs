namespace Stigespill_v2.Model
{
    public class Jump
    {
        public Tile To { get; }

        public Jump(Tile to)
        {
            To = to;
        }

        public static void InitJumps(Game game)
        {
            game.AddJump(1, 43);
            game.AddJump(5, 34);
            game.AddJump(11, 9);
            game.AddJump(18, 2);
            game.AddJump(29, 33);
            game.AddJump(41, 78);
            game.AddJump(47, 65);
            game.AddJump(48, 27);
            game.AddJump(57, 43);
            game.AddJump(61, 41);
            game.AddJump(69, 73);
            game.AddJump(76, 84);
            game.AddJump(83, 15);
            game.AddJump(88, 93);
            game.AddJump(96, 86);
        }
    }
}
