using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> lettersStack = new Stack<char>(input);

            while (lettersStack.Count != 0)
            {
                Console.Write(lettersStack.Pop());
            }
        }
    }
}
