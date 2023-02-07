using CellNamespace;
using System;
using RoverNamespace;
using System.Data;

namespace PlateauNamespace
{
    internal class Plateau
    {
        public int width { get; set; }
        public int height { get; set; }
        public List<Cell> grid { get; set; }

        public Plateau(int w, int h)
        {
            this.width = w;
            this.height = h;

            IEnumerable<int> rangeWidth = Enumerable.Range(1, width + 1);
            IEnumerable<int> rangeHeight = Enumerable.Range(1, height + 1);

            foreach (int col in rangeWidth)
            {
                foreach (int row in rangeHeight)
                {
                    Cell newCell = new Cell();
                    newCell.x = row;
                    newCell.y = col;
                    newCell.roverCount= 0;
                    this.grid.Add(newCell);
                }
            }
        }

        public void printGrid(List<Rover> rovers)
        {
            foreach (Cell i in this.grid)
            {
                i.roverCount = 0;

                foreach (Rover rover in rovers)
                {
                    if (rover.posx == i.x && rover.posy == i.y)
                    {
                        i.roverCount++;
                    }
                }
            }

            IEnumerable<int> rangeHeight = Enumerable.Range(1, this.height);
            IEnumerable<int> rangeWidth = Enumerable.Range(1, this.width);

            foreach (int row in rangeHeight )
            {
                string rowString = "";
                
                foreach (int col in rangeWidth )
                {
                    foreach (Cell j in this.grid)
                    {
                        if (j.x == row && j.y == col)
                        {
                            string roverCountString = Convert.ToString(j.roverCount);
                            rowString += roverCountString;
                        }
                    }
                }

                Console.WriteLine(rowString);
            }
        }
    }
}
