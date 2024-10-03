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

        public String[,] UpdateTheWorld(Cells[,] gridOfCells, int width, int height)
        {
            int numberOfAliveNeighbours;
            NeighbourCalculator neighbourCalculator = new NeighbourCalculator();
            String[,] nextGeneration = new String[height,width];

           
                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                    {
                    if((gridOfCells[i, j].State) == "#")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("█");
                        Console.ResetColor();
                    }
                    else if ((gridOfCells[i, j].State) == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("█");
                        Console.ResetColor();
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(gridOfCells[i, j].State);
                        Console.ResetColor();
                    }
                    
                        if(j == width - 1)
                    {
                        Console.WriteLine();
                    }
                           

                    if (gridOfCells[i, j].State != "#")
                    {
                        numberOfAliveNeighbours = neighbourCalculator.countAliveNeighbours(gridOfCells[i, j]);

                    
                        if (gridOfCells[i, j].State == "X" && (numberOfAliveNeighbours == 2 || numberOfAliveNeighbours == 3))
                            {
                                nextGeneration[i,j] = "X";
                            }
                                

                        else if (gridOfCells[i, j].State == "-" && numberOfAliveNeighbours == 3)
                            {
                                nextGeneration[i, j] = "X";
                            }


                        else
                        {
                            nextGeneration[i, j] = "-";
                        }
                        
                    }

                     
                    }


            return nextGeneration;
        }
        
    }
}

