using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                box.Add(item);
            }

            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Swap(box.Items, firstIndex, secondIndex);
            Console.WriteLine(box);
        }

        public static void Swap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T tempItem = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempItem;
        }
    }
}
