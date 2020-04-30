using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] matrix = new long[rows][];

            int cols = 1;
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new long[cols];
                matrix[row][0] = 1;
                matrix[row][cols - 1] = 1;
                if (cols > 2)
                {
                    long[] previousRow = matrix[row - 1];
                    for (int col = 1; col < cols - 1; col++)
                    {
                        matrix[row][col] = previousRow[col] + previousRow[col - 1];
                    }
                }
                cols++;
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
