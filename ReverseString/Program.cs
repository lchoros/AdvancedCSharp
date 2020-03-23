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
            Stack<string> lettersStack = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                lettersStack.Push(input[i].ToString());
            }
            for (int i = 0; i < lettersStack.Count; i++)
            {
                Console.Write(lettersStack.Pop());
            }
        }
    }
}
