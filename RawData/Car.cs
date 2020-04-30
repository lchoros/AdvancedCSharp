using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tyre[] tires;


        public Car(string model, Engine engine, Cargo cargo)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }
        
        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public Tyre[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }
    }
}
