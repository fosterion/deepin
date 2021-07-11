using Deepin.Collections.Interfaces.IEnumerableExample;
using Deepin.Collections.Iterators.YieldExample;
using Deepin.Shared.Interfaces;
using Deepin.Shared.Models;
using Deepin.Shared.Models.Devices;
using Deepin.Shared.Models.Elements;
using Deepin.Shared.Models.Planets;
using System;
using System.Collections.Generic;
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
            InsertDelimeter();

            CreateLibrary();
            InsertDelimeter();
        }

        private static void CreateZoo()
        {
            var animals = new Animal[]
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
            var products = new Product[]
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

        private static void CreateLibrary()
        {
            var books = new Book[]
            {
                new Book("Moby Dick", "Herman Melville"),
                new Book("Hamlet", "William Shakespeare"),
                new Book("The Odyssey", "Homer"),
                new Book("The Divine Comedy", "Dante Alighieri"),
                new Book("The Adventures of Huckleberry Finn", "Mark Twain"),
                new Book("Crime and Punishment", "Fyodor Dostoyevsky")
            };

            var library = new CustomYield<Book>(books);

            foreach (Book book in library.GetElements(3))
            {
                book.ShowInfo();
            }
        }

        private static void InsertDelimeter()
        {
            Console.WriteLine("==========\n");
        }
    }
}
