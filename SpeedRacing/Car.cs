using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumptionPerKm;
        private decimal distanceTravelled;

        public Car(string model, decimal fuelAmount, decimal fuelConsumptionPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
            this.distanceTravelled = 0;
        }
        public override string ToString()
        {
            return $"{this.Model} {this.fuelAmount:f2} {(int)this.distanceTravelled}";
        }

        public string Model
        {
            get { return this.model; }
        }

        public decimal FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public decimal FuelConsumptionPerKm
        {
            get { return this.fuelConsumptionPerKm; }
        }

        public decimal DistanceTravelled
        {
            get { return this.distanceTravelled; }
            set { this.distanceTravelled = value; }
        }

        public void Drive(decimal kilometers)
        {
            var neededFuel = kilometers * this.fuelConsumptionPerKm;

            if (this.fuelAmount < neededFuel)
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            this.fuelAmount -= neededFuel;
            this.distanceTravelled += kilometers;
        }
    }
}
