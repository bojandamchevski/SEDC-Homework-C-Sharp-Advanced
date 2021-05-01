using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Task2Domain.Entities.Classes;
using Task2Domain.Entities.Enums;

namespace Task2Domain
{
    public static class GenericDb<T> where T : Pet
    {
        public static List<T> Pets { get; set; }
        static GenericDb()
        {
            Pets = new List<T>();
        }
        public static void AddPetToList(T pet)
        {
            T existingPet = Pets.FirstOrDefault(x => x.Name == pet.Name && x.Type == pet.Type && x.Age == pet.Age);
            if (existingPet == null)
            {
                Pets.Add(pet);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A pet with the same info already exists.");
            }
        }
        public static void PrintPets(List<T> pets)
        {
            foreach(T pet in pets)
            {
                pet.PrintInfo();
            }
        }

        public static void BuyPet(List<T> pets,string name)
        {
            T existingPet = pets.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if (existingPet != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                pets.Remove(existingPet);
                Console.WriteLine("Pet adopted");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no pet with that name.");
            }
        }
    }
}
