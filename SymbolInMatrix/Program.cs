using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row][col] == symbol)
                    {
                        isFound = true;
                        Console.WriteLine("({0}, {1})", row, col);
                        return;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("{0} does not occur in the matrix", symbol);
            }
        }
    }
}
