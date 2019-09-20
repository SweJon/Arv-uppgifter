using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_uppgifter
{
    class Rectangle : Shape
    {
        public Rectangle(double width1, double height1) : base(width1, height1)
        { }

        public override double Area()
        {
            double Area2 = width * height;
            return Area2;
        }
        public override  double Circumference()
        {
            double Circumferance2 = width * 2 + height * 2;
            return Circumferance2;
        }
    }
}
