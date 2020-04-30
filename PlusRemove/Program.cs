using System;
using System.Collections.Generic;

namespace PlusRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine().ToLower();

            List<string> lines = new List<string>();
            //while (input != "end")
            //{
            //    lines.Add(input);
            //    input = Console.ReadLine().ToLower();
            //}
            lines.Add("888**t*");
            lines.Add("8888ttt");
            lines.Add("888ttt<<");
            lines.Add("*8*0t>>hi");

            int rows = lines.Count;
            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = lines[row].ToCharArray();
            }

            for (int row = 1; row < rows-1; row++)
            {
                for (int col = 1; col < matrix[row].Length-1; col++)
                {
                    var m1 = matrix[row][col];
                    var m2 = matrix[row][col - 1];
                    var m3 = matrix[row][col + 1];
                    var m4 = matrix[row - 1][col];
                    var m5 = matrix[row + 1][col];

                    if (m1 == m2 && m1 == m3 && m1 == m4 && m1 == m5)
                    {
                        matrix[row][col] = ' ';
                        matrix[row][col - 1] = ' ';
                        matrix[row][col + 1] = ' ';
                        matrix[row - 1][col] = ' ';
                        matrix[row + 1][col] = ' ';
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] != ' ')
                    {
                        Console.Write(matrix[row][col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
