using Shapes.Helpers;
using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Routing.Constraints;

namespace Shapes.Strategies
{
    public class DensityCalculatorStrategy : IDensityCalculatorStrategy
    {
        public double CalcDensity(double mass, double height, double length, double width)
        {
            var volume = VolumeCalculator.CalcVolume(height, length, width);
            var density = mass / volume;
            return Math.Round(density, 2);
        }
    }
}