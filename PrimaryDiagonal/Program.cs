using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];
            int sum = 0;
            for (int i = 0; i < size; i++)
            {                
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                sum += matrix[i][i];
            }
            Console.WriteLine(sum);

        }
    }
}
