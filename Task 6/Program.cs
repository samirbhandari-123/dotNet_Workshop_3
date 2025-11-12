using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===============================
            // 1. Try-Catch-Finally Example
            // ===============================
            Console.WriteLine("=== Task 6: Part 1 - Try Catch Finally ===");

            try
            {
                // Ask user to enter a number
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Try converting input to integer
                int number = Convert.ToInt32(input);

                // Display number if conversion successful
                Console.WriteLine("You entered number: " + number);
            }
            catch (FormatException)
            {
                // Handles invalid number input (e.g., letters)
                Console.WriteLine("Invalid number format.");
            }
            finally
            {
                // This block always executes
                Console.WriteLine("Program Executed.");
            }

            // ===============================
            // 2. Throw Exception Example (Password check)
            // ===============================
            Console.WriteLine("\n=== Task 6: Part 2 - Throw Exception ===");

            try
            {
                // Ask user to enter password
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                // Check password length
                if (password.Length < 6)
                {
                    // Throw custom exception
                    throw new Exception("Password must be at least 6 characters.");
                }

                // If password is valid
                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                // Display custom exception message
                Console.WriteLine(ex.Message);
            }

            // Keep console window open
            Console.ReadLine();
        }
    }
}