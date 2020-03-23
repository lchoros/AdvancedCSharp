using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split(' ').ToArray();
                string action = tokens[0];
                switch (action)
                {
                    case "swap":
                        int firstIndex = int.Parse(tokens[1]);
                        int secondIndex = int.Parse(tokens[2]);
                        int temp = numbers[firstIndex];
                        numbers[firstIndex] = numbers[secondIndex];
                        numbers[secondIndex] = temp;
                        break;
                    case "multiply":
                        int firstIndex2 = int.Parse(tokens[1]);
                        int secondIndex2 = int.Parse(tokens[2]);
                        numbers[firstIndex2] = numbers[firstIndex2] * numbers[secondIndex2];
                        break;
                    case "decrease":
                        for (int index = 0; index < numbers.Count; index++)
                        {
                            numbers[index]--;
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(",", numbers));
         }
    }
}
