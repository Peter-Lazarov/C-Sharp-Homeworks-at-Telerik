using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Generic<T> where T : IEnumerable<T>
    {
        List<T> genery = new List<T>();

        public T[] arraygen;

        public Generic(int listLenght)
        {
            this.arraygen = new T[listLenght];
        }

        public void Add(T item)
        {
            this.genery.Add(item);
            Copy();
        }

        public T give(int index)
        {
            return this.genery.ElementAt(index);
        }
        
        public void Remove(int index)
        {
            this.genery.RemoveAt(index);
            Copy();
        }

        public void InsertAt(int index, T item)
        {
            this.genery.Insert(index, item);
            Copy();
        }

        public void Clear()
        {
            this.genery.Clear();
            Copy();
        }

        public void Find(Predicate<T> what)
        {
            this.genery.Find(what);
        }

        public override string ToString()
        {
            string all = "";
            foreach (var item in this.genery)
            {
                all = string.Format(item.ToString() + "\n");
            }
            return all;
        }

        private void Copy()
        {
            if (this.genery.Count() > this.arraygen.Count())
            {
                T[] arraygen2 = new T[this.arraygen.Count() * 2];
                this.genery.CopyTo(arraygen2);
            }
            else
            {
                this.genery.CopyTo(arraygen);
            }
        }

        public T Min() 
        {
            return this.genery.Min();
        }

        public T Max()
        {
            return this.genery.Max();
        }
    }
}
