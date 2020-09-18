using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shapes.Helpers
{
    public static class VolumeCalculator
    { 
        public static double CalcVolume(double height, double length, double width)
        {
            return height * length * width;
        }
    }
}