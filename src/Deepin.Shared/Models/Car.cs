using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Shared.Models
{
    class Car : Element
    {
        public int MaxSpeed { get; set; }

        public Car(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Car: {Name}; Max Speed: {MaxSpeed}");
        }
    }
}
