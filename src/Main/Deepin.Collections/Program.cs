using Deepin.Collections.Concrete;
using Deepin.Shared.Helpers;
using System.Collections.Generic;

namespace Deepin.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var containers = new List<Container>
            {
                new Fridge(),
                new Garage(),
                new Library(),
                new Zoo()
            };

            foreach (var item in containers)
            {
                item.Create();
                Methods.InsertDelimeter();
            }
        }
    }
}
