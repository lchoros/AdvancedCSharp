using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split(' '));
            int counter = int.Parse(Console.ReadLine());
            int cycle = 1;
            while (kids.Count > 1)
            {
                for (int i = 1; i < counter; i++)
                {
                    string name = kids.Dequeue();
                    kids.Enqueue(name);
                }

                if (IsPrime(cycle))
                {
                    Console.WriteLine("Removed: {0}", kids.Dequeue());
                }
                else
                {
                    Console.WriteLine("Prime {0}", kids.Peek());
                }
                cycle++;
            }
            Console.WriteLine("Last is {0}", kids.Dequeue());
        }

        static bool IsPrime(int number)
        {
            if ((number % 2) == 0)
            {
                return number == 2;
            }
            int sqrt = (int)Math.Sqrt(number);
            for (int t = 3; t <= sqrt; t = t + 2)
            {
                if (number % t == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }
    }
}