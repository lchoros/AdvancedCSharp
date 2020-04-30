using System;
using System.Linq;

namespace BombTheBasement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            int[] bombParamaters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
            }

            int bombRow = bombParamaters[0];
            int bombCol = bombParamaters[1];
            int radius = bombParamaters[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) +
                       Math.Pow(col - bombCol, 2));
                    if (distance <= radius)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = matrix[row].OrderByDescending(m => m).ToArray();
                Console.WriteLine(string.Join("", matrix[row]));
            }


        }
    }
}
