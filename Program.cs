using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GradeCalculator
{
    class GradeClassification
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade between 0 to 100: ");
            string? input = Console.ReadLine();

            double grade = 0;

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("The grade is between 90 and 100. You got an A!");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("The grade is between 80 and 89. You got a B.");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("The grade is between 70 and 79. You got a C.");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("The grade is between 60 and 69. You got a D.");
            }
            else
            {
                Console.WriteLine("The grade is below 60. You got an F.");
            }
        }
    }
}