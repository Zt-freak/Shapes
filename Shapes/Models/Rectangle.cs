using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        private double area;
        public override double Area
        {
            get {
                area = Width * Height;
                return area;
            }
        }
    }
}
