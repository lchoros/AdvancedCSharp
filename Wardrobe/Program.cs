using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string type = clothes[j];
                    if (!wardrobe[color].ContainsKey(type))
                    {
                        wardrobe[color].Add(type, 0);
                    }
                    wardrobe[color][type]++;
                }
            }

            string[] item = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string itemColor = item[0];
            string itemType = item[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var type in color.Value)
                {
                    if (color.Key == itemColor && type.Key == itemType)
                    {
                        Console.WriteLine($"* {type.Key} - {type.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {type.Key} - {type.Value}");
                    }
                }
            }
        }
    }
}
