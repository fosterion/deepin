using System;
using System.Collections.Generic;
using System.Text;

namespace Deepin.Shared.Models.Devices
{
    class Device
    {
        public void PlugIn()
        {
            Console.WriteLine($"The {this.GetType().Name} was plugged in.");
        }
    }
}
