using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Collections.Iterators.YieldExample
{
    class CustomYield<T>
    {
        private T[] elements;

        public CustomYield(T[] elements)
        {
            this.elements = elements;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                yield return elements[i];
            }
        }

        public IEnumerable GetElements(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == elements.Length)
                {
                    yield break;
                }
                else
                {
                    yield return elements[i];
                }
            }
        }
    }
}
