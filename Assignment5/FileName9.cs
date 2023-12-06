// 9. Develop a program that simulates a simple calculator with basic arithmetic operations (addition, subtraction, multiplication, and division). Use exception handling to catch and handle various type of exceptions that may occur

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class FileName9
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /): ");
                char operation = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = PerformOperation(num1, num2, operation);
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }

        static double PerformOperation(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    return num1 / num2;
                default:
                    throw new InvalidOperationException("Invalid operation. Please enter +, -, *, or /.");
            }
        }
    }
}