using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class Rectangle : Quadrilateral
        {
            public Rectangle(string color, float side1Length, float side2Length) : base(side1Length, side2Length, side1Length, side2Length, color)
            {

            }
            public virtual float GetArea()
            {
                float RectangleArea = Side1Length * Side2Length;
                
                return RectangleArea;
            }
        }
}
