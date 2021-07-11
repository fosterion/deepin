using Deepin.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deepin.Shared.Models.Planets
{
    class Earth : IPlanet
    {
        public int DistanceFromTheSun => 149_600_000;
    }
}
