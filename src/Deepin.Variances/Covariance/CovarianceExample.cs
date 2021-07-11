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
        /// <summary>
        /// Перенос наследования исходных типов на производные от них типы в прямом порядке.
        /// Позволяет использовать тип с большей глубиной наследования, чем задано изначально.
        /// </summary>
        public void ValidCovariance()
        {
            var keyboards = new List<Keyboard>
            {
                new Keyboard(),
                new Keyboard(),
                new Keyboard()
            };

            IEnumerable<Device> devices = keyboards;

            foreach (var device in devices)
            {
                device.PlugIn();
            }
        }
    }
}
