// 5. Build a C# program that demonstrates the use of multiple catch blocks for different exception types.Handle exceptions such as IndexOutOfRangeException, FormatException, and InvalidOperationException

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class FileName5
    {
        static void Main()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine("Accessing an element at index 5: " + numbers[5]);

                string invalidNumber = "abc";
                int parsedNumber = int.Parse(invalidNumber);

                throw new InvalidOperationException("This is an InvalidOperationException");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"InvalidOperationException: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}