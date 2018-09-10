using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Quadrilateral : Shape
    {
        public float Side1Length { get; set; }
        public float Side2Length { get; set; }
        public float Side3Length { get; set; }
        public float Side4Length { get; set; }

        public Quadrilateral(float side1Length, float side2Length, float side3Length, float side4Length, string color) : base(color)
        {
            this.Side1Length = side1Length;
            this.Side2Length = side2Length;
            this.Side3Length = side3Length;
            this.Side4Length = side4Length;
            this.Color = color;
        }

        public virtual float GetPerimeter()
        {
            float Perimeter = Side1Length + Side2Length + Side3Length + Side4Length;
            return Perimeter;
        }
    }
}
