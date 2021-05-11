using System;
using System.Diagnostics;

namespace TimeTrackingApp.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double TimeReading { get; set; }
        public double TimeExercising { get; set; }
        public double TimeWorking { get; set; }
        public double TimeOtherHobbies { get; set; }
        public User(string firstName, string lastName, int age, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
            TimeReading = 0;
            TimeExercising = 0;
            TimeWorking = 0;
            TimeOtherHobbies = 0;
        }
        public override void GetInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login successful !\n");
            Console.WriteLine($"Welcome {FirstName} {LastName}\n");
        }
    }
}
