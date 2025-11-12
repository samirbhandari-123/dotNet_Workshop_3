using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===============================
            // 1. Using for loop – Sum from 1 to N
            // ===============================
            Console.Write("Enter a number (N): ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0; // variable to store the sum

            // Calculate sum from 1 to N
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum from 1 to {N} is: {sum}");

            // ===============================
            // 2. Using while loop – Print numbers 1 to 20
            // Skip multiples of 4, stop when number is 15
            // ===============================
            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");

            int number = 1;

            while (number <= 20)
            {
                // Skip multiples of 4
                if (number % 4 == 0)
                {
                    number++;
                    continue; // skip this iteration
                }

                // Stop when number is 15
                if (number == 15)
                {
                    break; // exit the loop
                }

                // Print current number
                Console.WriteLine(number);

                // Increment number
                number++;
            }

            // ===============================
            // 3. Using foreach loop – Sum of array elements
            // ===============================
            Console.WriteLine("\nFinding sum of all elements in an array:");

            // Define an integer array
            int[] numbers = { 2, 4, 6, 8, 10 };

            int arraySum = 0;

            // Loop through each element in array using foreach
            foreach (int num in numbers)
            {
                arraySum += num;
            }

            Console.WriteLine("The sum of all elements in the array is: " + arraySum);

            // Keep console open
            Console.ReadLine();
        }
    }
}
