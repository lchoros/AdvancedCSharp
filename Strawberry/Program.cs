using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintTop(size);
            PrintMiddle(size);
            PrintBottom(size);
        }

        public static void PrintTop(int size)
        {
            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', i * 2), new string('-', size-i*2));
            }
        }

        public static void PrintMiddle(int size)
        {
            int totalLength = size * 2 + 3;
            for (int i = 0; i < (int)Math.Ceiling(size / 2m); i++)
            {
                int numberOfDashes = size - i * 2;
                int numberOfDots = totalLength - numberOfDashes * 2 - 2;
                Console.WriteLine("{0}#{1}#{0}", new string('-', numberOfDashes), new string('.', numberOfDots));
            }
        }

        public static void PrintBottom(int size)
        {
            int totalLength = size * 2 + 3;
            for (int i = 0; i < size+1; i++)
            {
                int numberOfDashes = i;
                int numberOfDots = totalLength - numberOfDashes * 2 - 2;
                Console.WriteLine("{0}#{1}#{0}", new string('-', numberOfDashes), new string('.', numberOfDots));
            }
        }
    }
}
