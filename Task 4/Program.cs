using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input a number between 1 and 7
            Console.Write("Enter a number (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());

            // Using switch statement to print the day of the week
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }

            Console.ReadLine(); // Keep console open
        }
    }
}
