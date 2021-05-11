using System;

namespace TimeTrackingApp.Domain.Models
{
    public class OtherHobbies
    {
        public string Title { get; set; }
        public ActivityType Type { get; set; }

        public OtherHobbies()
        {
            Title = "Other hobbies";
            Type = ActivityType.OtherHobbies;
        }
        public void OtherHobiesActivity()
        {
            Console.WriteLine("Doing some other hobbies...");
        }
    }
}
