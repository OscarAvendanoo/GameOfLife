using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class RunSimulation
    {
        // The metod which runs the simulation
        public void Run(int numberOfGenerations, int width, int height, Cells[,] gridOfCells)
        {
            UpdateWorld updateWorld = new UpdateWorld();
            String[,] nextGeneration = new String[height, width];

            for (int i = 0; i <numberOfGenerations; i++)
            {
                Console.Clear();
                nextGeneration = updateWorld.UpdateTheWorld(gridOfCells, width, height);
                for (int j = 0; j < height; j++)
                    for (int k = 0; k < width; k++)
                    {
                        if (nextGeneration[j,k] != null)
                        {
                            gridOfCells[j, k].State = nextGeneration[j, k];
                        }
                    }
                
                        Thread.Sleep(3);
            }



        }
    }
}
