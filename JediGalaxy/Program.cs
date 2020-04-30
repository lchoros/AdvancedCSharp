using System;
using System.Linq;

namespace JediGalaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[][] matrix = new int[rows][];

            int counter = 1;
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new int[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = counter;
                    counter++;
                }
            }

            string input = Console.ReadLine();
            int[] ivoCoordinates = new int[2];
            int[] evilCoordinates = new int[2];
            //while (input != )
        }
    }
}
