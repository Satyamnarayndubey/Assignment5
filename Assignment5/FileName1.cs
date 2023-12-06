// 1. Create a C# program that intentionally throws a DivideByZeroException when dividing by zero. Catch the exception and handle it gracefully.

using System;
namespace Assignment5
{
    internal class FileName1
    {
        static int Divide(int num, int deno)
        {
            if (deno == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero");
            }
            return num / deno;
        }
        public static void Main(String[] args)
        {
            try
            {
                int num = 10;
                int deno = 0;
                int res = Divide(num, deno);
                Console.WriteLine(res);
                Console.ReadLine();
            }
            catch (DivideByZeroException S)
            {
                Console.WriteLine(S.Message);
                Console.ReadLine();
            }
        }
    }
}