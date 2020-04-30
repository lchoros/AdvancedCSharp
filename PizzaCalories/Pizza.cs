using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;
        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            private get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public List<Topping> Toppings
        {
            get => this.toppings;
            private set
            {
                if (this.toppings.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.toppings = value;
            }
        }
        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        public Dough Dough
        {   set
            {
                this.dough = value;
            }
        }

        public double Calories()
        {
            double allCalories = 0;
            allCalories += this.dough.TotalCalories();
            this.toppings.ForEach(t => allCalories += t.TotalCalories);

            return allCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Calories():f2} Calories.";
        }
    }
}
