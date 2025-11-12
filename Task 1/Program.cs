
using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object of Operators class
            Operators op = new Operators();

            // Taking user input for operations
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- Results ---");

            // Call all methods of Operators class
            op.Add(a, b);
            op.Subtract(a, b);
            op.Multiply(a, b);
            op.Divide(a, b);

            // Call OddEvenFinder method
            Console.Write("\nEnter a number to check Odd or Even: ");
            int number = Convert.ToInt32(Console.ReadLine());
            op.OddEvenFinder(number);

            Console.ReadLine();
        }
    }
}
