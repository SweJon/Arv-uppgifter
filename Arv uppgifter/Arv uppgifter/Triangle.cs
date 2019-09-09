using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_uppgifter
{
    class Triangle : Shape
    {

        public Triangle(double width1, double height1) : base(width1, height1)
        { }
        protected double Area()
        {
            double Area = width * height / 2;
        }
        protected double Circumferance()
            {
                 double Circumferance = width + 
            }
    }
}
