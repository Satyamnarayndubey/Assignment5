// 6. Create a C# program that includes nested try-catch blocks. Throw an exception in an inner block and catch it in the outer block. Explain the flow of execution

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class FileName6
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Outer Try Block: Start");

                try
                {
                    Console.WriteLine("Inner Try Block: Start");

                    int result = PerformDivision(10, 0);

                    Console.WriteLine("Inner Try Block: End");
                }
                catch (DivideByZeroException innerException)
                {
                    Console.WriteLine($"Caught an exception in the Inner Catch Block: {innerException.Message}");
                }
                finally
                {
                    Console.WriteLine("Inner Finally Block: This block always executes for the inner try-catch");
                }

                Console.WriteLine("Outer Try Block: End");
            }
            catch (Exception outerException)
            {
                Console.WriteLine($"Caught an exception in the Outer Catch Block: {outerException.Message}");
            }
            finally
            {
                Console.WriteLine("Outer Finally Block: This block always executes for the outer try-catch");
            }

            Console.WriteLine("Program End");
            Console.ReadLine();
        }

        static int PerformDivision(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}