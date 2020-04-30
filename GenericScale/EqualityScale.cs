using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }
        public T Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public T Right
        {
            get { return this.right; }
            set { this.right = value; }
        }

        public string AreEqual()
        {
            bool result = this.left.Equals(this.right);
            return result.ToString();
        }
    }
}
