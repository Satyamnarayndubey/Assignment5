// 3. Create a C# program that uses a try-catch block to handle an exception when converting a string to an integer using int.Parse().Handle the FormatException that may occur.

using System;
namespace Assignment5
{
    internal class FileName3
    {
        public static void Main(String[]args)
        {
            string userInput = "abc";
            try
            {
                int number = int.Parse(userInput);
                Console.WriteLine("Parsed number: " + number);
                Console.ReadLine();
            }
            catch (FormatException S)
            {
                Console.WriteLine(S.Message);
                Console.ReadLine();
            }
        }
    }
}