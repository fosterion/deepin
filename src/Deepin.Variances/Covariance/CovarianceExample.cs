using Deepin.Shared.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Variances.Covariance
{
    class CovarianceExample
    {
        public void ValidCovariance()
        {
            List<Keyboard> keyboards = new List<Keyboard>
            {
                new Keyboard(),
                new Keyboard(),
                new Keyboard()
            };

            IEnumerable<Device> devices = keyboards;
        }
    }
}
