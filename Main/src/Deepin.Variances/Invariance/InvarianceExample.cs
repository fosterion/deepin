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
        /// <summary>
        /// Ситуация, когда наследование исходных типов не переносится на производные.
        /// Это означает, что можно использовать только изначально указанный тип.
        /// Таким образом, параметр инвариантного универсального типа не является ни ковариантным, ни контрвариантным.
        /// </summary>
        public void ValidInvariance()
        {
            var keyboards = new List<Keyboard>
            {
                new Keyboard(),
                new Keyboard(),
                new Keyboard()
            };

            //List<Device> devices = keyboards;
        }
    }
}
