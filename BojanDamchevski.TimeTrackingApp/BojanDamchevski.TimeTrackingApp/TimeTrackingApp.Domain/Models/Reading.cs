﻿using System;

namespace TimeTrackingApp.Domain.Models
{
    public class Reading
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public ActivityType Type { get; set; }
        public Reading()
        {
            Title = "Reading Activity";
            Pages = 0;
            Type = ActivityType.Reading;
        }
        public void ReadingActivity()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose what to read:\n");
                Console.WriteLine("1.) Belles Lettres");
                Console.WriteLine("2.) Fiction");
                Console.WriteLine("3.) Professional Literature");
                bool choiceValidation = int.TryParse(Console.ReadLine(), out int choice);
                if (choiceValidation)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("Reading Belles Lettres");
                        Pages += 10;
                        flag = false;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Reading Fiction");
                        Pages += 12;
                        flag = false;
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Reading Professional Literature");
                        Pages += 15;
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
