using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethod
{
    public class Box<T>
    {
        private List<T> items;
        public List<T> Items => this.items;

        public Box()
        {
            this.items = new List<T>();
        }

        public void Add(T item)
        {
            this.items.Add(item);
        }
    }
}
