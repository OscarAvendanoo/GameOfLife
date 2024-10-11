using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class UpdateWorld
    {
        // method responsible for printing out each generation of cells to the console
        // and also calculates the cells state in the next generation
        public String[,] UpdateTheWorld(Cells[,] gridOfCells, int width, int height)
        {
            int numberOfAliveNeighbours;
            NeighbourCalculator neighbourCalculator = new NeighbourCalculator();
            String[,] nextGeneration = new String[height,width];

           
                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                    {
                    if((gridOfCells[i, j].State) == "Border")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("█");
                        Console.ResetColor();
                    }
                    else if ((gridOfCells[i, j].State) == "Alive")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("█");
                        Console.ResetColor();
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("-");
                        Console.ResetColor();
                    }
                    
                        if(j == width - 1)
                    {
                        Console.WriteLine();
                    }
                           

                    if (gridOfCells[i, j].State != "Border")
                    {
                        numberOfAliveNeighbours = neighbourCalculator.countAliveNeighbours(gridOfCells[i, j]);

                    
                        if (gridOfCells[i, j].State == "Alive" && (numberOfAliveNeighbours == 2 || numberOfAliveNeighbours == 3))
                            {
                                nextGeneration[i,j] = "Alive";
                            }
                                

                        else if (gridOfCells[i, j].State == "Dead" && numberOfAliveNeighbours == 3)
                            {
                                nextGeneration[i, j] = "Alive";
                            }


                        else
                        {
                            nextGeneration[i, j] = "Dead";
                        }
                        
                    }

                     
                    }


            return nextGeneration;
        }
        
    }
}

