using System;
using System.Collections.Generic;
using System.Linq;

namespace CatapultAttack
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> walls = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Stack<int> rocks = new Stack<int>();


            for (int i = 0; i < n; i++)
            {
                rocks = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
                if ((i + 1) % 3 == 0)
                {
                    walls.Enqueue(int.Parse(Console.ReadLine()));
                }



            }
        }
                //for (int i = 0; i < n; i++)
                //{
                //    if ((i + 1) % 3 == 0)
                //    {
                //        walls.Add(int.Parse(Console.ReadLine()));
                //    }

                //    int[] rocks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                //}
        }
}
