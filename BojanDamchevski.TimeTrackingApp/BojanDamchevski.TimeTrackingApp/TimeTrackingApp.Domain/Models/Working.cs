using System;

namespace TimeTrackingApp.Domain.Models
{
    public class Working
    {
        public string Title { get; set; }
        public ActivityType Type { get; set; }

        public Working()
        {
            Title = "Working Activity";
            Type = ActivityType.Working;
        }

        public void WorkingActivity()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose working space:\n");
                Console.WriteLine("1.) Home");
                Console.WriteLine("2.) Office");
                bool choiceValidation = int.TryParse(Console.ReadLine(), out int choice);
                if (choiceValidation)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("Working from home...");
                        flag = false;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Working from the office...");
                        flag = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error. Try again.");
                        Console.WriteLine("Press any key to continue.");
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
