using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // Using if-else-if
            if (age < 13)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager.");
            }
            else // age >= 20
            {
                Console.WriteLine("You are an adult.");
            }

            Console.ReadLine(); 
        }
    }
}
