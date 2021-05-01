using System;
using System.Collections.Generic;
using System.Text;
using Task2Domain.Entities.Enums;

namespace Task2Domain.Entities.Classes
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }
        public Dog(string name, AnimalType type, int age, string favouriteFood) : base(name, type, age)
        {
            FavouriteFood = favouriteFood;
        }
        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"This is {Name} the {Type}, he/she is {Age} old and his/her favourite food is {FavouriteFood}.");
        }
    }
}
