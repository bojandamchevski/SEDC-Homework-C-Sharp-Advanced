using BonusTask.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace BonusTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", "Smith", 43);
            Person person2 = new Person("Julliana", "Craine", 29);
            Person person3 = new Person("Joe", "Blake", 32);

            List<Person> people = new List<Person>()
            {
                person1,
                person2,
                person3
            };

            string folderPath = @"..\..\..\People";
            string filePath = folderPath + @"\people.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                string allPeople = "";
                for (int i = 0; i < people.Count; i++)
                {
                    if (i == people.Count - 1)
                    {
                        allPeople += $"{people[i].FirstName} {people[i].LastName} {people[i].Age}";
                    }
                    else
                    {
                        allPeople += $"{people[i].FirstName} {people[i].LastName} {people[i].Age}\n";
                    }
                }
                streamWriter.WriteLine(allPeople);
            }

            List<Person> newPeople = new List<Person>();

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                for (int i = 0; i < people.Count; i++)
                {
                    string person = streamReader.ReadLine();
                    string[] info = person.Split(" ");
                    Person newPerson = new Person(info[0], info[1], Convert.ToInt32(info[2]));
                    newPeople.Add(newPerson);
                }
            }

            foreach (Person person in newPeople)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
            }

            Console.ReadLine();
        }
    }
}
