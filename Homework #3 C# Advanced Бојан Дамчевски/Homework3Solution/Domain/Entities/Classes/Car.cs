using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Enums;

namespace Domain.Entities.Classes
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> CountriesOfProduction { get; set; }
        public Car(int id, VehicleType type, int productionYear, string batchNo, int fuelTank) : base(id, type, productionYear, batchNo)
        {
            FuelTank = fuelTank;
            CountriesOfProduction = new List<string>();
        }
        public override void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ID: {Id}\nType: {Type}\nYear of production: {YearOfProduction}");
            Console.WriteLine("The car is produced in the following countries:");
            if (CountriesOfProduction.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("In 0 countries !");
            }
            else
            {
                foreach (string country in CountriesOfProduction)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(country);
                }
            }
        }
    }
}
