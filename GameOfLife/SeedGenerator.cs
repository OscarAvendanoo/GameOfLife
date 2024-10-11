using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class SeedGenerator
    {
        // hardcoded cordinates for Alive cells depending on the choice of pattern
        public void CreatePulsar(Cells[,] gridOfCells, int width, int height)
        {

            gridOfCells[4, 16].State = "Alive";
            gridOfCells[4, 17].State = "Alive";
            gridOfCells[4, 18].State = "Alive";
            gridOfCells[4, 22].State = "Alive";
            gridOfCells[4, 23].State = "Alive";
            gridOfCells[4, 24].State = "Alive";

            gridOfCells[6, 14].State = "Alive";
            gridOfCells[6, 19].State = "Alive";
            gridOfCells[6, 21].State = "Alive";
            gridOfCells[6, 26].State = "Alive";

            gridOfCells[7, 14].State = "Alive";
            gridOfCells[7, 19].State = "Alive";
            gridOfCells[7, 21].State = "Alive";
            gridOfCells[7, 26].State = "Alive";

            gridOfCells[8, 14].State = "Alive";
            gridOfCells[8, 19].State = "Alive";
            gridOfCells[8, 21].State = "Alive";
            gridOfCells[8, 26].State = "Alive";

            gridOfCells[9, 16].State = "Alive";
            gridOfCells[9, 17].State = "Alive";
            gridOfCells[9, 18].State = "Alive";
            gridOfCells[9, 22].State = "Alive";
            gridOfCells[9, 23].State = "Alive";
            gridOfCells[9, 24].State = "Alive";



            gridOfCells[11, 16].State = "Alive";
            gridOfCells[11, 17].State = "Alive";
            gridOfCells[11, 18].State = "Alive";
            gridOfCells[11, 22].State = "Alive";
            gridOfCells[11, 23].State = "Alive";
            gridOfCells[11, 24].State = "Alive";

            gridOfCells[12, 14].State = "Alive";
            gridOfCells[12, 19].State = "Alive";
            gridOfCells[12, 21].State = "Alive";
            gridOfCells[12, 26].State = "Alive";

            gridOfCells[13, 14].State = "Alive";
            gridOfCells[13, 19].State = "Alive";
            gridOfCells[13, 21].State = "Alive";
            gridOfCells[13, 26].State = "Alive";

            gridOfCells[14, 14].State = "Alive";
            gridOfCells[14, 19].State = "Alive";
            gridOfCells[14, 21].State = "Alive";
            gridOfCells[14, 26].State = "Alive";

            gridOfCells[16, 16].State = "Alive";
            gridOfCells[16, 17].State = "Alive";
            gridOfCells[16, 18].State = "Alive";
            gridOfCells[16, 22].State = "Alive";
            gridOfCells[16, 23].State = "Alive";
            gridOfCells[16, 24].State = "Alive";

        }

        public void CreateGlider(Cells[,] gridOfCells, int width, int height)
        {
            gridOfCells[1, 3].State = "Alive";
            gridOfCells[1, width - 4].State = "Alive";
            gridOfCells[2, 1].State = "Alive";
            gridOfCells[2, 3].State = "Alive";
            gridOfCells[2, width - 2].State = "Alive";
            gridOfCells[2, width - 4].State = "Alive";

            gridOfCells[3, 2].State = "Alive";
            gridOfCells[3, 3].State = "Alive";
            gridOfCells[3, width - 3].State = "Alive";
            gridOfCells[3, width - 4].State = "Alive";

            gridOfCells[height - 4, 2].State = "Alive";
            gridOfCells[height - 4, 3].State = "Alive";
            gridOfCells[height - 4, width - 3].State = "Alive";
            gridOfCells[height - 4, width - 4].State = "Alive";
            gridOfCells[height - 3, 1].State = "Alive";
            gridOfCells[height - 3, 3].State = "Alive";
            gridOfCells[height - 3, width - 2].State = "Alive";
            gridOfCells[height - 3, width - 4].State = "Alive";
            gridOfCells[height - 2, 3].State = "Alive";
            gridOfCells[height - 2, width - 4].State = "Alive";

        }

        public void CreateDeca(Cells[,] gridOfCells, int width, int height)
        {

            gridOfCells[height - 7, width - 18].State = "Alive";
            gridOfCells[height - 7, width - 19].State = "Alive";
            gridOfCells[height - 7, width - 20].State = "Alive";

            gridOfCells[height - 8, width - 19].State = "Alive";
            gridOfCells[height - 9, width - 19].State = "Alive";

            gridOfCells[height - 10, width - 18].State = "Alive";
            gridOfCells[height - 10, width - 19].State = "Alive";
            gridOfCells[height - 10, width - 20].State = "Alive";

            gridOfCells[height - 12, width - 18].State = "Alive";
            gridOfCells[height - 12, width - 19].State = "Alive";
            gridOfCells[height - 12, width - 20].State = "Alive";
            gridOfCells[height - 13, width - 18].State = "Alive";
            gridOfCells[height - 13, width - 19].State = "Alive";
            gridOfCells[height - 13, width - 20].State = "Alive";

            gridOfCells[height - 18, width - 18].State = "Alive";
            gridOfCells[height - 18, width - 19].State = "Alive";
            gridOfCells[height - 18, width - 20].State = "Alive";

            gridOfCells[height - 17, width - 19].State = "Alive";
            gridOfCells[height - 16, width - 19].State = "Alive";

            gridOfCells[height - 15, width - 18].State = "Alive";
            gridOfCells[height - 15, width - 19].State = "Alive";
            gridOfCells[height - 15, width - 20].State = "Alive";

        }
    }
}
