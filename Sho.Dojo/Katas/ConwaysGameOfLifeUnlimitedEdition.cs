using System;
using System.Threading;

namespace Sho.Dojo.Katas
{
    public class ConwaysGameOfLifeUnlimitedEdition
    {
        //public static int[,] GetGeneration(int[,] cells, int generation)
        //{
        //    if (IsDeadWorld(cells))
        //    {
        //        return new int[0,0];
        //    }

        //    int[,] world = cells;
        //    int phase = 0;

        //    while (phase < generation)
        //    {
        //        //Visualize(world, phase);
        //        world = CalculateNextWorld(world);
        //        phase++;

        //        if (!IsDeadWorld(world))
        //        {
        //            world = CropWorld(world);
        //        }
        //        else
        //        {
        //            world = new int[0, 0];
        //            break;
        //        }
        //    }

        //    //Visualize(world, phase);

        //    return world;
        //}

        public static int[,] GetGeneration(int[,] cells, int generation)
        {
            if (IsDeadWorld(cells))
            {
                return new int[0, 0];
            }

            int[,] world = cells;
            int phase = 0;

            while (phase < generation)
            {
                world = CalculateNextWorld(world);
                phase++;

                if (!IsDeadWorld(world))
                {
                    world = CropWorld(world);
                }
                else
                {
                    world = new int[0, 0];
                    break;
                }
            }

            return world;
        }

        private static int[,] CalculateNextWorld(int[,] world)
        {
            int[,] largerWorld = ExtendWorld(world);
            int[,] newWorld = new int[largerWorld.GetLength(0), largerWorld.GetLength(1)];

            for (int row = 0; row < newWorld.GetLength(0); row++)
            {
                for (int col = 0; col < newWorld.GetLength(1); col++)
                {
                    int sum = GetCellValue(largerWorld, row - 1, col - 1);
                    sum += GetCellValue(largerWorld, row - 1, col);
                    sum += GetCellValue(largerWorld, row - 1, col + 1);
                    sum += GetCellValue(largerWorld, row, col - 1);
                    sum += GetCellValue(largerWorld, row, col + 1);
                    sum += GetCellValue(largerWorld, row + 1, col - 1);
                    sum += GetCellValue(largerWorld, row + 1, col);
                    sum += GetCellValue(largerWorld, row + 1, col + 1);

                    int cellValue = 0;

                    if ((largerWorld[row, col] == 1 && (sum == 2 || sum == 3)) 
                        || (largerWorld[row, col] == 0 && sum == 3))
                    {
                        cellValue = 1;
                    }

                    newWorld[row, col] = cellValue;
                }
            }

            return newWorld;
        }

        private static int[,] ExtendWorld(int[,] world)
        {
            int[,] largerWorld = new int[world.GetLength(0) + 2, world.GetLength(1) + 2];

            for (int row = 0; row < largerWorld.GetLength(0); row++)
            {
                for (int col = 0; col < largerWorld.GetLength(1); col++)
                {
                    if (row != 0 && col != 0 && row <= world.GetLength(0) && col <= world.GetLength(1))
                    {
                        largerWorld[row, col] = world[row-1, col-1];
                    }
                }
            }

            return largerWorld;
        }

        private static int[,] CropWorld(int [,] world)
        {
            int rowLowerBound = Find2DBound(world, true, true);
            int colLowerBound = Find2DBound(world, false, true);
            int rowUpperBound = Find2DBound(world, true, false);
            int colUpperBound = Find2DBound(world, false, false);

            int rowLength = rowUpperBound - rowLowerBound+1;
            int colLength = colUpperBound - colLowerBound+1;

            int[,] croppedWorld = new int[rowLength, colLength];

            for (int row = 0; row < croppedWorld.GetLength(0); row++)
            {
                for (int col = 0; col < croppedWorld.GetLength(1); col++)
                {
                    croppedWorld[row, col] = world[row + rowLowerBound, col + colLowerBound];
                }
            }

            return croppedWorld;
        }

        private static int Find2DBound(int[,] world, bool isRowDimension, bool isLower)
        {
            int dimension = isRowDimension ? 0 : 1;
            int iterateDimension = isRowDimension ? 1 : 0;
            int bound = isLower ? world.GetLowerBound(dimension) : world.GetUpperBound(dimension);
            bool crop = true;

            while (crop == true && ((bound != 0 && !isLower) || (bound < world.GetLength(dimension) && isLower)))
            {
                for (int i = 0; i < world.GetLength(iterateDimension); i++)
                {
                    if (dimension == 0)
                    {
                        if (world[bound, i] == 1)
                        {
                            crop = false;
                        }
                    }
                    else if (dimension == 1)
                    {
                        if (world[i, bound] == 1)
                        {
                            crop = false;
                        }
                    }
                }

                if (crop)
                {
                    bound = isLower ? bound + 1 : bound - 1;
                }
            }

            return bound;
        }

        private static int GetCellValue(int[,] world, int row, int col)
        {
            return row >= 0 && col >= 0 && row < world.GetLength(0) && col < world.GetLength(1) 
                ? world[row, col] 
                : 0;
        }

        private static bool IsDeadWorld(int[,] world)
        {
            bool isDead = true;

            if (world.GetLength(0) == 0 || world.GetLength(1) == 0)
            {
                return isDead;
            }

            for (int row = 0; row < world.GetLength(0); row++)
            {
                for (int col = 0; col < world.GetLength(1); col++)
                {
                    if (world[row, col] == 1)
                    {
                        isDead = false;
                        break;
                    }
                }
            }

            return isDead;
        }

        private static void Visualize(int[,] world, int phase)
        {
            Console.Clear();
            Console.WriteLine($"Generation: {phase}\n");

            for (int row = 0; row < world.GetLength(0); row++)
            {
                for (int column = 0; column < world.GetLength(1); column++)
                {
                    Console.Write(world[row, column] == 1 ? "▓▓" : "░░");
                }

                Console.WriteLine();
            }

            Thread.Sleep(2000);
        }
    }
}

/* Conway's Game of Life - Unlimited Edition
Given a 2D array and a number of generations, compute n timesteps of Conway's Game of Life.
The rules of the game are:
Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
Any live cell with more than three live neighbours dies, as if by overcrowding.
Any live cell with two or three live neighbours lives on to the next generation.
Any dead cell with exactly three live neighbours becomes a live cell.
Each cell's neighborhood is the 8 cells immediately around it (i.e. Moore Neighborhood).
The universe is infinite in both the x and y dimensions and all cells are initially dead - except for those specified in the arguments.
The return value should be a 2d array cropped around all of the living cells. (If there are no living cells, then return [[]].)
For illustration purposes, 0 and 1 will be represented as ░░ and ▓▓ blocks respectively (PHP, C: plain black and white squares)
You can take advantage of the htmlize function to get a text representation of the universe, e.g.: trace (htmlize cells)
 */
