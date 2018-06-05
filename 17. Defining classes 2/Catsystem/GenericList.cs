using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catsystem
{
    //public class GenericList<T> where T : int //kogato iskame T-to da e opredelen tip
    public class GenericList<T>
    {
        //private int[] elements;
        private T[] elements;
        private int index;

        public GenericList()
        {
            //this.elements = new int[16];
            this.elements = new T[16];
            index = 0;
        }
        //public void Add(int element)
        public void Add(T element)
        {
            this.elements[this.index] = element;
            this.index++;
        }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.elements.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                this.elements[index] = value;
            }
        }
    }
}
