using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Collections.Interfaces.IEnumerableExample
{
    class CustomEnumerator<T> : IEnumerator
    {
        private T[] elements;

        private int position = -1;

        public CustomEnumerator(T[] elements)
        {
            this.elements = elements;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= elements.Length)
                {
                    throw new IndexOutOfRangeException(); 
                }
                else
                {
                    return elements[position];
                }
            }
        }

        public bool MoveNext()
        {
            if (position < elements.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
