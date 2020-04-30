using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse);
            Stack<int> stak = new Stack<int>(input);
            StringBuilder sb = new StringBuilder();
            while (stak.Count > 0)
            {
                sb.Append($"{stak.Pop()} ");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
