using Deepin.Shared.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Variances.Invariance
{
    class InvarianceExample
    {
        public void ValidInvariance()
        {
            List<Keyboard> keyboards = new List<Keyboard>
            {
                new Keyboard(),
                new Keyboard(),
                new Keyboard()
            };

            //List<Device> devices = keyboards;
        }
    }
}
