using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Domain.Entities.Classes;
using Domain.Entities.Enums;

namespace Domain.Entities
{
    public static class VehiclesDb
    {
        public static List<Vehicle> Vehicles { get; set; }
        public static List<Car> Cars { get; set; }
        public static List<Bike> Bikes { get; set; }
        static VehiclesDb()
        {

            Vehicle vehicle1 = new Vehicle(1, VehicleType.Car, 1999, "kj232");
            Vehicle vehicle2 = new Vehicle(2, VehicleType.Bike, 1998, "ls562");
            Vehicle vehicle3 = new Vehicle(3, VehicleType.Bike, 1995, "kg232");

            Vehicles = new List<Vehicle>()
            {
                vehicle1,
                vehicle2,
                vehicle3
            };

            Car car1 = new Car(11, VehicleType.Car, 2018, "gi678", 100);
            Car car2 = new Car(22, VehicleType.Car, 2012, "sd413", 70);
            Car car3 = new Car(33, VehicleType.Car, 2015, "da547", 90);
            car2.CountriesOfProduction.Add("Germany");
            car2.CountriesOfProduction.Add("France");
            Cars = new List<Car>()
            {
                car1,
                car2,
                car3
            };

            Bike bike1 = new Bike(111, VehicleType.Bike, 2009, "nb738", "black");
            Bike bike2 = new Bike(222, VehicleType.Bike, 2005, "lp989", "white");
            Bike bike3 = new Bike(333, VehicleType.Bike, 2014, "ls638", "red");

            Bikes = new List<Bike>()
            {
                bike1,
                bike2,
                bike3
            };
        }
    }
}
