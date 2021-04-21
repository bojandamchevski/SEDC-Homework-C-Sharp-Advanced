using System;
using System.Collections.Generic;
using System.Text;
using DomainLibrary.Enums;
using DomainLibrary.Interfaces;

namespace DomainLibrary.Classes
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, AnimalKind kind, int age, List<string> food, string color, bool hair, bool fur, bool teeth) : base(name, kind, age, food, color, hair, fur, teeth) { }

        public override void SpecificInfo()
        {
            Console.WriteLine("");
            if (SpecializedTeeth)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The {Kind} {Name} has got special teeth.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The {Kind} {Name} has not got special teeth.");
            }
            if (PresenceOfHair)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The {Kind} {Name} has got hair.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The {Kind} {Name} has not got hair.");
            }
            if (PresenceOfFur)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The {Kind} {Name} has got fur.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The {Kind} {Name} has not got fur.");
            }
        }
        public virtual void Bark()
        {
            Console.WriteLine("Woof Woof !");
        }
    }
}
