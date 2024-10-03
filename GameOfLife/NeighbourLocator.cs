using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class NeighbourLocator
    {


        public void LocateNeigbours(Cells[,] cell, int width, int height)
        {
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    if (cell[i, j].State != "#")
                    {
                        cell[i, j].NeighbourTl = cell[i-1, j-1];
                        cell[i, j].NeighbourT = cell[i-1, j]; //likadana? ändra
                        cell[i, j].NeighbourTr = cell[i-1, j+1];
                        cell[i, j].NeighbourL = cell[i, j-1];  // likadana? ändra
                        cell[i, j].NeighbourR = cell[i, j+1];
                        cell[i, j].NeighbourBl = cell[i+1, j-1];
                        cell[i, j].NeighbourB = cell[i+1, j];
                        cell[i, j].NeighbourBr = cell[i+1, j + 1];
                    }
                }
        }
    }
}
