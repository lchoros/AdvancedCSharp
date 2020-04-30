using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, 0);
                }
                shops[shop][product] = price;
                input = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine("{0}->", shop.Key);
                foreach (var product in shop.Value)
                {
                    Console.WriteLine("Product: {0}, Price: {1}", product.Key, product.Value);
                }
            }
        }
    }
}
