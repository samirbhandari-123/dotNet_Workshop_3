using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Operators
    {
        // Method to add two numbers
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }

        // Method to subtract two numbers
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }

        // Method to multiply two numbers
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }

        // Method to divide two numbers
        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine("Division: " + ((double)a / b));
            else
                Console.WriteLine("Cannot divide by zero!");
        }

        // Method to check if a number is odd or even using ternary operator
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }
}
