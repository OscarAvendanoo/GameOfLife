using System.Diagnostics.Metrics;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 70;
            int height = 40;
            int numberOfGenerations = 1000;
            Cells[,] gridOfCells = new Cells[height, width];
            SeedGenerator seedGenerator = new SeedGenerator();
            RunSimulation runSimulation = new RunSimulation();
            NeighbourLocator neighbourLocator = new NeighbourLocator();
            CreateBlankGeneration(width, height, gridOfCells);
            CreateInitialStates(width, height, gridOfCells, seedGenerator);
            neighbourLocator.LocateNeigbours(gridOfCells, width, height);
            runSimulation.Run(numberOfGenerations,width, height, gridOfCells);


        }
        // creates all the cell objects and stoes them inside a 2D array
        private static void CreateBlankGeneration(int width, int height, Cells[,] gridOfCells)
        {
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    Cells cell = new Cells();
                    cell.Cordinate = i.ToString() + "," + j.ToString();
                    gridOfCells[i, j] = cell;
                    
                }
            int counter = 0;

        // asigns each cell a state, the outer bound of the cordinatesystem gets the state "boarder"
        // the rest of the cells is asigned the state "Dead"
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || j == 0 || i == height - 1 || j == width - 1)
                    {
                        gridOfCells[i, j].State = "Border";
                    }
                    else
                    {
                        gridOfCells[i, j].State = "Dead";
                    }
                
                }
        }

        // Loads an alive cell pattern to the the initial generation of cells
        private static void CreateInitialStates(int width, int height, Cells[,] gridOfCells, SeedGenerator seedGenetaror)
        {
            Console.WriteLine("which seed would you like to load?");
            Console.WriteLine("pulsar(1), glider(2) or deca(3)?");
            Console.WriteLine("Choose 1 or 2 or 3;");
            
                string choice = Console.ReadLine();
                if (choice is "1")
                {
                    seedGenetaror.CreatePulsar(gridOfCells, width, height);
                }
                else if (choice is "2")
                {
                    seedGenetaror.CreateGlider(gridOfCells, width, height);
                }
                else if (choice is "3")
                {
                    seedGenetaror.CreateDeca(gridOfCells, width, height);
                }

        }
        }
    }
