using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = lengths[0];
            int m = lengths[1];

            HashSet<int> elementsOne = new HashSet<int>();
            HashSet<int> elementsTwo = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                elementsOne.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                elementsTwo.Add(number);
            }
            
            HashSet<int> uniqueNumbers = new HashSet<int>();

            foreach (var number in elementsOne)
            {
                if (elementsTwo.Contains(number))
                {
                    uniqueNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", uniqueNumbers));
        }
    }
}
