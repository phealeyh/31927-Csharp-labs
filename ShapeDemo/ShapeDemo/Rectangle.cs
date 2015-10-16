using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ShapeDemo
{
    class Rectangle : Shape
    {
        private double height, width;
        //use the extended classes constructor (shape)
        public Rectangle(double height, double width, string color)
            : base(color)
        {
            this.height = height;
            this.width = width;
        }

        public override double Area
        {
           get { return height * width; }
        }
        public override string ToString()
        {
            StringWriter sw = new StringWriter();
            sw.Write("Rectangle of color {0},height {1:f2} and width {2:f2}"
                , color, height,width);
            return sw.ToString();
        }

    }
}
