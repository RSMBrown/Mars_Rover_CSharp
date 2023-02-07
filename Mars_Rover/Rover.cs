using System;

namespace RoverNamespace
{
    internal class Rover
    {
        public int posx { get; set; }
        public int posy { get; set; }
        public string direction { get; set; }

        public Rover(int x, int y, string newdir)
        {
            this.posx = x;
            this.posy = y;
            this.direction = newdir;
        }
    }
}
