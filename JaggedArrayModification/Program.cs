using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(' ');
                string operation = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int num = int.Parse(tokens[3]);

                if (row < 0 || row >= size || col < 0 || col >= size)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;               
                }
                if (operation == "Add")
                {
                    matrix[row][col] += num;
                }
                else if (operation == "Subtract")
                {
                    matrix[row][col] -= num;
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
