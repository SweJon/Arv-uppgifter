using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_uppgifter
{
    class Triangle : Shape
    {
        public Triangle(double width1, double height1) : base(width1, height1)
        { }

        public override double Area()
        {
            double Area1 = width * height / 2;
            return Area1;
        }
        public override double Circumference()
         {
            double Circumferance1 = height + width + Math.Sqrt(width * width + height * height);
            return Circumferance1;
         }
    }
}
