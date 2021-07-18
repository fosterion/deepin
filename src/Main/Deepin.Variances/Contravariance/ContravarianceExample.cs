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
        /// <summary>
        /// Перенос наследования исходных типов на производные от них типы в обратном порядке.
        /// Позволяет использовать более универсальный тип (с меньшей глубиной наследования), чем заданный изначально.
        /// </summary>
        public void ValidContravariance()
        {
            Action<Device> actionWithDevice = device => device.PlugIn();
            Action<Keyboard> actionWithKeyboard = actionWithDevice;

            actionWithDevice.Invoke(new Device());
            actionWithKeyboard.Invoke(new Keyboard());
        }

        public void InvalidContravariance()
        {
            Action<Mouse> actionWithMouse = mouse => mouse.PlugIn();
            //Action<Device> anotherActionWithDevice = actionWithMouse;
        }
    }
}
