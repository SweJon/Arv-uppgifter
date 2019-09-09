using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_uppgifter
{
    class Rectangle : Shape 
    {
        public Rectangle(double width1, double height1) : base(width1, height1)
        { }

        protected double Area()
        {
            double Area1 = width * height;
        }
        protected double Circumferance()
            {
               double Circumferance2 = width * 2 + height * 2;

            }
}
}
