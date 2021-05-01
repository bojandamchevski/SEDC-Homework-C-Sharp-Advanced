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
    public static class FishStore
    {
        public static List<Fish> Fish { get; set; }
        static FishStore()
        {
            Fish fish1 = new Fish("Bobby", AnimalType.Fish, 1, "Red", "Medium");
            Fish fish2 = new Fish("Jenny", AnimalType.Fish, 4, "Blue", "Big");

            Fish = new List<Fish>()
            {
                fish1,
                fish2
            };
        }
    }
}
