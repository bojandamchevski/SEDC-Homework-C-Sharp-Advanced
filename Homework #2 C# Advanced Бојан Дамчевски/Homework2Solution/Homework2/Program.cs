using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DomainLibrary.Enums;
using DomainLibrary.Interfaces;
using DomainLibrary.Classes;

namespace Homework2
{
    class Program
    {
        static void GetMethodsCat(Cat cat)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=====================");
            Console.WriteLine("Enter some type of food:");
            string food = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            cat.Eat(food);
            cat.PrintAnimal();
            cat.SpecificInfo();
            cat.Bark();
            Console.WriteLine("=====================");
        }
        static void GetMethodsDog(Dog dog)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=====================");
            dog.PrintAnimal();
            dog.SpecificInfo();
            dog.Bark();
            Console.WriteLine("=====================");
        }
        static void IterateDogs(List<Animal> listOfDogs)
        {
            foreach (Animal dog in listOfDogs)
            {
                Dog puppy = (Dog)dog;
                puppy.Bark();
            }
        }
        static void IterateCats(List<Animal> listOfCats)
        {
            foreach (Animal cat in listOfCats)
            {
                Cat kitten = (Cat)cat;
                kitten.Eat("Some food");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dogs and Cats");

            Cat cat1 = new Cat("Lucy", AnimalKind.Cat, 4, new List<string> { "fish", "cat food" }, "white", false, true, true);
            Cat cat2 = new Cat("Jessie", AnimalKind.Cat, 3, new List<string> { "cat food" }, "black", false, true, true);
            Cat cat3 = new Cat("Tommy", AnimalKind.Cat, 5, new List<string> { "fish" }, "brown", false, true, true);
            Cat cat4 = new Cat("Walter", AnimalKind.Cat, 2, new List<string> { "fish", "cat food", "milk" }, "orange", false, true, true);

            Dog dog1 = new Dog("Jackie", AnimalKind.Dog, 3, new List<string> { "fish", "dogfood", "beef" }, "black", false, true, true);
            Dog dog2 = new Dog("Larissa", AnimalKind.Dog, 5, new List<string> { "fish", "dogfood", "beef", "pork", "milk" }, "brown", false, true, true);
            Dog dog3 = new Dog("Juli", AnimalKind.Dog, 1, new List<string> { "beef", "pork", "milk" }, "white", false, true, true);
            Dog dog4 = new Dog("Candid", AnimalKind.Dog, 2, new List<string> { "bread", "milk" }, "white", false, true, true);
            Dog dog5 = new Dog("George", AnimalKind.Dog, 2, new List<string> { "bread", "milk", "beef" }, "brown", false, true, true);

            GetMethodsCat(cat1);
            GetMethodsCat(cat2);
            GetMethodsCat(cat3);
            GetMethodsCat(cat4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press any button for the details about the Dogs");
            Console.ReadKey();
            GetMethodsDog(dog1);
            GetMethodsDog(dog2);
            GetMethodsDog(dog3);
            GetMethodsDog(dog4);
            GetMethodsDog(dog5);

            List<Animal> animalList = new List<Animal>()
            {
                cat1,
                cat2,
                cat3,
                cat4,
                dog1,
                dog2,
                dog3,
                dog4,
                dog5
            };

            List<Animal> dogList = animalList.Where(animal => animal.Kind == AnimalKind.Dog).ToList();
            List<Animal> catList = animalList.Where(animal => animal.Kind == AnimalKind.Cat).ToList();

            IterateDogs(dogList);
            IterateCats(catList);

            Console.ReadLine();
        }
    }
}
