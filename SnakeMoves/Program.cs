using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            string snake = Console.ReadLine();

            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = snake.Take(snake.Length-1).ToArray();
                Console.WriteLine(string.Join("", matrix[row]));
                char lastCharacter = char.Parse(snake.Substring(snake.Length - 1));
                snake = lastCharacter + string.Join("", matrix[row]);
            }
        }
    }
}
