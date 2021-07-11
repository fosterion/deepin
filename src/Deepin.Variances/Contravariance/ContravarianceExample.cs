using Deepin.Shared.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepin.Variances.Contravariance
{
    class ContravarianceExample
    {
        private void ValidContravariance()
        {
            Action<Device> actionWithDevice = device => device.PlugIn();
            Action<Keyboard> actionWithKeyboard = actionWithDevice;
        }

        private void InvalidContravariance()
        {
            Action<Mouse> actionWithMouse = mouse => mouse.PlugIn();
            //Action<Device> anotherActionWithDevice = actionWithMouse;
        }
    }
}
