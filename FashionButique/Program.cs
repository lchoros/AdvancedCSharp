using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionButique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothesStack = new Stack<int>(clothes);
            int rackCounter = 1;
            int clothesCounter = 0;

            while (clothesStack.Count > 0)
            {
                clothesCounter += clothesStack.Peek();

                if (clothesCounter < rackCapacity)
                {
                    clothesStack.Pop();
                }

                else if (clothesCounter > rackCapacity)
                {
                    clothesCounter = 0;
                    rackCounter++;
                }

                else if (clothesCounter == rackCapacity)
                {
                    clothesStack.Pop();
                    if (clothesStack.Count > 0)
                    {
                        rackCounter++;
                    }

                    clothesCounter = 0;
                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
