namespace Stigespill_v2.Model
{
    public class Jump
    {
        public static int CheckForJumpTile(int currentTile)
        {
            if (currentTile == 1) return 43;
            else if (currentTile == 5) return 34;
            else if (currentTile == 11) return 9;
            else if (currentTile == 18) return 2;
            else if (currentTile == 29) return 33;
            else if (currentTile == 41) return 78;
            else if (currentTile == 47) return 65;
            else if (currentTile == 48) return 27;
            else if (currentTile == 57) return 43;
            else if (currentTile == 61) return 41;
            else if (currentTile == 69) return 73;
            else if (currentTile == 76) return 84;
            else if (currentTile == 83) return 15;
            else if (currentTile == 88) return 93;
            else if (currentTile == 96) return 86;
            else return currentTile;
        }
    }
}
