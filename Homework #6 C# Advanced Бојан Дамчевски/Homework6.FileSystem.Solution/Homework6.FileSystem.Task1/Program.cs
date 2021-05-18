using System;
using System.IO;

namespace Homework6.FileSystem.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Exercise";
            string filePath = folderPath + @"\calculations.txt";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
            {
                streamWriter.WriteLine(ActionTaker());
            }
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string readResult = streamReader.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(readResult);
            }

            Console.WriteLine("Press ENTER to exit");

            Console.ReadKey();
        }
        public static string Calculate(int number1, int number2)
        {
            int sum = number1 + number2;
            string resultString = $"The equation is: {number1} + {number2}.\nAnd the result is: {sum}\n\n\n";
            Console.ResetColor();
            return resultString;
        }
        public static string ActionTaker()
        {
            string result = "";
            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine("Enter the first number:\n");
                bool validationForTheFirstNumber = int.TryParse(Console.ReadLine(), out int num1);
                Console.WriteLine("Enter the second number:\n");
                bool validationForTheSecondNumber = int.TryParse(Console.ReadLine(), out int num2);

                if (validationForTheFirstNumber && validationForTheSecondNumber)
                {
                    result += Calculate(num1, num2);
                }

                i++;
            }
            return result;
        }
    }
}
