using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shapes.Helpers
{
    public static class ValueCalculator
    {
        internal static double GetHalfValue(double width)
        {
            return width / 2;
        }

        internal static double GetDoubleValue(double value)
        {
            return 2 * value;
        }
    }
}