using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var engines = GetEngines();
            var cars = GetCars(engines);

            foreach (var car in cars)
            {
                Console.Write(car.ToString());
            }
        }

        static List<Car> GetCars(List<Engine> engines)
        {
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                var engineModel = tokens[1];

                var engine = engines.FirstOrDefault(e=>e.Model == engineModel);

                var car = new Car(model, engine);

                if (tokens.Length == 3)
                {
                    if (int.TryParse(tokens[2], out int weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = tokens[2];
                    }
                }
                else if (tokens.Length == 4)
                {
                    car.Weight = int.Parse(tokens[2]);
                    car.Color = tokens[3];
                }

                cars.Add(car);
            }
            return cars;
        }
        static List<Engine> GetEngines()
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                var engine = new Engine(model, power);
                if (tokens.Length > 2)
                {
                    var isdigit = int.TryParse(tokens[2], out int displacement);

                    if (isdigit)
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = tokens[2];
                    }

                    if (tokens.Length > 3)
                    {
                        if (isdigit)
                        {
                            engine.Efficiency = tokens[3];
                        }
                        else
                        {
                            engine.Displacement = int.Parse(tokens[2]);
                        }
                    }
                }
                engines.Add(engine);
            }
            return engines;
        }
    }
}
