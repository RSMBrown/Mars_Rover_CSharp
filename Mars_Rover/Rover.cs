using System;

namespace RoverNamespace
{
    internal class Rover
    {
        public int posx = 0;
        public int posy = 0;
        public string direction = " ";

        public Rover(int x, int y, string newdir)
        {
            this.posx = x;
            this.posy = y;
            this.direction = newdir;
        }
    }
}
