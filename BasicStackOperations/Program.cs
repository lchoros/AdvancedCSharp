using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int pushCounter = input[0];
            int popCounter = input[1];
            int elementToFind = input[2];


            var inputLine = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);
            Stack<int> stak = new Stack<int>(inputLine);
            for (int i = 0; i < popCounter; i++)
            {
                stak.Pop();
            }

            if (stak.Any())
            {
                if (stak.Contains(elementToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stak.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
