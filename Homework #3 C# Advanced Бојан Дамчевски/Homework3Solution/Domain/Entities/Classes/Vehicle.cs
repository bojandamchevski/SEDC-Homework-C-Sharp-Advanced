using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Enums;

namespace Domain.Entities.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleType Type { get; set; }
        public int YearOfProduction { get; set; }
        public string BatchNumber { get; set; }
        public Vehicle(int id, VehicleType type, int productionYear, string batchNo)
        {
            Id = id;
            Type = type;
            YearOfProduction = productionYear;
            BatchNumber = batchNo;
        }
        public virtual void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ID: {Id}\nType: {Type}\nYear of production: {YearOfProduction}");
        }
    }
}
