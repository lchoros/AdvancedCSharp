using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            }


        }
    }
}
