using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    abstract class Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual double Area { get; }
        public double Xcoord { get; set; }
        public double Ycoord { get; set; }
    }
}
