using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using Domain.Entities.Classes;
using Domain.Entities.Enums;
using Domain.Entities;

namespace HomeworkApp
{
    class Program
    {
        public static void Print()
        {
            for (int i = 0; i < VehiclesDb.Vehicles.Count && i < VehiclesDb.Cars.Count && i < VehiclesDb.Bikes.Count; i++)
            {
                VehiclesDb.Vehicles[i].PrintVehicle();
                Validator.Validate(VehiclesDb.Vehicles[i]);
                Console.WriteLine("===========================================");
                VehiclesDb.Cars[i].PrintVehicle();
                Validator.Validate(VehiclesDb.Cars[i]);
                Console.WriteLine("===========================================");
                VehiclesDb.Bikes[i].PrintVehicle();
                Validator.Validate(VehiclesDb.Bikes[i]);
                Console.WriteLine("===========================================");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vehicles App");

            Print();

            Console.ReadLine();
        }
    }
}
