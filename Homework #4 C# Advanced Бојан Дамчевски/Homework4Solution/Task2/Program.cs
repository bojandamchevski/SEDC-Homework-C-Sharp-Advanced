using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Task2Domain.Entities.Classes;
using Task2Domain.Entities.Enums;
using Task2Domain;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Sparky", AnimalType.Dog, 3, "steak");
            Dog dog2 = new Dog("Lily", AnimalType.Dog, 2, "steak");
            Cat cat1 = new Cat("Tom", AnimalType.Cat, 4, true, 4);
            Cat cat2 = new Cat("Lucy", AnimalType.Cat, 2, false, 4);
            Fish fish1 = new Fish("Bobby", AnimalType.Fish, 1, "Red", "Medium");
            Fish fish2 = new Fish("Jenny", AnimalType.Fish, 4, "Blue", "Big");

            GenericDb<Dog>.AddPetToList(dog1);
            GenericDb<Dog>.AddPetToList(dog2);
            GenericDb<Cat>.AddPetToList(cat1);
            GenericDb<Cat>.AddPetToList(cat2);
            GenericDb<Fish>.AddPetToList(fish1);
            GenericDb<Fish>.AddPetToList(fish2);

            GenericDb<Dog>.PrintPets(GenericDb<Dog>.Pets);
            GenericDb<Cat>.PrintPets(GenericDb<Cat>.Pets);
            GenericDb<Fish>.PrintPets(GenericDb<Fish>.Pets);

            GenericDb<Cat>.BuyPet(GenericDb<Cat>.Pets,"Sparky");
            GenericDb<Cat>.BuyPet(GenericDb<Cat>.Pets, "Tom");

            Console.WriteLine("=================================================");

            GenericDb<Cat>.BuyPet(CatStore.Cats, "Tom");
            GenericDb<Cat>.BuyPet(CatStore.Cats, "Tommy");
            GenericDb<Dog>.BuyPet(DogStore.Dogs, "Tony");
            GenericDb<Dog>.BuyPet(DogStore.Dogs, "Jill");

            GenericDb<Dog>.PrintPets(DogStore.Dogs);
            GenericDb<Cat>.PrintPets(CatStore.Cats);
            GenericDb<Fish>.PrintPets(FishStore.Fish);

            Console.ReadLine();
        }
    }
}
