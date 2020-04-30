using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            ReadCars(n, cars);

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split();
                string model = tokens[1];
                decimal distance = decimal.Parse(tokens[2]);

                var car = cars.FirstOrDefault(m => m.Model == model);

                car.Drive(distance);

                command = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }   
        }

        static void ReadCars(int n, List<Car> cars)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                var car = new Car(input[0], decimal.Parse(input[1]), decimal.Parse(input[2]));
                cars.Add(car);
            }
        }


    }
}
