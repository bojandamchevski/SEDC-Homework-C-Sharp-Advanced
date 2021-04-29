using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Enums;

namespace Domain.Entities.Classes
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        public Bike(int id, VehicleType type, int productionYear, string batchNo, string color) : base(id, type, productionYear, batchNo)
        {
            Color = color;
        }
        public override void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Year of production: {YearOfProduction}\nColor: {Color}");
        }
    }
}
