using System;
using System.Collections.Generic;
using System.Text;
using Task2Domain.Entities.Enums;

namespace Task2Domain.Entities.Classes
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public AnimalType Type { get; set; }
        public int Age { get; set; }
        public Pet(string name, AnimalType type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public abstract void PrintInfo();
    }
}
