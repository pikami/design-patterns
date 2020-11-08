using System;

namespace TE.Command
{
    public class Player
    {
        public int x = 0;
        public int y = 0;

        public string GetPosition() => $"[{x} / {y}]";

        public void Move(string direction)
        {
            switch(direction)
            {
                case "up":
                    y++;
                    break;
                case "down":
                    y--;
                    break;
                case "left":
                    x--;
                    break;
                case "right":
                    x++;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
