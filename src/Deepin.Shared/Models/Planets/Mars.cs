using Deepin.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deepin.Shared.Models.Planets
{
    class Mars : IPlanet<string>
    {
        public int DistanceFromTheSun => 227_940_000;

        public string AdditionalInfo => "Mars attacks! Nice movie.";
    }
}
