using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                box.Add(item);
            }

            string toCompare = Console.ReadLine();

            Console.WriteLine(CountGreater(box.Items, toCompare));
        }

        public static int CountGreater<T>(List<T> items, T value)
            where T : IComparable
        {
            int counter = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(value) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
