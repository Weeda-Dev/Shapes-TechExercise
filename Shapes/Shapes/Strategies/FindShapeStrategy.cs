using Shapes.Helpers;
using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shapes.Strategies
{
    public class FindShapeStrategy : IFindShapeStrategy
    {
        public string FindShape(double height, double length, double width)
        {
            var double_width = ValueCalculator.GetDoubleValue(width);
            var double_length = ValueCalculator.GetDoubleValue(length);
            var double_height = ValueCalculator.GetDoubleValue(height);

            var half_width = ValueCalculator.GetHalfValue(width);
            var half_length = ValueCalculator.GetHalfValue(length);
            var half_height = ValueCalculator.GetHalfValue(height);


            if (height > double_width && height > double_length)
            {
                return "Tall";
            }
            else if ((width > double_length && width > double_height) || (length > double_width && length > double_height))
            {
                return "Long";
            }
            else if (height < half_width && height < half_length)
            {
                return "Flat";
            }
            else if ((width < half_length && width < half_height) || (length < half_height && length < half_width))
            {
                return "Thin";
            }
            else
            {
                return "Other";
            }
        }
    }
}