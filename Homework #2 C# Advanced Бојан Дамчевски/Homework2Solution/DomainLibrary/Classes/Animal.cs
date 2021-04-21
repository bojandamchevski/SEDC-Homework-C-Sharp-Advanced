using System;
using System.Collections.Generic;
using System.Text;
using DomainLibrary.Enums;
using DomainLibrary.Interfaces;

namespace DomainLibrary.Classes
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public AnimalKind Kind { get; set; }
        public int Age { get; set; }
        public List<string> Food { get; set; }
        public string Color { get; set; }
        public bool PresenceOfHair { get; set; }
        public bool PresenceOfFur { get; set; }
        public bool SpecializedTeeth { get; set; }
        public Animal(string name, AnimalKind kind, int age, List<string> food, string color, bool hair, bool fur, bool teeth)
        {
            Name = name;
            Kind = kind;
            Age = age;
            Food = food;
            Color = color;
            PresenceOfHair = hair;
            PresenceOfFur = fur;
            SpecializedTeeth = teeth;
        }
        public abstract void SpecificInfo();
        public void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"The animal name is {Name} and it is a {Kind}, it's {Age} years old and it's {Color}. The animal eats: ");
            foreach (string food in Food)
            {
                Console.Write($" {food}");
            }
        }
    }
}
