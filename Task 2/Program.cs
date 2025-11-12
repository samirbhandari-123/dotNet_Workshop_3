using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            // Create an instance of NullOperation
            NullOperation nullOp = new NullOperation();

            // Call the PerformNullChecks method
            nullOp.PerformNullChecks();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
