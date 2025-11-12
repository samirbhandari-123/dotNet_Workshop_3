using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a message asking the user to enter their age
            Console.Write("Enter your age: ");

            // Read user input from the console and convert it from string to integer
            int age = int.Parse(Console.ReadLine());

            // Check the user's age and display the appropriate category
            // Using if - else if - else structure

            if (age < 13)
            {
                // Condition true when age is less than 13
                Console.WriteLine("You are a child.");
            }
            else if (age >= 13 && age <= 19)
            {
                // Condition true when age is between 13 and 19 (inclusive)
                Console.WriteLine("You are a teenager.");
            }
            else // age >= 20
            {
                // Condition true when age is 20 or above
                Console.WriteLine("You are an adult.");
            }

            // Wait for the user to press Enter before closing the console window
            Console.ReadLine();
        }
    }
}
