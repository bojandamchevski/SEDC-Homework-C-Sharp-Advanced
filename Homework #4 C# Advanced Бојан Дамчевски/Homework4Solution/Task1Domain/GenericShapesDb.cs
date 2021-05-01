using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Task1Domain.Entities;

namespace Task1Domain
{
    public static class GenericShapesDb<T> where T : Shape
    {
        public static List<T> Shapes { get; set; }
        static GenericShapesDb()
        {
            Shapes = new List<T>();
        }

        public static void InsertShapes(T shape)
        {
            T existingShape = Shapes.FirstOrDefault(x => x.Id == shape.Id);
            if (existingShape == null)
            {
                Shapes.Add(shape);
            }
            else
            {
                Console.WriteLine("That shape already exists in the list");
            }
        }

        public static void Print()
        {
            foreach (T shape in Shapes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The area is {shape.GetArea()}");
                Console.WriteLine($"The perimeter is {shape.GetPerimeter()}");
                Console.WriteLine("===========================================");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Shapes.PrintInfo();
        }
    }
}
