using System;
using System.Collections.Generic;
using System.Text;

namespace Deepin.Shared.Interfaces
{
    interface IPlanet
    {
        int DistanceFromTheSun { get; }
    }

    interface IPlanet<T> : IPlanet
    {
        T AdditionalInfo { get; }
    }
}
