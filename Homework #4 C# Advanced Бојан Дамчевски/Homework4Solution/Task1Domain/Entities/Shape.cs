using System;
using System.Collections.Generic;
using System.Text;

namespace Task1Domain.Entities
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public Shape()
        {

        }
        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
