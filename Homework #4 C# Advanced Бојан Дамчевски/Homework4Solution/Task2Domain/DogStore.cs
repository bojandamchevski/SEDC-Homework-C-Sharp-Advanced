using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Task2Domain.Entities.Classes;
using Task2Domain.Entities.Enums;

namespace Task2Domain
{
    public static class DogStore
    {
        public static List<Dog> Dogs { get; set; }
        static DogStore()
        {
            Dog dog1 = new Dog("Sparky", AnimalType.Dog, 3, "steak");
            Dog dog2 = new Dog("Tony", AnimalType.Dog, 1, "steak");

            Dogs = new List<Dog>()
            {
                dog1,
                dog2
            };
        }
    }
}
