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
    public static class CatStore
    {
        public static List<Cat> Cats { get; set; }
        static CatStore()
        {
            Cat cat1 = new Cat("Tom", AnimalType.Cat, 4, true, 4);
            Cat cat2 = new Cat("Lucy", AnimalType.Cat, 2, false, 4);

            Cats = new List<Cat>()
            {
                cat1,
                cat2
            };
        }
    }
}
