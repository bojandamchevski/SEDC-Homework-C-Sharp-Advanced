using System;
using Task1.App.Domain;
using Task1.App.Entities;

namespace Task1.App
{
    class Program
    {
        public static Database _database = new Database();
        public static void ColorTextGenerator(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
        public static void Seed()
        {
            Console.WriteLine("Insert properties for the dog:");
            Console.WriteLine("Insert name:");
            string name = Console.ReadLine();
            Console.WriteLine("Insert color:");
            string color = Console.ReadLine();
            Console.WriteLine("Insert age:");
            bool ageValidation = int.TryParse(Console.ReadLine(), out int age);
            if (ageValidation)
            {
                Dog dog = new Dog(name, age, color);
                _database.Insert(dog);
            }
        }
        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                ColorTextGenerator("Hello welcome to the menu\nChoose one of the following options:", ConsoleColor.Yellow);
                ColorTextGenerator("1.) Insert a dog", ConsoleColor.Yellow);
                ColorTextGenerator("2.) List of all dogs", ConsoleColor.Yellow);
                bool choiceValidation = int.TryParse(Console.ReadLine(), out int choice);
                if (choiceValidation)
                {
                    if (choice == 1)
                    {
                        Console.Clear();
                        Seed();
                        ColorTextGenerator("Press any key to continue.", ConsoleColor.Green);
                        break;
                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        _database.GetAll();
                        ColorTextGenerator("Press any key to continue.", ConsoleColor.Green);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        ColorTextGenerator("Try again, invalid input. Press any key to continue.", ConsoleColor.Red);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    ColorTextGenerator("Try again, invalid input. Press any key to continue.", ConsoleColor.Red);
                    Console.ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Console.ReadKey();
            }
            Console.ReadLine();
        }
    }
}
