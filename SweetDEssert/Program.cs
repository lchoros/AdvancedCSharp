using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDEssert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggs = decimal.Parse(Console.ReadLine());
            decimal berries = decimal.Parse(Console.ReadLine());
            int portions = (int)Math.Ceiling(numberOfGuests / 6M);

            decimal totalPrice = portions * (2*bananaPrice + 4*eggs + 0.2M * berries);

            if(cash >= totalPrice)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalPrice);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", totalPrice-cash);
            }
        }
    }
}
