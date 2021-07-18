using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Collections.Interfaces.IEnumerableExample
{
    class CustomEnumerable<T> : IEnumerable
    {
        private T[] elements;

        public CustomEnumerable()
        {
            elements = new T[1];
        }

        public CustomEnumerable(T[] elements)
        {
            this.elements = elements;
        }

        public void Add(T element)
        {
            if (elements[0] is null)
            {
                elements[0] = element;
            }
            else
            {
                elements = elements.Concat(new T[] { element }).ToArray();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomEnumerator<T>(elements);
        }
    }
}
