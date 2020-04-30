using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tyre
    {
        private double pressure;
        private int age;

        public Tyre(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
        
        public int Age
        {
            get { return this.age;  }
            set { this.age = value; }
        }
    }
}
