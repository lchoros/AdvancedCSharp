using System;
using System.Collections.Generic;
using System.Linq;


namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split(' ').Select(int.Parse);
            Queue<int> queOrders = new Queue<int>(orders);

            if (queOrders.Any())
            {
                Console.WriteLine(queOrders.Max());
            }

            while (queOrders.Count > 0)
            {
                var currentOrder = queOrders.Peek();
                if (quantity > currentOrder)
                {
                    queOrders.Dequeue();
                    quantity -= currentOrder;
                }
                else
                {
                    break;
                }
            }

            if (queOrders.Any())
            {
                Console.WriteLine("Orders left: {0}", string.Join(" ", queOrders));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
