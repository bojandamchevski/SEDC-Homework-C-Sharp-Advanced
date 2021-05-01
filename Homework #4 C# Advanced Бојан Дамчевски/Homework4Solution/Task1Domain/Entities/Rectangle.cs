using System;
using System.Collections.Generic;
using System.Text;

namespace Task1Domain.Entities
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public Rectangle()
        {

        }
        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return SideA * 2 + SideB * 2;
        }
    }
}
