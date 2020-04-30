using System;
using System.Linq;

namespace SquareMatrixChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[][] matrix = new char[rows][];
            int squareCounter = 0;

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    int m = matrix[row][col];
                    if (m == matrix[row][col+1] && m == matrix[row+1][col] && m == matrix[row+1][col+1])
                    {
                        squareCounter++;
                    }
                }
            }
            Console.WriteLine(squareCounter);
        }
    }
}
