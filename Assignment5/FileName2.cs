// 2. Write a program that attempts to access an array element at an index that is out of bounds. Use a try-catch block to handle the IndexOutOfRangeException.

using System;
namespace Assignment5
{
    internal class FileName2
    {
        public static void Main(String[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            try
            {
                int index = 10;
                int value = num[index];
                Console.WriteLine("Value at index " + index + " : " + value);
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException S)
            {
                Console.WriteLine(S.Message);
                Console.ReadLine();
            }
        }
    }
}