using System;
using System.Collections.Generic;
using System.Text;

namespace Deepin.Shared.Models
{
    class Product : Element
    {
        public int ShelfLife { get; set; }

        public Product(string name, int shelfLife)
        {
            Name = name;
            ShelfLife = shelfLife;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Product: {Name}; Shelf life: {ShelfLife}");
        }
    }
}
