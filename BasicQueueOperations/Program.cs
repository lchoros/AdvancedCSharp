using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = operations[0];
            int s = operations[1];
            int x = operations[2];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse);
            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                if(queue.Any())
                {
                    queue.Dequeue();
                }
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
