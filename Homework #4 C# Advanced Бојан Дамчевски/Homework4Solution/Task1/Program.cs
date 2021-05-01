using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Task1Domain.Entities;
using Task1Domain;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle() { Id = 1, SideA = 10, SideB = 15};
            Rectangle rectangle2 = new Rectangle() { Id = 2, SideA = 12.5, SideB = 18.2};
            Rectangle rectangle3 = new Rectangle() { Id = 3, SideA = 15.1, SideB = 16.9};
            Circle circle1 = new Circle() { Id = 4, Radius = 13};
            Circle circle2 = new Circle() { Id = 5, Radius = 5.6};
            Circle circle3 = new Circle() { Id = 6, Radius = 15.3};

            GenericShapesDb<Rectangle>.InsertShapes(rectangle1);
            GenericShapesDb<Rectangle>.InsertShapes(rectangle2);
            GenericShapesDb<Rectangle>.InsertShapes(rectangle3);
            GenericShapesDb<Circle>.InsertShapes(circle1);
            GenericShapesDb<Circle>.InsertShapes(circle2);
            GenericShapesDb<Circle>.InsertShapes(circle3);

            GenericShapesDb<Rectangle>.Print();
            GenericShapesDb<Circle>.Print();

            Console.ReadLine();
        }
    }
}
