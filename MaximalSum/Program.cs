using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            int maxSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < cols-2; col++)
                {
                    int sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] + matrix[row + 1][col] + matrix[row + 1][col + 1] + 
                        matrix[row + 1][col + 2] + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row+2][col+2];
                    if (sum > maxSum)
                    {
                        rowIndex = row;
                        colIndex = col;
                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine("Sum = {0}", maxSum);
            Console.WriteLine("{0} {1} {2}", matrix[rowIndex][colIndex], matrix[rowIndex][colIndex+1], matrix[rowIndex][colIndex+2]);
            Console.WriteLine("{0} {1} {2}", matrix[rowIndex+1][colIndex], matrix[rowIndex+1][colIndex+1], matrix[rowIndex+1][colIndex+2]);
            Console.WriteLine("{0} {1} {2}", matrix[rowIndex+2][colIndex], matrix[rowIndex+2][colIndex+1], matrix[rowIndex+2][colIndex+2]);
        }
    }
}
