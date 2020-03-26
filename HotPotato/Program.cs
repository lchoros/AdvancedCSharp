using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split(' '));
            int counter = int.Parse(Console.ReadLine());

            while (kids.Count > 1)
            {
                for (int i = 1; i < counter; i++)
                {
                    var kid = kids.Dequeue();
                    kids.Enqueue(kid);
                }
                Console.WriteLine("Removed {0}", kids.Dequeue());
            }
            Console.WriteLine("Last is {0}", kids.Dequeue());
        }
    }
}
