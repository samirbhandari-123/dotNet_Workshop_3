using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class NullOperation
    {
        // Method to perform null checks
        public void PerformNullChecks()
        {
            // Declare a string variable username and assign null
            string username = null;

            // Using Ternary Operator
            Console.WriteLine("Ternary Operator: " + (username == null ? "Username is not available" : username));

            // Check the null-coalescing operator
            //  username:?? "Username is not avaibale"; // it gives an error,

            // Using Null-Coalescing Operator
            Console.WriteLine("Null-Coalescing Operator: " + (username ?? "Username is not available"));


            // Using Null-Coalescing Assignment Operator
            username ??= "DefaultUser";
            Console.WriteLine("After Null-Coalescing Assignment: " + username);
        }
    }
}

