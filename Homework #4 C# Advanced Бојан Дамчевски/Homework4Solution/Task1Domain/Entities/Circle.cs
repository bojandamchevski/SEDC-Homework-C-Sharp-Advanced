using System;
using System.Collections.Generic;
using System.Text;

namespace Task1Domain.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle()
        {

        }
        public override double GetArea()
        {
            return 3.14 * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
}
