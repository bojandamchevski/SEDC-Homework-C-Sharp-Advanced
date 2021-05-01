using System;
using System.Collections.Generic;
using System.Text;
using Task2Domain.Entities.Enums;

namespace Task2Domain.Entities.Classes
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, AnimalType type, int age, bool lazy, int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }
        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"This is {Name} the {Type}, he/she is {Age} old and he/she has {LivesLeft} lives left.");
            if (Lazy == true)
            {
                Console.WriteLine("And he/she is lazy.");
            }
            else
            {
                Console.WriteLine("And he/she is not lazy.");
            }
        }
    }
}
