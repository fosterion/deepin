using Deepin.Collections.InterfacesImplementation.IEnumerableExample;
using Deepin.Collections.InterfacesImplementation.IEnumerableExample.Concrete;
using System;
using System.Threading;

namespace Deepin.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateZoo();
        }

        private static void CreateZoo()
        {
            var animals = new Animal[3]
            {
                new Animal("Bear", 12),
                new Animal("Fox", 2),
                new Animal("Zebra", 7)
            };

            var zoo = new CustomEnumerable<Animal>(animals);

            foreach (Animal animal in zoo)
            {
                animal.ShowInfo();
            }
        }
    }
}
