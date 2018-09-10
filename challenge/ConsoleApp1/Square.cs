using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class Square : Quadrilateral
    {
        public Square(string color, float side1Length) : base(side1Length, side1Length, side1Length, side1Length, color)
        {

        }
        public float GetArea()
        {
            float SquareArea = Side1Length * Side1Length;
            
            return SquareArea;
        }
    }
}
