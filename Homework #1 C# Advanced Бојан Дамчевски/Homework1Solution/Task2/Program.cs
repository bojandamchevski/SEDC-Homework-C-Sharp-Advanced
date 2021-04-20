using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void IsItAWorkingDayOrNot(DateTime date)
        {
            DateTime firstDate = new DateTime(1999, 1, 1);
            DateTime today = DateTime.Today;
            if (date <= today && date >= firstDate)
            {
                if (date.DayOfWeek.ToString() == "Saturday" || date.DayOfWeek.ToString() == "Sunday")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("It's a weekend day, no work today !");
                }
                else if ((date.Month.ToString() == "1" && date.Day.ToString() == "1") || (date.Month.ToString() == "1" && date.Day.ToString() == "7") || (date.Month.ToString() == "4" && date.Day.ToString() == "20") || (date.Month.ToString() == "5" && date.Day.ToString() == "1") || (date.Month.ToString() == "5" && date.Day.ToString() == "25") || (date.Month.ToString() == "8" && date.Day.ToString() == "3") || (date.Month.ToString() == "10" && date.Day.ToString() == "12") || (date.Month.ToString() == "10" && date.Day.ToString() == "23") || (date.Month.ToString() == "12" && date.Day.ToString() == "8"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("NOT A WORKING DAY");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("It's a working day!");
                }
            }
            else
            {
                throw new Exception("Invalid date !");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The date creating app !");

            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter a date you want to check if it's a working day or not.");
                    Console.WriteLine("Must be in (Day-Month-Year) format !");
                    bool success = DateTime.TryParse(Console.ReadLine(), out DateTime convertedDate);
                    if (!success)
                    {
                        throw new Exception("Invalid date !");
                    }
                    else
                    {
                        IsItAWorkingDayOrNot(convertedDate);
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error");
                    Console.WriteLine(e.Message);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("If you want to exit type (Exit) or press enter to try again !");
                string exit = Console.ReadLine();
                if (exit.ToLower() == "exit")
                {
                    flag = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Thank you for using out app :)");
                }
                else
                {
                    flag = true;
                }
            }
            Console.ReadLine();
        }
    }
}
