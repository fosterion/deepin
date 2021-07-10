using Deepin.Collections.Interfaces.IEnumerableExample;
using Deepin.Collections.Iterators.YieldExample;
using Deepin.Shared.Models;
using System;
using System.Threading;

namespace Deepin.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateZoo();
            InsertDelimeter();
            CreateGarage();
            InsertDelimeter();
            CreateFridge();
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

        private static void CreateGarage()
        {
            var garage = new CustomEnumerable<Car>
            {
                new Car("Audi", 240),
                new Car("BMW", 280)
            };

            foreach (Car car in garage)
            {
                car.ShowInfo();
            }
        }

        private static void CreateFridge()
        {
            var products = new Product[3]
            {
                new Product("Beer", 120),
                new Product("Parrot", 25),
                new Product("Ketchup", 80)
            };

            var fridge = new CustomYield<Product>(products);

            foreach (Product product in fridge)
            {
                product.ShowInfo();
            }
        }

        private static void InsertDelimeter()
        {
            Console.WriteLine("==========");
        }
    }
}
