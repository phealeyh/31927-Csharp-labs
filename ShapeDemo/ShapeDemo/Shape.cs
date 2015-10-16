using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDemo
{
    public abstract class Shape
    {
        protected string color;
        public abstract double Area {get;}
        public abstract string ToString();
        public double area;

        public Shape(string color)
        {
            this.color = color;
        }


    }
}
