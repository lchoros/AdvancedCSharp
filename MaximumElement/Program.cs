using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stak = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int queryType = query[0];
                if (queryType == 1)
                {
                    stak.Push(query[1]);
                }
                else if (queryType == 2)
                {
                    if (stak.Any())
                    {
                        stak.Pop();
                    }
                }
                else if (queryType == 3)
                {
                    if (stak.Any())
                    {
                        Console.WriteLine(stak.Max());
                    }
                }
                else if (queryType == 4)
                {
                    if (stak.Any())
                    {
                        Console.WriteLine(stak.Min());
                    }
                }
            }
            if (stak.Any())
            {
                Console.WriteLine(string.Join(", ", stak));
            }
        }
    }
}
