using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> print = Console.WriteLine;
            Func<List<int>, int> funcPerSmallest = x => x.Min();

            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            print(funcPerSmallest(numbers));
        }
    }
}
