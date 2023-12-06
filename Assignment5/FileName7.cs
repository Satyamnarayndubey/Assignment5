// 7. Implement a program that divides two numbers entered by the user. Handle exceptions like division by zero and invalid input. Continue to prompt the user for valid input until a valid division is performed

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class FileName7
    {
        static void Main()
        {
            bool validInput = false;

            do
            {
                try
                {
                    Console.Write("Enter the numerator: ");
                    int numerator = int.Parse(Console.ReadLine());

                    Console.Write("Enter the denominator: ");
                    int denominator = int.Parse(Console.ReadLine());

                    if (denominator == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }

                    int result = PerformDivision(numerator, denominator);
                    Console.WriteLine($"Result of {numerator} / {denominator} is: {result}");

                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid integers.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            } while (!validInput);
            Console.ReadLine();
        }

        static int PerformDivision(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}