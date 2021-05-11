﻿using System;

namespace TimeTrackingApp.Domain.Models
{
    public class Exercising
    {
        public string Title { get; set; }
        public ActivityType Type { get; set; }

        public Exercising()
        {
            Title = "Exercising Activity";
            Type = ActivityType.Exercising;
        }
        public void ExercisingActivity()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose exercise:\n");
                Console.WriteLine("1.) General)");
                Console.WriteLine("2.) Running");
                Console.WriteLine("3.) Sport");
                bool choiceValidation = int.TryParse(Console.ReadLine(), out int choice);
                if (choiceValidation)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("General...");
                        flag = false;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Running...");
                        flag = false;
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Sport...");
                        flag = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error. Try again.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bad input. Try again.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
    }
}
