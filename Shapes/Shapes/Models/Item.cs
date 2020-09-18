using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Shapes.Interfaces;
using Shapes.Strategies;

namespace Shapes.Models
{
    public class Item
    {
        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("Height")]
        public double height { get; set; }

        [DisplayName("Length")]
        public double length { get; set; }

        [DisplayName("Width")]
        public double width { get; set; }

        [DisplayName("Mass")]
        public double mass { get; set; }

        IFindShapeStrategy fS = new FindShapeStrategy();
        IDensityCalculatorStrategy dC = new DensityCalculatorStrategy();

        [DisplayName("Shape")]
        public string shape => fS.FindShape(height, length, width);

        [DisplayName("Density")]
        public double density => dC.CalcDensity(mass, height, length, width);
    }
}