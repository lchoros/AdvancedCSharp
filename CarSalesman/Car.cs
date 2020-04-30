using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double? Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = null;
            Color = "n/a";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Model}:");
            sb.Append(Engine.ToString());
            sb.AppendLine(Weight == null ? "  Weight: n/a" : $"  Weight: {Weight}");
            sb.AppendLine($"  Color: {Color}");
            return sb.ToString();
        }
    }
}
