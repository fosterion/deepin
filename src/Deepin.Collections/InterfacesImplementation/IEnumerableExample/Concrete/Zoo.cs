using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Collections.InterfacesImplementation.IEnumerableExample.Concrete
{
    class Zoo<T> : IEnumerable
    {
        private T[] animals;

        public Zoo(T[] animals)
        {
            this.animals = animals;
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomEnumerator<T>(animals);
        }
    }
}
