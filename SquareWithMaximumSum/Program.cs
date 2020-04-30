using System;
using System.Linq;
using System.Text;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            int[][] matrix = new int[rows][];


            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int highestSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    int tl = matrix[row][col];
                    int tr = matrix[row][col+1];
                    int bl = matrix[row+1][col];
                    int br = matrix[row + 1][col+1];
                    int squareSum = tl + tr + bl + br;
                    if (squareSum > highestSum)
                    {
                        selectedRow = row;
                        selectedCol = col;
                        highestSum = squareSum;
                    }
                }
            }
            Console.WriteLine("{0} {1}", matrix[selectedRow][selectedCol], matrix[selectedRow][selectedCol + 1]);
            Console.WriteLine("{0} {1}", matrix[selectedRow + 1][selectedCol], matrix[selectedRow+1][selectedCol + 1]);
            Console.WriteLine(highestSum);
        }
    }
}
