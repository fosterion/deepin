using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Collections.InterfacesImplementation.IEnumerableExample.Concrete
{
    class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Animal: {Name}; Age: {Age}");
        }
    }
}
