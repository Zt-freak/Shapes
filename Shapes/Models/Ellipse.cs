using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    class Ellipse : Shape
    {
        private double area;
        public override double Area
        {
            get
            {
                area = Math.PI * Width / 2 * Height / 2;
                return area;
            }
        }
    }
}
