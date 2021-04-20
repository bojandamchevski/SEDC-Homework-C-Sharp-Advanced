using System;
using ClassLibraryTask1.Classes;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Play(Player nickName, Computer computer)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Choose a move: 1) Rock   2) Paper   3) Scissors");
            bool successMove = int.TryParse(Console.ReadLine(), out int playerMove);
            List<string> moves = new List<string>()
            {
                "Rock",
                "Paper",
                "Scissors"
            };
            int randomMove = new Random().Next(1, 3);
            if (!successMove)
            {
                throw new Exception("Invalid move");
            }
            else
            {
                if (playerMove <= 3 && playerMove >= 1)
                {
                    Console.WriteLine($"Player {nickName.NickName} picked {moves[playerMove - 1]}");
                    Console.WriteLine($"The computer picked {moves[randomMove - 1]}");
                    if ((playerMove == 1 && randomMove == 1) || (playerMove == 2 && randomMove == 2) || (playerMove == 3 && randomMove == 3))
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("It's a tie");
                        nickName.NumberOfGames++;
                        computer.NumberOfGames++;
                    }
                    else if ((playerMove == 1 && randomMove == 2) || (playerMove == 3 && randomMove == 1) || (playerMove == 2 && randomMove == 3))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Computer wins !");
                        nickName.NumberOfGames++;
                        computer.NumberOfGames++;
                        computer.GamesWon++;
                    }
                    else if ((playerMove == 2 && randomMove == 1) || (playerMove == 1 && randomMove == 3) || (playerMove == 3 && randomMove == 2))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0} wins !", nickName.NickName);
                        nickName.NumberOfGames++;
                        computer.NumberOfGames++;
                        nickName.GamesWon++;
                    }
                }
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("Press any button to go to the menu.");
            Console.ReadKey();
        }
        static void Stats(Player nickName, Computer computer)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome to the stats !");
            double percentagePlayer = nickName.GamesWon / (double)nickName.NumberOfGames * 100;
            percentagePlayer = Math.Round(percentagePlayer, 2);
            double percentageComputer = computer.GamesWon / (double)computer.NumberOfGames * 100;
            percentageComputer = Math.Round(percentageComputer, 2);
            Console.WriteLine($"{nickName.NickName} won {nickName.GamesWon} games out of {nickName.NumberOfGames} games and the success rate was {percentagePlayer}%.");
            Console.WriteLine($"Computer won {computer.GamesWon} games out of {computer.NumberOfGames} games and the success rate was {percentageComputer}%.");
            Console.WriteLine("=========================================");
            Console.WriteLine("Press any button to go to the menu.");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            bool flag = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Let's play rock, paper, scissors");
            Console.WriteLine("Enter player name: ");
            Player player = new Player(Console.ReadLine());
            Computer computer = new Computer();
            while (flag)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter one of the numbers in the menu:");
                    Console.WriteLine("1) Play   2) Stats   3) Exit");
                    bool success = int.TryParse(Console.ReadLine(), out int choice);

                    if (!success)
                    {
                        throw new Exception("Invalid input !");
                    }
                    else
                    {
                        if (choice <= 3 && choice >= 1)
                            if (choice == 1)
                            {
                                Play(player, computer);
                            }
                            else if (choice == 2)
                            {
                                Stats(player, computer);
                            }
                            else
                            {
                                flag = false;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Thank you for playing :)");
                            }
                        else
                        {
                            throw new Exception("Invalid option chosen !");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("An error has occured.");
                    Console.WriteLine("Try again if you want :)");
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
