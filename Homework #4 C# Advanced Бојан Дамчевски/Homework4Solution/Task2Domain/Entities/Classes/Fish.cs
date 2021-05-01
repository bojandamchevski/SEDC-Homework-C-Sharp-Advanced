using System;
using System.Collections.Generic;
using System.Text;
using Task2Domain.Entities.Enums;

namespace Task2Domain.Entities.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public Fish(string name, AnimalType type, int age, string color, string size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }
        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"This is {Name} the {Type}, he/she is {Age} old and he/she is {Color} and {Size}.");
        }
    }
}
