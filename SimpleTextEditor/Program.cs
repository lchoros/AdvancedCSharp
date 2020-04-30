using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stackOfText = new Stack<string>();
            int lastOperation = 0;
            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split(' ');
                char command = char.Parse(token[0]);
                switch (command)
                {
                    case '1':
                        stackOfText.Push(token[1]);
                        break;
                    case '2':
                        stackOfText.Push(token[1]);
                        break;
                    case '3':
                        break;
                    case '4':
                        
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
