using System;
using System.Linq;

namespace FindEVenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<> print = Console.WriteLine;
            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int start = range[0];
            int end = range[1];

            
            string command = Console.ReadLine();

            Predicate<string> predicate;

        }


    }
}
 