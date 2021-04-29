using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Domain.Entities.Classes;
using Domain.Entities.Enums;

namespace Domain.Entities
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id > 0 && vehicle.Type != 0 && vehicle.YearOfProduction > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The validation was successfull");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The validation was not successfull");
            }
        }
    }
}
