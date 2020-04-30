using System;

namespace HelenaAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] field = new char[rows][];
            int parisRowIndex = 0;
            int parisColIndex = 0;

            int cols = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] fields = Console.ReadLine().ToCharArray();
                field[row] = fields;
                cols = fields.Length;

                for (int col = 0; col < cols; col++)
                {
                    char currentField = field[row][col];
                    if (currentField == 'P')
                    {
                        parisRowIndex = row;
                        parisColIndex = col;
                        field[row][col] = '-';
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                string move = command[0];
                field[int.Parse(command[1])][int.Parse(command[2])] = 'S';
                
                if (move == "up")
                {
                    if (parisRowIndex - 1 >= 0)
                    {
                        parisRowIndex--;
                    }
                }
                else if (move == "down")
                {
                    if (parisRowIndex + 1 < rows)
                    {
                        parisRowIndex++;
                    }
                }
                else if (move == "left")
                {
                    if (parisColIndex - 1 >= 0)
                    {
                        parisColIndex--;
                    }
                }
                else if (move == "right")
                {
                    if (parisColIndex + 1 < cols)
                    {
                        parisColIndex++;
                    }
                }

                energy--;

                if (field[parisRowIndex][parisColIndex] == 'H')
                {
                    field[parisRowIndex][parisColIndex] = '-';
                    Console.WriteLine($"Paris has successfully sat on the throne! Energy left: {energy}");
                    break;
                }

                if (field[parisRowIndex][parisColIndex] == 'S')
                {
                    energy -= 2;
                    field[parisRowIndex][parisColIndex] = '-';
                }

                if (energy <= 0)
                {
                    field[parisRowIndex][parisColIndex] = 'X';
                    Console.WriteLine($"Paris died at {parisRowIndex};{parisColIndex}.");
                    break;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join("", field[row]));
            }
        }
    }
}
