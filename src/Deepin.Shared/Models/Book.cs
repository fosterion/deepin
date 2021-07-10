using System;
using System.Collections.Generic;
using System.Text;

namespace Deepin.Shared.Models
{
    class Book : Element
    {
        public string Author { get; set; }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Book: {Name}; Author: {Author}");
        }
    }
}
