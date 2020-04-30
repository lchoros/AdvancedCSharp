using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];

            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }
        }
    }
}
