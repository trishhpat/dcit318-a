using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace TicketPriceCalculator
{
    class Ticket
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            string? input = Console.ReadLine();

            int age = 20;

            if (int.TryParse(input, out age))
            {
                if (age >= 0 && age <= 12 || age >= 65)
                {
                    double discountedPrice = 7.0;

                    Console.WriteLine($"Your ticket price is GHC{discountedPrice}");
                }
                else if (age > 12 && age < 65)
                {
                    double regularPrice = 10.0;

                    Console.WriteLine($"Your ticket price is GHC{regularPrice}");
                }
            }
            else
            {
                Console.WriteLine("Your input is invalid. Enter a number");
            }
        }
    }
}