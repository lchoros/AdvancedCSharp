using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BaseCaloriesPerGram = 2;
        private Dictionary<string, double> toppingTypes = new Dictionary<string, double>
        {
            ["meat"] = 1.2,
            ["veggies"] = 0.8,
            ["cheese"] = 1.1,
            ["sauce"] = 0.9
        };

        private string name;
        private double weight;

        public Topping(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value.ToLower()) || string.IsNullOrWhiteSpace(value.ToLower()) || !toppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.name = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Name} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double TotalCalories
        {
            get 
            {
                return this.CalculateCalories();
            }
        }

        private double CalculateCalories()
        {
            return BaseCaloriesPerGram * this.Weight * this.toppingTypes[this.Name.ToLower()];
        }
    }
}
