using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Collections.InterfacesImplementation.IEnumerableExample.Concrete
{
    abstract class Element
    {
        public string Name { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
