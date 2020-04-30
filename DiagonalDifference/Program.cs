using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = row; col <= row; col++)
                {
                    primaryDiagonalSum += matrix[row][col];
                    secondaryDiagonalSum += matrix[row][size - row - 1];
                }                
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
