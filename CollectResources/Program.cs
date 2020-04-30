using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectResources
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] resourcesInfo = Console.ReadLine().Split(" ");
            var resources = new List<Tuple<string, int, bool, bool>>();
            for (int r = 0; r < resourcesInfo.Length; r++)
            {
                var token = resourcesInfo[r].Split("_");
                string name = token[0];
                int value = token.Length == 1 ? 1 : int.Parse(token[1]);
                bool isValid = name == "stone" || name == "gold" || name == "wood" || name == "food";
                resources.Add(Tuple.Create(name, value, isValid, true));
            }

            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int[] path = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int start = path[0];
                int step = path[1];

                while (true)
                {
                    var resource = resources[start];
                    bool canCollect = resource.Item4;

                    if (!canCollect)
                    {
                        break;
                    }

                    bool isValid = resource.Item3;


                    if (start + step > resources.Count)
                    {
                        start = start + step - resources.Count;
                    }
                }                
            }
            Console.WriteLine(counter);
        }
    }
}
                    //if (isValid)
                    //{
                    //    counter += resource.Item2;
                    //    resources[start] = false;
                    //}