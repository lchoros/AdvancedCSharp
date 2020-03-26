using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();
            while (num > 0)
            {
                result.Push(num % 2);
                num /= 2;
            }
            Console.WriteLine(string.Join("", result));
            while (result.Count != 0)
            {
                Console.Write(result.Pop());
            }
        }
    }
}
