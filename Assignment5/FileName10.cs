// 10. Write a C# program that simulates adding items to a shopping cart. The program should take user input for the price of items and store them in an array. Implement exception handling with multiple catch blocks to handle various scenarios

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class FileName10
    {
        static void Main()
        {
            const int MaxPrice = 10000;

            Console.WriteLine("Welcome to the Shopping Cart!");
            Console.WriteLine("Enter the prices of items to add to your cart.");
            Console.WriteLine("Enter a negative price to finish.");

            int[] shoppingCart = new int[100];
            int cartIndex = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter the price of the item (or a negative value to finish): ");
                    string input = Console.ReadLine();

                    int price = int.Parse(input);
                    if (price < 0)
                        break;

                    if (price < 0)
                    {
                        throw new NegativePriceException("Error: Negative prices are not allowed.");
                    }

                    if (!int.TryParse(input, out _))
                    {
                        throw new FormatException("Error: Invalid input. Please enter a valid price.");
                    }

                    if (price > MaxPrice)
                    {
                        throw new PriceTooHighException($"Error: Price exceeds the maximum value of {MaxPrice}.");
                    }

                    shoppingCart[cartIndex++] = price;
                }
                catch (NegativePriceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (PriceTooHighException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }

            int totalPrice = 0;
            for (int i = 0; i < cartIndex; i++)
            {
                totalPrice += shoppingCart[i];
            }

            Console.WriteLine($"Thank you for shopping! Your total price is: {totalPrice}");
            Console.ReadLine();
        }
        
    }

    class NegativePriceException : Exception
    {
        public NegativePriceException(string message) : base(message) { }
    }

    class PriceTooHighException : Exception
    {
        public PriceTooHighException(string message) : base(message) { }
    }
}