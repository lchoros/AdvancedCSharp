using System;
using System.Linq;

namespace AddVat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<decimal> printNum = num => Console.WriteLine($"{num * 1.2m:f2}");
            Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList().ForEach(printNum);
        }
    }
}
