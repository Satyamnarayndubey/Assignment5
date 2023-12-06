// 4. Implement a C# program that uses a custom exception class. Create a custom exception and throw it in your code when a specific condition is met.

using System;
namespace Assignment5
{
    internal class FileName4
    {
        public static void Main(String[]args)
        {
            int userInput = -5;
            try
            {
                if (userInput < 0)
                {
                    throw new CustomException("Input cannot be negative");
                }

                Console.WriteLine(userInput);
                Console.ReadLine();
            }
            catch (CustomException S)
            {
                Console.WriteLine(S.Message);
                Console.ReadLine();
            }
        }
        public class CustomException : Exception
        {
            public CustomException(string message) : base(message)
            {
            }
        }
    }
}