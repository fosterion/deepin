using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Collections.InterfacesImplementation.IEnumerableExample
{
    class CustomEnumerable<T> : IEnumerable
    {
        private T[] elements;

        public CustomEnumerable(T[] elements)
        {
            this.elements = elements;
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomEnumerator<T>(elements);
        }
    }
}
