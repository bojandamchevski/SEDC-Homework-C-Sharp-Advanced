using System;
using System.Collections.Generic;
using System.Text;
using DomainLibrary.Enums;
using DomainLibrary.Interfaces;

namespace DomainLibrary.Classes
{
    public class Cat : Dog, ICat
    {
        //Namerno pravam da nasleduva od Dog, bidejki metodot SpecificInfo ke bide dupliciran ako go pisuvam pak
        //A pak na metodot Bark ke mu napravam override
        public Cat(string name, AnimalKind kind, int age, List<string> food, string color, bool hair, bool fur, bool teeth) : base(name, kind, age, food, color, hair, fur, teeth) { }
        public override void Bark()
        {
            Console.WriteLine("Meow meow");
        }
        public void Eat(string food)
        {
            try
            {
                if (!String.IsNullOrEmpty(food))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"The cat {Name} eats {food}");
                }
                else
                {
                    throw new Exception("Error!");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter some type food.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
