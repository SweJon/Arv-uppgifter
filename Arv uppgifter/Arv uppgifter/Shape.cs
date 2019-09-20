using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_uppgifter
{
    abstract class Shape
    {
        protected double width;
        protected double height;
        
        protected Shape(double width1, double height1)
        {
            width = width1;
            height = height1;
        }

        public abstract double Area();

        public abstract double Circumference();
    }
}
