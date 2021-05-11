using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Services.Interfaces;
using TimeTrackingApp.Domain.Database;
using System;
using TimeTrackingApp.Services.Helpers;
using System.Diagnostics;

namespace TimeTrackingApp.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        public Reading readingActivity;
        public Exercising exercisingActivity;
        public Working workingActivity;
        public OtherHobbies otherHobbiesActivity;
        private IDatabase<T> _database;
        public UserService()
        {
            _database = new Database<T>();
            readingActivity = new Reading();
            exercisingActivity = new Exercising();
            workingActivity = new Working();
            otherHobbiesActivity = new OtherHobbies();
        }

        public void AddUser(T user)
        {
            _database.InsertUser(user);
        }

        public T ChangeFristAndLastName(T user)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter new first name:");
                string newFirstName = Console.ReadLine();
                Console.WriteLine("Enter new last name:");
                string newLastName = Console.ReadLine();
                user.FirstName = newFirstName;
                user.LastName = newLastName;
                if (ValidationHelper.ValidateFirstNameLastName(user) == true)
                {
                    flag = false;
                    return user;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }
            }
            return null;
        }

        public T ChangePassword(T user)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter new password:");
                string newPassword = Console.ReadLine();
                user.Password = newPassword;
                if (ValidationHelper.ValidatePassword(user) == true)
                {
                    flag = false;
                    return user;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again, password is not strong !");
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }
            }
            return null;
        }

        public T DeactivateAccount(T userInput)
        {
            User user = null;
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                user = _database.RemoveUser(userInput);
                if (user == null)
                {
                    Console.WriteLine("User with that information does not exits");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("User account deactivated");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    flag = false;
                    return (T)user;
                }
            }
            return (T)user;
        }

        public int LogIn()
        {
            User user = null;
            int i = 4;
            while (i > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter log in information\n");
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                user = _database.CheckUser(username, password);
                if (user != null)
                {
                    bool menuflag = true;
                    while (menuflag)
                    {
                        Console.Clear();
                        user.GetInfo();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Welcome to the main menu !");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Choose one of the following options:");
                        Console.WriteLine("1.) Deactivate account");
                        Console.WriteLine("2.) Change password");
                        Console.WriteLine("3.) Change first and last name");
                        Console.WriteLine("4.) Log out");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("5.) Track");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("6.) Statistics");
                        Console.BackgroundColor = ConsoleColor.Black;
                        bool menuChoiceValidation = int.TryParse(Console.ReadLine(), out int menuChoice);
                        if (menuChoiceValidation)
                        {
                            if (menuChoice == 1)
                            {
                                DeactivateAccount((T)user);
                                menuflag = false;
                                return 1;
                            }
                            else if (menuChoice == 2)
                            {
                                _database.UpdateUser(ChangePassword((T)user));
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                menuflag = false;
                                return 2;
                            }
                            else if (menuChoice == 3)
                            {
                                _database.UpdateUser(ChangeFristAndLastName((T)user));
                                menuflag = false;
                                return 3;
                            }
                            else if (menuChoice == 4)
                            {
                                LogOut();
                                menuflag = false;
                                return 9;
                            }
                            else if (menuChoice == 5)
                            {
                                Track((T)user);
                                menuflag = true;
                            }
                            else if (menuChoice == 6)
                            {
                                Statistics((T)user);
                                menuflag = true;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Bad input please try again !");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bad input please try again !");
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect username or password !");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Press any key to enter login information again !\nYou have [{i - 1}] attempts left.");
                    if (i == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("No more attempts left. Goodbye");
                    }
                    Console.ReadKey();
                }
                i--;
            }
            return 0;
        }

        public int LogOut()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Logging out...");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            return 9;
        }

        public void Register()
        {
            bool flag = true;
            while (flag)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Create a new account.\nType information bellow\n");
                Console.WriteLine("Enter first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                Console.WriteLine("Enter age:");
                bool ageValidatorSuccess = int.TryParse(Console.ReadLine(), out int age);
                User newUser = new User(firstName, lastName, age, username, password);
                if (ageValidatorSuccess && ValidationHelper.ValidateUsername(newUser) && ValidationHelper.ValidatePassword(newUser) && ValidationHelper.ValidateFirstNameLastName(newUser) && ValidationHelper.ValidateAge(newUser))
                {
                    _database.InsertUser((T)newUser);
                    flag = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error bad input !\nTry again.");
                    Console.WriteLine(ValidationHelper.ValidateUsername(newUser));
                    Console.WriteLine(ValidationHelper.ValidatePassword(newUser));
                    Console.WriteLine(ValidationHelper.ValidateFirstNameLastName(newUser));
                    Console.WriteLine(ValidationHelper.ValidateAge(newUser));
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
        public void Statistics(T user)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to statistics for {user.FirstName} {user.LastName}\n");
            Console.WriteLine($"Time reading: {Math.Round(user.TimeReading, 2)} minutes.");
            Console.WriteLine($"Time exercising: {Math.Round(user.TimeExercising, 2)} minutes.");
            Console.WriteLine($"Time working: {Math.Round(user.TimeWorking, 2)} minutes.");
            Console.WriteLine($"Time doing other hobbies: {Math.Round(user.TimeOtherHobbies, 2)} minutes.\n");
            Console.WriteLine("Press any key to go to the Main Menu.");
            Console.ReadKey();
        }
        public void Track(T user)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Choose activity:\n");
                Console.WriteLine("1.) Reading");
                Console.WriteLine("2.) Exercising");
                Console.WriteLine("3.) Working");
                Console.WriteLine("4.) Other hobbies");
                bool activityValidation = int.TryParse(Console.ReadLine(), out int activityChoice);
                if (activityValidation)
                {
                    if (activityChoice == 1)
                    {
                        readingActivity.ReadingActivity();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Press ENTER to stop.");
                        string stop = Console.ReadLine();
                        if (stop == "")
                        {
                            stopwatch.Stop();
                            TimeSpan time = stopwatch.Elapsed;
                            double convertedTime = Convert.ToDouble(time.TotalSeconds);
                            user.TimeReading += convertedTime / 60;
                            Console.WriteLine($"Time spent on this activity (For total time go to statistics in the main menu): {Math.Round(convertedTime / 60, 2)} minutes.");
                            Console.WriteLine("Press any key to go back to the Main Menu.");
                            Console.ReadKey();
                            flag = false;
                        }
                    }
                    else if (activityChoice == 2)
                    {
                        exercisingActivity.ExercisingActivity();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Press ENTER to stop.");
                        string stop = Console.ReadLine();
                        if (stop == "")
                        {
                            stopwatch.Stop();
                            TimeSpan time = stopwatch.Elapsed;
                            double convertedTime = Convert.ToDouble(time.TotalSeconds);
                            user.TimeExercising += convertedTime / 60;
                            Console.WriteLine($"Time spent on this activity (For total time go to statistics in the main menu): {Math.Round(convertedTime / 60, 2)} minutes.");
                            Console.WriteLine("Press any key to go back to the Main Menu.");
                            Console.ReadKey();
                            flag = false;
                        }
                    }
                    else if (activityChoice == 3)
                    {
                        workingActivity.WorkingActivity();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Press ENTER to stop.");
                        string stop = Console.ReadLine();
                        if (stop == "")
                        {
                            stopwatch.Stop();
                            TimeSpan time = stopwatch.Elapsed;
                            double convertedTime = Convert.ToDouble(time.TotalSeconds);
                            user.TimeWorking += convertedTime / 60;
                            Console.WriteLine($"Time spent on this activity (For total time go to statistics in the main menu): {Math.Round(convertedTime / 60, 2)} minutes.");
                            Console.WriteLine("Press any key to go back to the Main Menu.");
                            Console.ReadKey();
                            flag = false;
                        }
                    }
                    else if (activityChoice == 4)
                    {
                        otherHobbiesActivity.OtherHobiesActivity();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Press ENTER to stop.");
                        string stop = Console.ReadLine();
                        if (stop == "")
                        {
                            stopwatch.Stop();
                            TimeSpan time = stopwatch.Elapsed;
                            double convertedTime = Convert.ToDouble(time.TotalSeconds);
                            user.TimeOtherHobbies += convertedTime / 60;
                            Console.WriteLine($"Time spent on this activity (For total time go to statistics in the main menu): {Math.Round(convertedTime / 60, 2)} minutes.");
                            Console.WriteLine("Press any key to go back to the Main Menu.");
                            Console.ReadKey();
                            flag = false;
                        }
                    }
                }
            }
        }
    }
}
