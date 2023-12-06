// 8. Develop a C# program that demonstrates how to use the throw statement to rethrow an exception.Catch the rethrown exception and handle it appropriately

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class FileName8
    {
        static void Main()
        {
            try
            {
                PerformOperation();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught in Main Catch Block: {ex.Message}");
                Console.ReadLine();
            }
        }

        static void PerformOperation()
        {
            try
            {
                Console.WriteLine("Attempting to perform an operation...");
                int result = PerformDivision(10, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught in PerformOperation Catch Block: {ex.Message}");

                Console.WriteLine("Rethrowing the exception...");
                throw;
            }
        }

        static int PerformDivision(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}