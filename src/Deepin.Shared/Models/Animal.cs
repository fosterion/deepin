using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Shared.Models
{
    class Animal : Element
    {
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Animal: {Name}; Age: {Age}");
        }
    }
}
