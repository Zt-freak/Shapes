using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Square : Rectangle
    {
        private double width;
        public override double Width
        {
            get
            {
                return width;
            }
            set
            {
                SyncDimensions(value);
            }
        }

        private double height;
        public override double Height
        {
            get
            {
                return height;
            }
            set
            {
                SyncDimensions(value);
            }
        }

        private void SyncDimensions(double value)
        {
            width = value;
            height = value;
        }
    }
}
